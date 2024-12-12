using BugzillaBugCategorization.Data;
using BugzillaBugCategorization.Data.JSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BugzillaBugCategorization
{
    public class Categorizer
    {
        public string _folderPath { get; }
        internal string _modifiedFilePath { get; set; }
        internal string _skipFilePath { get; set; }
        private string _fileText;
        private Dictionary<int, Report> _reportsNewAll = new Dictionary<int, Report>() { };
        private Dictionary<int, Report> _reportsNewNotModified = new Dictionary<int, Report>() { };
        private Dictionary<int, Report> _reportsOld = new Dictionary<int, Report>() { };
        private Dictionary<int, Report> _skippedErrors = new Dictionary<int, Report>() { };
        private Form1 _form1;
        TextBox _history_textBox;
        TextBox _error_id;
        TextBox _error_description;
        TextBox _modified_file_path;
        TextBox _componenet_textBox;
        TextBox _verificationStatus_textBox;
        TextBox _status_textBox;
        TextBox _bug_description_decision;
        TextBox _error_count;
        CheckBox _from_end;

        public Categorizer(string folderPath, string modifiedPath, Form1 form1)
        {
            _folderPath = folderPath;
            _form1 = form1;
            _modifiedFilePath = modifiedPath;
            initControls();
            DeserializeFiles();
            DeserializeOldFile();
            DeserializeSkipFile();
            RemovedModified();
            NextErrorForCategorization();
        }
        private void DeserializeFiles()
        {

            string[] files = Directory.GetFiles(_folderPath);

            DeserializeReports(files.Where(x => x.EndsWith("reports.json")).FirstOrDefault());
            DeserializeComponent(files.Where(x => x.EndsWith("component.json")).FirstOrDefault());
            DeserializeShortDesc(files.Where(x => x.EndsWith("short_desc.json")).FirstOrDefault());
        }
        private void DeserializeReports(string path)
        {
            _history_textBox.AppendText($"Apstrādājam failu \"reports.json\"." + Environment.NewLine);
            string fileText = File.ReadAllText(path);
            JObject reportsJSON = JObject.Parse(fileText);
            foreach (JProperty x in reportsJSON["reports"])
            {
                ReportJSON reportJSON = JsonConvert.DeserializeObject<ReportJSON>(x.Value.ToString());
                _reportsNewAll.Add(int.Parse(x.Name), new Report()
                {
                    Id = int.Parse(x.Name),
                    Opening = reportJSON.Opening,
                    Reporter = reportJSON.Reporter,
                    VerificationStatus = reportJSON.Status,
                    ResolutionStatus = reportJSON.Resolution
                });
            }
        }
        private void DeserializeComponent(string path)
        {
            _history_textBox.AppendText($"Apstrādājam failu \"component.json\"." + Environment.NewLine);
            string fileText = File.ReadAllText(path);
            JObject componentsJSON = JObject.Parse(fileText);

            foreach (JProperty x in componentsJSON["component"])
            {
                if (_reportsNewAll.ContainsKey(int.Parse(x.Name)))
                {
                    Report report = _reportsNewAll.GetValueOrDefault(int.Parse(x.Name));
                    List<ComponentJSON> componentJSON = JsonConvert.DeserializeObject<List<ComponentJSON>>(x.Value.ToString());
                    foreach (ComponentJSON component in componentJSON)
                    {
                        if (!string.IsNullOrEmpty(component.Module))
                            report.Components.Add(component.Module);
                    }
                    _reportsNewAll[int.Parse(x.Name)] = report;
                }
            }
        }
        private void DeserializeShortDesc(string path)
        {
            _history_textBox.AppendText($"Apstrādājam failu \"short_desc.json\"." + Environment.NewLine);
            string fileText = File.ReadAllText(path);
            JObject shortDescsJSON = JObject.Parse(fileText);

            foreach (JProperty x in shortDescsJSON["short_desc"])
            {
                if (_reportsNewAll.ContainsKey(int.Parse(x.Name)))
                {
                    Report report = _reportsNewAll.GetValueOrDefault(int.Parse(x.Name));
                    List<ShortDescJSON> shortDescJSON = JsonConvert.DeserializeObject<List<ShortDescJSON>>(x.Value.ToString());
                    foreach (ShortDescJSON shortDesc in shortDescJSON)
                    {
                        if (!string.IsNullOrEmpty(shortDesc.Description))
                            report.Description.Add(shortDesc.Description);
                    }

                    _reportsNewAll[int.Parse(x.Name)] = report;
                }
            }
        }
        private void DeserializeOldFile()
        {
            if (string.IsNullOrEmpty(_modifiedFilePath))
            {
                _modifiedFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ModifiedErrors.json";
            }
            if (File.Exists(_modifiedFilePath))
            {
                _history_textBox.AppendText($"Fails pastāv." + Environment.NewLine);
                string fileText = File.ReadAllText(_modifiedFilePath);

                foreach (Report report in JsonConvert.DeserializeObject<List<Report>>(fileText))
                {
                    _reportsOld.Add(report.Id, report);
                }
            }
            else
            {
                _history_textBox.AppendText($"Fails nepastāv." + Environment.NewLine);
            }
        }
        private void DeserializeSkipFile()
        {
            if (string.IsNullOrEmpty(_skipFilePath))
            {
                _skipFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\SkippedErrors.json";
            }
            if (File.Exists(_skipFilePath))
            {
                _history_textBox.AppendText($"Fails pastāv." + Environment.NewLine);
                string fileText = File.ReadAllText(_skipFilePath);
                foreach (Report report in JsonConvert.DeserializeObject<List<Report>>(fileText))
                {
                    _skippedErrors.Add(report.Id, report);
                }
            }
            else
            {
                _history_textBox.AppendText($"Fails nepastāv." + Environment.NewLine);
            }
        }
        private void RemovedModified()
        {
            if (_reportsOld.Count > 0)
            {
                List<int> ids = _reportsOld.Select(x => x.Key).ToList();
                ids.AddRange(_skippedErrors.Select(x => x.Key).ToList());

                _reportsNewNotModified = _reportsNewAll;
                foreach (int id in ids)
                {
                    if (_reportsNewNotModified.ContainsKey(id))
                        _reportsNewNotModified.Remove(id);
                }
            }
            else
            {
                _reportsNewNotModified = _reportsNewAll;
            }
        }
        private void initControls()
        {
            _history_textBox = _form1.Controls.Find("history_textBox", true)[0] as TextBox;
            _error_id = _form1.Controls.Find("error_id", true)[0] as TextBox;
            _error_description = _form1.Controls.Find("error_description", true)[0] as TextBox;
            _modified_file_path = _form1.Controls.Find("modified_file_path", true)[0] as TextBox;
            _componenet_textBox = _form1.Controls.Find("componenet_textBox", true)[0] as TextBox;
            _verificationStatus_textBox = _form1.Controls.Find("verificationStatus_textBox", true)[0] as TextBox;
            _status_textBox = _form1.Controls.Find("status_textBox", true)[0] as TextBox;
            _bug_description_decision = _form1.Controls.Find("bug_description_decision", true)[0] as TextBox;
            _error_count = _form1.Controls.Find("error_count", true)[0] as TextBox;
            _from_end = _form1.Controls.Find("checkBox_from_end", true)[0] as CheckBox;
        }
        private void NextErrorForCategorization()
        {
            if (_reportsNewNotModified.Count > 0)
            {
                List<string> statusess = _reportsNewNotModified.Values.Select(x => x.ResolutionStatus).Distinct().ToList();
                int countFixed = _reportsNewNotModified.Values.Count(x => x.ResolutionStatus == "FIXED");
                int countWontFix = _reportsNewNotModified.Values.Count(x => x.ResolutionStatus == "WONTFIX");
                int countWorksForMe = _reportsNewNotModified.Values.Count(x => x.ResolutionStatus == "WORKSFORME");
                int countDuplicate = _reportsNewNotModified.Values.Count(x => x.ResolutionStatus == "DUPLICATE");
                int countINVALID = _reportsNewNotModified.Values.Count(x => x.ResolutionStatus == "INVALID");

                Report report = _reportsNewNotModified[_reportsNewNotModified.Keys.First()];
                if (_from_end.Checked)
                    report = _reportsNewNotModified[_reportsNewNotModified.Keys.Last()];
                
                if (report.ResolutionStatus == "FIXED")
                {
                    _history_textBox.AppendText($"Kategorizējam kļūdu ar Id: {report.Id} un aprakstu: {string.Join(", ", report.Description)}." + Environment.NewLine);
                    _error_id.Text = report.Id.ToString();
                    _error_description.Text = string.Join(", " + Environment.NewLine, report.Description);
                    _componenet_textBox.Text = string.Join(", " + Environment.NewLine, report.Components);
                    _verificationStatus_textBox.Text = report.VerificationStatus;
                    _status_textBox.Text = report.ResolutionStatus;
                    _bug_description_decision.Text = string.Empty;

                    _error_count.Text = _reportsOld.Count.ToString();
                }
                else
                {
                    _history_textBox.AppendText($"Kļūda ar Id: {report.Id} nav validēta. Izlaižam kategorizāciju." + Environment.NewLine);
                    SkipError(report.Id.ToString());
                }
            }
            else
            {
                _history_textBox.AppendText($"Viss kategorizēts." + Environment.NewLine);
            }
        }
        public void Categorize(string errorId, RC_Categories category)
        {
            int validErrorId = int.Parse(errorId);
            if (_reportsNewNotModified[validErrorId].Id == validErrorId)
            {
                _reportsNewNotModified[validErrorId].RootCauseCategory = category.ToString();
                _reportsNewNotModified[validErrorId].FullDescription = _bug_description_decision.Text;
                _reportsOld.Add(_reportsNewNotModified[validErrorId].Id, _reportsNewNotModified[validErrorId]);
                _reportsNewNotModified.Remove(validErrorId);

                SaveChanges();
                NextErrorForCategorization();
            }
            else
            {
                _history_textBox.AppendText($"Kļūdas ID ({validErrorId}) nesakrīt ar pirmo ({_reportsNewAll[0].Id})." + Environment.NewLine);
            }
        }
        public void SkipError(string errorId)
        {
            int validErrorId = int.Parse(errorId);
            if (_reportsNewNotModified[validErrorId].Id == validErrorId)
            {
                if (!_skippedErrors.ContainsKey(_reportsNewNotModified[validErrorId].Id))
                {
                    _skippedErrors.Add(_reportsNewNotModified[validErrorId].Id, _reportsNewNotModified[validErrorId]);
                }
                _reportsNewNotModified.Remove(validErrorId);
                SaveSkip();
                NextErrorForCategorization();
            }
            else
            {
                _history_textBox.AppendText($"Kļūdas ID ({validErrorId}) nesakrīt ar pirmo ({_reportsNewAll[0].Id})." + Environment.NewLine);
            }
        }
        private void SaveSkip()
        {
            string newLine = JsonConvert.SerializeObject(_skippedErrors.Values);

            if (string.IsNullOrEmpty(_skipFilePath))
            {
                _history_textBox.AppendText($"Veidojam failu ModifiedErrors.json" + Environment.NewLine);
                _skipFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\SkippedErrors.json";
                using (StreamWriter writer = new StreamWriter("SkippedErrors.json"))
                {
                    writer.WriteLine(newLine);
                }
            }
            else
            {
                _history_textBox.AppendText($"Izmantojam esošu failu failu {_skipFilePath}" + Environment.NewLine);

                using (StreamWriter writer = new StreamWriter(_skipFilePath))
                {
                    writer.WriteLine(newLine);
                }
                _history_textBox.AppendText($"Izmaiņas saglabātas." + Environment.NewLine);
            }
        }
        private void SaveChanges()
        {
            string newLine = JsonConvert.SerializeObject(_reportsOld.Values);

            if (string.IsNullOrEmpty(_modifiedFilePath))
            {
                _history_textBox.AppendText($"Veidojam failu ModifiedErrors.json" + Environment.NewLine);
                _modifiedFilePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\ModifiedErrors.json";
                _modified_file_path.Text = _modifiedFilePath;
                using (StreamWriter writer = new StreamWriter("ModifiedErrors.json"))
                {
                    writer.WriteLine(newLine);
                }
            }
            else
            {
                _history_textBox.AppendText($"Izmantojam esošu failu failu {_modifiedFilePath}" + Environment.NewLine);

                using (StreamWriter writer = new StreamWriter(_modifiedFilePath))
                {
                    writer.WriteLine(newLine);
                }
                _history_textBox.AppendText($"Izmaiņas saglabātas." + Environment.NewLine);
            }
        }
    }
}
