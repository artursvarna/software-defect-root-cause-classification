using BugzillaBugCategorization.Data;

namespace BugzillaBugCategorization
{
    public partial class Form1 : Form
    {
        private Categorizer _categorizer;
        private FileJoiner _fileJoiner;
        private string _modifiedDataPath;
        private string _folderPath;
        private string _joinableFolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void modified_errors_path_finder_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _modifiedDataPath = openFileDialog1.FileName;
                history_textBox.AppendText($"Fails: {_modifiedDataPath}" + Environment.NewLine);
                modified_file_path.Text = _modifiedDataPath;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            history_textBox.AppendText("Darbība sākta." + Environment.NewLine);
            int size = -1;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                start_button.Enabled = true;
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    _folderPath = folderBrowserDialog.SelectedPath;
                    history_textBox.AppendText($"Mape: {_folderPath}" + Environment.NewLine);
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                    pathTextBox.Text = _folderPath;


                    if (files.Where(x => x.EndsWith("reports.json")) != null)
                        history_textBox.AppendText($"Fails: \"reports.json\" atrasts." + Environment.NewLine);
                    else
                    {
                        history_textBox.AppendText($"Fails: \"reports.json\" nav atrasts." + Environment.NewLine);
                        start_button.Enabled = false;
                    }

                    if (files.Where(x => x.EndsWith("component.json")) != null)
                        history_textBox.AppendText($"Fails: \"component.json\" atrasts." + Environment.NewLine);
                    else
                    {
                        history_textBox.AppendText($"Fails: \"component.json\" nav atrasts." + Environment.NewLine);
                        start_button.Enabled = false;
                    }

                    if (files.Where(x => x.EndsWith("resolution.json")) != null)
                        history_textBox.AppendText($"Fails: \"resolution.json\" atrasts." + Environment.NewLine);
                    else
                    {
                        history_textBox.AppendText($"Fails: \"resolution.json\" nav atrasts." + Environment.NewLine);
                        start_button.Enabled = false;
                    }

                    if (files.Where(x => x.EndsWith("short_desc.json")) != null)
                        history_textBox.AppendText($"Fails: \"short_desc.json\" atrasts." + Environment.NewLine);
                    else
                    {
                        history_textBox.AppendText($"Fails: \"short_desc.json\" nav atrasts." + Environment.NewLine);
                        start_button.Enabled = false;
                    }
                }
            }
        }
        private void initCategorizer(string folderPath, string modifiedFilePath)
        {
            _categorizer = new Categorizer(folderPath, modifiedFilePath, this);
        }
        private void initFileJoiner(string folderPath)
        {
            _fileJoiner = new FileJoiner(folderPath, this);
        }
        private void readFirstLine()
        {

        }
        private void start_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_folderPath))
                    initCategorizer(_folderPath, _modifiedDataPath);
            }
            catch (IOException) { }

        }

        private void category_1_Click(object sender, EventArgs e)
        {
            //_categorizer.Categorize(error_id.Text, RC_Categories.InadequateRequirements);
            _categorizer.Categorize(error_id.Text, RC_Categories.Requirements);
        }

        private void category_4_Click(object sender, EventArgs e)
        {
            //_categorizer.Categorize(error_id.Text, RC_Categories.IncorrectFunctionalDesign);
            _categorizer.Categorize(error_id.Text, RC_Categories.Architecture);
        }

        private void category_7_Click(object sender, EventArgs e)
        {
            //_categorizer.Categorize(error_id.Text, RC_Categories.DeviationFromCoding);
            _categorizer.Categorize(error_id.Text, RC_Categories.Development);
        }

        private void category_12_Click(object sender, EventArgs e)
        {
            //_categorizer.Categorize(error_id.Text, RC_Categories.TestingStandards);
            _categorizer.Categorize(error_id.Text, RC_Categories.Testing);
        }

        private void sjip_button_Click(object sender, EventArgs e)
        {
            _categorizer.SkipError(error_id.Text);
        }

        private void start_join_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_joinableFolderPath))
                initFileJoiner(_joinableFolderPath);
        }

        private void tab2_save_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_joinableFolderPath))
                _fileJoiner.SaveJoinedFile();
        }

        private void tab2_path_button2_Click(object sender, EventArgs e)
        {
            history_textBox.AppendText("Darbība sākta." + Environment.NewLine);
            int size = -1;
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                start_button.Enabled = true;
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    _joinableFolderPath = folderBrowserDialog.SelectedPath;
                    history_textBox.AppendText($"Mape: {_joinableFolderPath}" + Environment.NewLine);
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                    tab2_path_textbox.Text = _joinableFolderPath;
                }
            }
        }
    }
}
