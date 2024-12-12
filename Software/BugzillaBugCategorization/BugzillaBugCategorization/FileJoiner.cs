using BugzillaBugCategorization.Data;
using BugzillaBugCategorization.Data.JSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BugzillaBugCategorization
{
    public class FileJoiner
    {
        public string _folderPath { get; }
        internal string _skipFilePath { get; set; }
        private string _fileText;
        private Dictionary<int, Report> _joinedFiles = new Dictionary<int, Report>() { };
        private Form1 _form1;
        TextBox _history_textBox;

        public FileJoiner(string folderPath, Form1 form1)
        {
            _folderPath = folderPath;
            _form1 = form1;
            initControls();
            DeserializeFiles();
        }
        private void DeserializeFiles()
        {
            string[] files = Directory.GetFiles(_folderPath).Where(x => x.EndsWith(".json")).ToArray();
            JoinFiles(files);
        }
        private void JoinFiles(string[] paths)
        {
            int ignoreCount = 0;
            _history_textBox.AppendText($"Failu skaits: {paths.Length}." + Environment.NewLine);
            foreach (string path in paths) 
            {
                _history_textBox.AppendText($"Apstrādājam failu \"{path}\"." + Environment.NewLine);
                string fileText = File.ReadAllText(path);
                List<Report> joinedFiles = JsonConvert.DeserializeObject<List<Report>>(fileText);
                foreach(Report report in joinedFiles)
                {                    
                    if (!_joinedFiles.ContainsKey(report.Id))
                    {
                        _history_textBox.AppendText($"Pievienojam ierakstu ar ID: \"{report.Id}\"." + Environment.NewLine);
                        _joinedFiles.Add(report.Id, report);
                    }
                    else
                    {
                        ignoreCount++;
                        _history_textBox.AppendText($"Ignorējam ierakstu ar ID: \"{report.Id}\"." + Environment.NewLine);
                    }
                }
            }
            _history_textBox.AppendText($"Kopā apvienoti: \"{_joinedFiles.Count}\" ieraksti." + Environment.NewLine);
            _history_textBox.AppendText($"Kopā ignorēti: \"{ignoreCount}\" ieraksti." + Environment.NewLine);
        }
        private void initControls()
        {
            _history_textBox = _form1.Controls.Find("tab2_history", true)[0] as TextBox;            
        }
        internal void SaveJoinedFile()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JSON|*.json|CSV|*.csv";
            saveFileDialog1.Title = "Saglabāt datni";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.EndsWith("json"))
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writer.WriteLine(JsonConvert.SerializeObject(_joinedFiles.Values));
                    }
                }
                
                if (saveFileDialog1.FileName.EndsWith("csv"))
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        writer.WriteLine(SaveToCsv(_joinedFiles.Values.ToList()));
                    }
                }
                
            }  
            
        }
        private string SaveToCsv(List<Report> reportData)
        {
            var props = TypeDescriptor.GetProperties(typeof(Report)).OfType<PropertyDescriptor>();
            var header = string.Join("%TAB%", props.Select(property => property.Name));
            var lines = new List<string> { header };

            foreach (Report data in reportData) 
            { 
                string newLine = data.Id.ToString() + "%TAB%";
                newLine += data.Opening.ToString() + "%TAB%";
                newLine += data.Reporter.ToString() + "%TAB%";
                newLine += data.VerificationStatus.ToString() + "%TAB%";
                newLine += data.ResolutionStatus.ToString() + "%TAB%";
                newLine += data.RootCauseCategory.ToString() + "%TAB%";
                newLine += string.Join(" ", Regex.Split(string.Join(",", data.Components), @"(?:\r\n|\n|\r)")) + "%TAB%";
                newLine += string.Join(" ", Regex.Split(string.Join(",", data.Description), @"(?:\r\n|\n|\r)")) + "%TAB%";

                if (data.FullDescription != null)
                {
                    newLine += string.Join(" ", Regex.Split(string.Join(",", data.Description), @"(?:\r\n|\n|\r)"));
                    newLine += string.Join(" ", Regex.Split(string.Join(",", data.FullDescription), @"(?:\r\n|\n|\r)"));
                }
                else
                    newLine += string.Join(" ", Regex.Split(string.Join(",", data.Description), @"(?:\r\n|\n|\r)"));
                lines.Add(newLine);
            }
            return string.Join("\n", lines);
        }
    }
}
