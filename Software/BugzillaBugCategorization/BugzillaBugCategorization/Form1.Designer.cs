namespace BugzillaBugCategorization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pathTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            category_1 = new Button();
            category_4 = new Button();
            history_textBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            modified_file_path = new TextBox();
            modified_errors_path_finder = new Button();
            start_button = new Button();
            label4 = new Label();
            error_id = new TextBox();
            label6 = new Label();
            error_description = new TextBox();
            label10 = new Label();
            category_7 = new Button();
            category_12 = new Button();
            sjip_button = new Button();
            groupBox1 = new GroupBox();
            componenet_textBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            verificationStatus_textBox = new TextBox();
            label8 = new Label();
            status_textBox = new TextBox();
            bug_description_decision = new TextBox();
            label9 = new Label();
            error_count = new TextBox();
            checkBox_from_end = new CheckBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tab2_save_button = new Button();
            button2 = new Button();
            tab2_path_button2 = new Button();
            tab2_history = new TextBox();
            tab2_path_textbox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // pathTextBox
            // 
            pathTextBox.BorderStyle = BorderStyle.FixedSingle;
            pathTextBox.Location = new Point(6, 21);
            pathTextBox.Name = "pathTextBox";
            pathTextBox.ReadOnly = true;
            pathTextBox.Size = new Size(465, 23);
            pathTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(487, 21);
            button1.Name = "button1";
            button1.Size = new Size(28, 24);
            button1.TabIndex = 1;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(518, 15);
            label1.TabIndex = 2;
            label1.Text = "Norādi JSON (reports.json, short_desc.json, component.json, resolution.json) failu atrašanās vietu";
            // 
            // category_1
            // 
            category_1.Font = new Font("Segoe UI", 12F);
            category_1.Location = new Point(6, 40);
            category_1.Name = "category_1";
            category_1.Size = new Size(175, 84);
            category_1.TabIndex = 3;
            category_1.Text = "Prasības";
            category_1.UseVisualStyleBackColor = true;
            category_1.Click += category_1_Click;
            // 
            // category_4
            // 
            category_4.Font = new Font("Segoe UI", 12F);
            category_4.Location = new Point(216, 40);
            category_4.Name = "category_4";
            category_4.Size = new Size(175, 84);
            category_4.TabIndex = 3;
            category_4.Text = "Projektēšana";
            category_4.UseVisualStyleBackColor = true;
            category_4.Click += category_4_Click;
            // 
            // history_textBox
            // 
            history_textBox.BorderStyle = BorderStyle.FixedSingle;
            history_textBox.Location = new Point(638, 22);
            history_textBox.Multiline = true;
            history_textBox.Name = "history_textBox";
            history_textBox.ReadOnly = true;
            history_textBox.Size = new Size(388, 76);
            history_textBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(638, 5);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 5;
            label2.Text = "Vēsture:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Apstrādātais fails:";
            // 
            // modified_file_path
            // 
            modified_file_path.BorderStyle = BorderStyle.FixedSingle;
            modified_file_path.Location = new Point(6, 74);
            modified_file_path.Name = "modified_file_path";
            modified_file_path.ReadOnly = true;
            modified_file_path.Size = new Size(465, 23);
            modified_file_path.TabIndex = 7;
            // 
            // modified_errors_path_finder
            // 
            modified_errors_path_finder.Location = new Point(487, 74);
            modified_errors_path_finder.Name = "modified_errors_path_finder";
            modified_errors_path_finder.Size = new Size(28, 24);
            modified_errors_path_finder.TabIndex = 1;
            modified_errors_path_finder.Text = "...";
            modified_errors_path_finder.UseVisualStyleBackColor = true;
            modified_errors_path_finder.Click += modified_errors_path_finder_Click;
            // 
            // start_button
            // 
            start_button.BackColor = Color.FromArgb(192, 255, 192);
            start_button.ForeColor = SystemColors.MenuHighlight;
            start_button.Location = new Point(521, 22);
            start_button.Name = "start_button";
            start_button.Size = new Size(107, 75);
            start_button.TabIndex = 8;
            start_button.Text = "Sākt";
            start_button.UseVisualStyleBackColor = false;
            start_button.Click += start_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(6, 125);
            label4.Name = "label4";
            label4.Size = new Size(195, 21);
            label4.TabIndex = 9;
            label4.Text = "Kategorizējamās kļūdas ID:";
            // 
            // error_id
            // 
            error_id.BorderStyle = BorderStyle.FixedSingle;
            error_id.Location = new Point(207, 125);
            error_id.Name = "error_id";
            error_id.ReadOnly = true;
            error_id.Size = new Size(100, 23);
            error_id.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(4, 146);
            label6.Name = "label6";
            label6.Size = new Size(129, 21);
            label6.TabIndex = 12;
            label6.Text = "Kļūdas virsraksts:";
            // 
            // error_description
            // 
            error_description.BorderStyle = BorderStyle.FixedSingle;
            error_description.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            error_description.Location = new Point(6, 170);
            error_description.Multiline = true;
            error_description.Name = "error_description";
            error_description.ReadOnly = true;
            error_description.Size = new Size(622, 204);
            error_description.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(417, 0);
            label10.Name = "label10";
            label10.Size = new Size(181, 21);
            label10.TabIndex = 17;
            label10.Text = "Norādi kļūdas kategoriju";
            // 
            // category_7
            // 
            category_7.Font = new Font("Segoe UI", 12F);
            category_7.Location = new Point(423, 40);
            category_7.Name = "category_7";
            category_7.Size = new Size(175, 84);
            category_7.TabIndex = 3;
            category_7.Text = "Izstrāde";
            category_7.UseVisualStyleBackColor = true;
            category_7.Click += category_7_Click;
            // 
            // category_12
            // 
            category_12.Font = new Font("Segoe UI", 12F);
            category_12.Location = new Point(632, 40);
            category_12.Name = "category_12";
            category_12.Size = new Size(175, 84);
            category_12.TabIndex = 3;
            category_12.Text = "Testēšana";
            category_12.UseVisualStyleBackColor = true;
            category_12.Click += category_12_Click;
            // 
            // sjip_button
            // 
            sjip_button.BackColor = Color.FromArgb(255, 255, 128);
            sjip_button.Font = new Font("Segoe UI", 14F);
            sjip_button.ForeColor = SystemColors.ControlText;
            sjip_button.Location = new Point(845, 40);
            sjip_button.Name = "sjip_button";
            sjip_button.Size = new Size(175, 84);
            sjip_button.TabIndex = 18;
            sjip_button.Text = "Izlaist";
            sjip_button.UseVisualStyleBackColor = false;
            sjip_button.Click += sjip_button_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(category_1);
            groupBox1.Controls.Add(sjip_button);
            groupBox1.Controls.Add(category_4);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(category_7);
            groupBox1.Controls.Add(category_12);
            groupBox1.Location = new Point(6, 645);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 138);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // componenet_textBox
            // 
            componenet_textBox.BorderStyle = BorderStyle.FixedSingle;
            componenet_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            componenet_textBox.Location = new Point(638, 276);
            componenet_textBox.Multiline = true;
            componenet_textBox.Name = "componenet_textBox";
            componenet_textBox.ReadOnly = true;
            componenet_textBox.Size = new Size(388, 98);
            componenet_textBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(638, 252);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 12;
            label5.Text = "Komponentes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(638, 122);
            label7.Name = "label7";
            label7.Size = new Size(147, 21);
            label7.TabIndex = 12;
            label7.Text = "Verifikācijas statuss:";
            // 
            // verificationStatus_textBox
            // 
            verificationStatus_textBox.BorderStyle = BorderStyle.FixedSingle;
            verificationStatus_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            verificationStatus_textBox.Location = new Point(638, 146);
            verificationStatus_textBox.Multiline = true;
            verificationStatus_textBox.Name = "verificationStatus_textBox";
            verificationStatus_textBox.ReadOnly = true;
            verificationStatus_textBox.Size = new Size(388, 38);
            verificationStatus_textBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(638, 187);
            label8.Name = "label8";
            label8.Size = new Size(62, 21);
            label8.TabIndex = 12;
            label8.Text = "Statuss:";
            // 
            // status_textBox
            // 
            status_textBox.BorderStyle = BorderStyle.FixedSingle;
            status_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            status_textBox.Location = new Point(638, 211);
            status_textBox.Multiline = true;
            status_textBox.Name = "status_textBox";
            status_textBox.ReadOnly = true;
            status_textBox.Size = new Size(388, 38);
            status_textBox.TabIndex = 13;
            // 
            // bug_description_decision
            // 
            bug_description_decision.Location = new Point(4, 401);
            bug_description_decision.Multiline = true;
            bug_description_decision.Name = "bug_description_decision";
            bug_description_decision.Size = new Size(1030, 238);
            bug_description_decision.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(6, 377);
            label9.Name = "label9";
            label9.Size = new Size(284, 21);
            label9.TabIndex = 12;
            label9.Text = "Kļūdas apraksts (lēmuma pieņemšanai):";
            // 
            // error_count
            // 
            error_count.BorderStyle = BorderStyle.FixedSingle;
            error_count.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            error_count.Location = new Point(960, 104);
            error_count.Multiline = true;
            error_count.Name = "error_count";
            error_count.ReadOnly = true;
            error_count.Size = new Size(66, 23);
            error_count.TabIndex = 13;
            // 
            // checkBox_from_end
            // 
            checkBox_from_end.AutoSize = true;
            checkBox_from_end.Location = new Point(543, 129);
            checkBox_from_end.Name = "checkBox_from_end";
            checkBox_from_end.Size = new Size(85, 19);
            checkBox_from_end.TabIndex = 21;
            checkBox_from_end.Text = "No beigām";
            checkBox_from_end.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1059, 818);
            tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(bug_description_decision);
            tabPage1.Controls.Add(checkBox_from_end);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(pathTextBox);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(modified_errors_path_finder);
            tabPage1.Controls.Add(status_textBox);
            tabPage1.Controls.Add(history_textBox);
            tabPage1.Controls.Add(error_count);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(verificationStatus_textBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(componenet_textBox);
            tabPage1.Controls.Add(modified_file_path);
            tabPage1.Controls.Add(error_description);
            tabPage1.Controls.Add(start_button);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(error_id);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1051, 790);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kategorizācija";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tab2_save_button);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(tab2_path_button2);
            tabPage2.Controls.Add(tab2_history);
            tabPage2.Controls.Add(tab2_path_textbox);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1051, 790);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datņu modificēšana";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tab2_save_button
            // 
            tab2_save_button.BackColor = Color.Silver;
            tab2_save_button.FlatAppearance.BorderColor = Color.Silver;
            tab2_save_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tab2_save_button.ForeColor = SystemColors.InfoText;
            tab2_save_button.Location = new Point(658, 6);
            tab2_save_button.Name = "tab2_save_button";
            tab2_save_button.Size = new Size(108, 54);
            tab2_save_button.TabIndex = 9;
            tab2_save_button.Text = "Saglabāt";
            tab2_save_button.UseVisualStyleBackColor = false;
            tab2_save_button.Click += tab2_save_button_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(532, 6);
            button2.Name = "button2";
            button2.Size = new Size(111, 54);
            button2.TabIndex = 9;
            button2.Text = "Apvienot";
            button2.UseVisualStyleBackColor = false;
            button2.Click += start_join_Click;
            // 
            // tab2_path_button2
            // 
            tab2_path_button2.Location = new Point(486, 21);
            tab2_path_button2.Name = "tab2_path_button2";
            tab2_path_button2.Size = new Size(28, 24);
            tab2_path_button2.TabIndex = 6;
            tab2_path_button2.Text = "...";
            tab2_path_button2.UseVisualStyleBackColor = true;
            tab2_path_button2.Click += tab2_path_button2_Click;
            // 
            // tab2_history
            // 
            tab2_history.BorderStyle = BorderStyle.FixedSingle;
            tab2_history.Location = new Point(6, 79);
            tab2_history.Multiline = true;
            tab2_history.Name = "tab2_history";
            tab2_history.ReadOnly = true;
            tab2_history.Size = new Size(1039, 705);
            tab2_history.TabIndex = 5;
            // 
            // tab2_path_textbox
            // 
            tab2_path_textbox.BorderStyle = BorderStyle.FixedSingle;
            tab2_path_textbox.Location = new Point(6, 21);
            tab2_path_textbox.Name = "tab2_path_textbox";
            tab2_path_textbox.ReadOnly = true;
            tab2_path_textbox.Size = new Size(465, 23);
            tab2_path_textbox.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 61);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 3;
            label12.Text = "Vēsture:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 3);
            label11.Name = "label11";
            label11.Size = new Size(476, 15);
            label11.TabIndex = 3;
            label11.Text = "Norādi apvienojamo JSON failu atrašanās vietu (ModifiedErrors.json, SkippedErrors.json): ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 845);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Arturs_Varna_Master_Degree_Software";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox pathTextBox;
        private Button button1;
        private Label label1;
        private Button category_1;
        private Button category_4;
        private TextBox history_textBox;
        private Label label2;
        private Label label3;
        private TextBox modified_file_path;
        private Button modified_errors_path_finder;
        private Button start_button;
        private Label label4;
        private TextBox error_id;
        private Label label6;
        private TextBox error_description;
        private Label label10;
        private Button category_7;
        private Button category_12;
        private Button sjip_button;
        private GroupBox groupBox1;
        private TextBox componenet_textBox;
        private Label label5;
        private Label label7;
        private TextBox verificationStatus_textBox;
        private Label label8;
        private TextBox status_textBox;
        private TextBox bug_description_decision;
        private Label label9;
        private TextBox error_count;
        private CheckBox checkBox_from_end;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label11;
        private TextBox tab2_path_textbox;
        private TextBox tab2_history;
        private Label label12;
        private Button tab2_path_button2;
        private Button tab2_save_button;
        private Button button2;
    }
}
