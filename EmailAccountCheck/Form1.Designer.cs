namespace EmailAccountCheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Submit = new System.Windows.Forms.Button();
            this.DomainsListBox = new System.Windows.Forms.ListBox();
            this.KeyWords = new System.Windows.Forms.TextBox();
            this.MXListBox = new System.Windows.Forms.ListBox();
            this.DomainContainsMX = new System.Windows.Forms.ListBox();
            this.GSQuery = new System.Windows.Forms.RadioButton();
            this.ManualQuery = new System.Windows.Forms.RadioButton();
            this.MinGSResult = new System.Windows.Forms.NumericUpDown();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.ImportFile = new System.Windows.Forms.RadioButton();
            this.GSorMSLabel = new System.Windows.Forms.Label();
            this.MXFind1 = new System.Windows.Forms.TextBox();
            this.MXFind2 = new System.Windows.Forms.TextBox();
            this.ChangeOrNot = new System.Windows.Forms.CheckBox();
            this.DomainsContainsMXButton = new System.Windows.Forms.Button();
            this.SaveMXListBox = new System.Windows.Forms.Button();
            this.SaveDomainsList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SecsData = new System.Windows.Forms.NumericUpDown();
            this.MaxTimeLabel = new System.Windows.Forms.Label();
            this.MaxSecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinGSResult)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecsData)).BeginInit();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.ForeColor = System.Drawing.Color.Black;
            this.Submit.Location = new System.Drawing.Point(616, 67);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // DomainsListBox
            // 
            this.DomainsListBox.FormattingEnabled = true;
            this.DomainsListBox.Location = new System.Drawing.Point(7, 9);
            this.DomainsListBox.Name = "DomainsListBox";
            this.DomainsListBox.Size = new System.Drawing.Size(351, 173);
            this.DomainsListBox.TabIndex = 1;
            this.DomainsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DomainsListBox_MouseDoubleClick_1);
            // 
            // KeyWords
            // 
            this.KeyWords.Location = new System.Drawing.Point(258, 21);
            this.KeyWords.Name = "KeyWords";
            this.KeyWords.Size = new System.Drawing.Size(197, 20);
            this.KeyWords.TabIndex = 2;
            // 
            // MXListBox
            // 
            this.MXListBox.FormattingEnabled = true;
            this.MXListBox.Location = new System.Drawing.Point(363, 9);
            this.MXListBox.Name = "MXListBox";
            this.MXListBox.Size = new System.Drawing.Size(351, 173);
            this.MXListBox.TabIndex = 4;
            // 
            // DomainContainsMX
            // 
            this.DomainContainsMX.FormattingEnabled = true;
            this.DomainContainsMX.Location = new System.Drawing.Point(6, 214);
            this.DomainContainsMX.Name = "DomainContainsMX";
            this.DomainContainsMX.Size = new System.Drawing.Size(705, 160);
            this.DomainContainsMX.TabIndex = 5;
            // 
            // GSQuery
            // 
            this.GSQuery.AutoSize = true;
            this.GSQuery.BackColor = System.Drawing.Color.Transparent;
            this.GSQuery.Location = new System.Drawing.Point(19, 21);
            this.GSQuery.Name = "GSQuery";
            this.GSQuery.Size = new System.Drawing.Size(127, 17);
            this.GSQuery.TabIndex = 6;
            this.GSQuery.TabStop = true;
            this.GSQuery.Text = "Google Search Query";
            this.GSQuery.UseVisualStyleBackColor = false;
            this.GSQuery.CheckedChanged += new System.EventHandler(this.GSQuery_CheckedChanged);
            // 
            // ManualQuery
            // 
            this.ManualQuery.AutoSize = true;
            this.ManualQuery.BackColor = System.Drawing.Color.Transparent;
            this.ManualQuery.Location = new System.Drawing.Point(19, 67);
            this.ManualQuery.Name = "ManualQuery";
            this.ManualQuery.Size = new System.Drawing.Size(91, 17);
            this.ManualQuery.TabIndex = 7;
            this.ManualQuery.TabStop = true;
            this.ManualQuery.Text = "Manual Query";
            this.ManualQuery.UseVisualStyleBackColor = false;
            this.ManualQuery.CheckedChanged += new System.EventHandler(this.ManualQuery_CheckedChanged);
            // 
            // MinGSResult
            // 
            this.MinGSResult.Location = new System.Drawing.Point(163, 21);
            this.MinGSResult.Name = "MinGSResult";
            this.MinGSResult.Size = new System.Drawing.Size(48, 20);
            this.MinGSResult.TabIndex = 16;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.ForeColor = System.Drawing.Color.Black;
            this.OpenFileButton.Location = new System.Drawing.Point(522, 67);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 10;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // ImportFile
            // 
            this.ImportFile.AutoSize = true;
            this.ImportFile.BackColor = System.Drawing.Color.Transparent;
            this.ImportFile.Location = new System.Drawing.Point(19, 44);
            this.ImportFile.Name = "ImportFile";
            this.ImportFile.Size = new System.Drawing.Size(73, 17);
            this.ImportFile.TabIndex = 9;
            this.ImportFile.TabStop = true;
            this.ImportFile.Text = "Import File";
            this.ImportFile.UseVisualStyleBackColor = false;
            this.ImportFile.CheckedChanged += new System.EventHandler(this.ImportFile_CheckedChanged);
            // 
            // GSorMSLabel
            // 
            this.GSorMSLabel.AutoSize = true;
            this.GSorMSLabel.BackColor = System.Drawing.Color.Transparent;
            this.GSorMSLabel.Location = new System.Drawing.Point(469, 25);
            this.GSorMSLabel.Name = "GSorMSLabel";
            this.GSorMSLabel.Size = new System.Drawing.Size(35, 13);
            this.GSorMSLabel.TabIndex = 8;
            this.GSorMSLabel.Text = "label1";
            // 
            // MXFind1
            // 
            this.MXFind1.Location = new System.Drawing.Point(258, 30);
            this.MXFind1.Name = "MXFind1";
            this.MXFind1.Size = new System.Drawing.Size(197, 20);
            this.MXFind1.TabIndex = 9;
            // 
            // MXFind2
            // 
            this.MXFind2.Location = new System.Drawing.Point(486, 30);
            this.MXFind2.Name = "MXFind2";
            this.MXFind2.Size = new System.Drawing.Size(197, 20);
            this.MXFind2.TabIndex = 10;
            // 
            // ChangeOrNot
            // 
            this.ChangeOrNot.AutoSize = true;
            this.ChangeOrNot.BackColor = System.Drawing.Color.Transparent;
            this.ChangeOrNot.ForeColor = System.Drawing.SystemColors.Window;
            this.ChangeOrNot.Location = new System.Drawing.Point(19, 32);
            this.ChangeOrNot.Name = "ChangeOrNot";
            this.ChangeOrNot.Size = new System.Drawing.Size(159, 17);
            this.ChangeOrNot.TabIndex = 11;
            this.ChangeOrNot.Text = "Change MX Record To Find";
            this.ChangeOrNot.UseVisualStyleBackColor = false;
            this.ChangeOrNot.CheckedChanged += new System.EventHandler(this.ChangeOrNot_CheckedChanged);
            // 
            // DomainsContainsMXButton
            // 
            this.DomainsContainsMXButton.Location = new System.Drawing.Point(7, 380);
            this.DomainsContainsMXButton.Name = "DomainsContainsMXButton";
            this.DomainsContainsMXButton.Size = new System.Drawing.Size(75, 23);
            this.DomainsContainsMXButton.TabIndex = 15;
            this.DomainsContainsMXButton.Text = "Save";
            this.DomainsContainsMXButton.UseVisualStyleBackColor = true;
            this.DomainsContainsMXButton.Click += new System.EventHandler(this.DomainsContainsMXButton_Click);
            // 
            // SaveMXListBox
            // 
            this.SaveMXListBox.Location = new System.Drawing.Point(364, 185);
            this.SaveMXListBox.Name = "SaveMXListBox";
            this.SaveMXListBox.Size = new System.Drawing.Size(75, 23);
            this.SaveMXListBox.TabIndex = 14;
            this.SaveMXListBox.Text = "Save";
            this.SaveMXListBox.UseVisualStyleBackColor = true;
            this.SaveMXListBox.Click += new System.EventHandler(this.SaveMXListBox_Click);
            // 
            // SaveDomainsList
            // 
            this.SaveDomainsList.Location = new System.Drawing.Point(7, 185);
            this.SaveDomainsList.Name = "SaveDomainsList";
            this.SaveDomainsList.Size = new System.Drawing.Size(75, 23);
            this.SaveDomainsList.TabIndex = 13;
            this.SaveDomainsList.Text = "Save";
            this.SaveDomainsList.UseVisualStyleBackColor = true;
            this.SaveDomainsList.Click += new System.EventHandler(this.SaveDomainsList_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EmailAccountCheck.Properties.Resources.geo_shapes_black_1280;
            this.panel1.Controls.Add(this.MaxSecLabel);
            this.panel1.Controls.Add(this.MaxTimeLabel);
            this.panel1.Controls.Add(this.SecsData);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.OpenFileButton);
            this.panel1.Controls.Add(this.MinGSResult);
            this.panel1.Controls.Add(this.GSorMSLabel);
            this.panel1.Controls.Add(this.GSQuery);
            this.panel1.Controls.Add(this.KeyWords);
            this.panel1.Controls.Add(this.ImportFile);
            this.panel1.Controls.Add(this.ManualQuery);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(51, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 100);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::EmailAccountCheck.Properties.Resources.geo_shapes_black_1280;
            this.panel2.Controls.Add(this.MXFind2);
            this.panel2.Controls.Add(this.MXFind1);
            this.panel2.Controls.Add(this.ChangeOrNot);
            this.panel2.Location = new System.Drawing.Point(51, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 73);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::EmailAccountCheck.Properties.Resources.geo_shapes_black_1280;
            this.panel3.Controls.Add(this.DomainsContainsMXButton);
            this.panel3.Controls.Add(this.DomainsListBox);
            this.panel3.Controls.Add(this.DomainContainsMX);
            this.panel3.Controls.Add(this.SaveMXListBox);
            this.panel3.Controls.Add(this.MXListBox);
            this.panel3.Controls.Add(this.SaveDomainsList);
            this.panel3.Location = new System.Drawing.Point(51, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 409);
            this.panel3.TabIndex = 16;
            // 
            // SecsData
            // 
            this.SecsData.DecimalPlaces = 1;
            this.SecsData.Location = new System.Drawing.Point(163, 47);
            this.SecsData.Name = "SecsData";
            this.SecsData.Size = new System.Drawing.Size(48, 20);
            this.SecsData.TabIndex = 17;
            this.SecsData.ValueChanged += new System.EventHandler(this.SecsData_ValueChanged);
            // 
            // MaxTimeLabel
            // 
            this.MaxTimeLabel.AutoSize = true;
            this.MaxTimeLabel.Location = new System.Drawing.Point(260, 49);
            this.MaxTimeLabel.Name = "MaxTimeLabel";
            this.MaxTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.MaxTimeLabel.TabIndex = 18;
            // 
            // MaxSecLabel
            // 
            this.MaxSecLabel.AutoSize = true;
            this.MaxSecLabel.BackColor = System.Drawing.Color.Transparent;
            this.MaxSecLabel.Location = new System.Drawing.Point(259, 54);
            this.MaxSecLabel.Name = "MaxSecLabel";
            this.MaxSecLabel.Size = new System.Drawing.Size(35, 13);
            this.MaxSecLabel.TabIndex = 19;
            this.MaxSecLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::EmailAccountCheck.Properties.Resources.dark_background_line_surface_65896_602x339;
            this.ClientSize = new System.Drawing.Size(808, 613);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinGSResult)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ListBox DomainsListBox;
        private System.Windows.Forms.TextBox KeyWords;
        private System.Windows.Forms.ListBox MXListBox;
        private System.Windows.Forms.ListBox DomainContainsMX;
        private System.Windows.Forms.RadioButton GSQuery;
        private System.Windows.Forms.RadioButton ManualQuery;
        private System.Windows.Forms.Label GSorMSLabel;
        private System.Windows.Forms.TextBox MXFind1;
        private System.Windows.Forms.TextBox MXFind2;
        private System.Windows.Forms.CheckBox ChangeOrNot;
        private System.Windows.Forms.Button SaveMXListBox;
        private System.Windows.Forms.Button SaveDomainsList;
        private System.Windows.Forms.Button DomainsContainsMXButton;
        private System.Windows.Forms.RadioButton ImportFile;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.NumericUpDown MinGSResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label MaxTimeLabel;
        private System.Windows.Forms.NumericUpDown SecsData;
        private System.Windows.Forms.Label MaxSecLabel;
    }
}

