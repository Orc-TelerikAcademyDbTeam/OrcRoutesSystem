namespace RouteSystemUI
{
    partial class RoutesSystemForm
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
            this.tabRouteSystem = new System.Windows.Forms.TabControl();
            this.tabLoadData = new System.Windows.Forms.TabPage();
            this.loadExcelTextBox = new System.Windows.Forms.TextBox();
            this.loadXMLTextbox = new System.Windows.Forms.TextBox();
            this.loadSQLiteTextBox = new System.Windows.Forms.TextBox();
            this.loadSQLiteLabel = new System.Windows.Forms.Label();
            this.loadMySQLTextBox = new System.Windows.Forms.TextBox();
            this.loadMySQLLabel = new System.Windows.Forms.Label();
            this.loadXMLButton = new System.Windows.Forms.Button();
            this.loadXMLLabel = new System.Windows.Forms.Label();
            this.loadMongoDBTextBox = new System.Windows.Forms.TextBox();
            this.loadMongoDBLabel = new System.Windows.Forms.Label();
            this.loadExcelButton = new System.Windows.Forms.Button();
            this.loadExcelLabel = new System.Windows.Forms.Label();
            this.importDataTypeButton = new System.Windows.Forms.Button();
            this.importDataTypeLabel = new System.Windows.Forms.Label();
            this.importDataTypeSelect = new System.Windows.Forms.ComboBox();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportFileTypeLabel = new System.Windows.Forms.Label();
            this.reportFileTypeSelect = new System.Windows.Forms.ComboBox();
            this.expenseReportRadioButton = new System.Windows.Forms.RadioButton();
            this.carsReportRadioButton = new System.Windows.Forms.RadioButton();
            this.routesReportRadioButton = new System.Windows.Forms.RadioButton();
            this.driversReportRadioButton = new System.Windows.Forms.RadioButton();
            this.loadExcelOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadXMLOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabRouteSystem.SuspendLayout();
            this.tabLoadData.SuspendLayout();
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRouteSystem
            // 
            this.tabRouteSystem.Controls.Add(this.tabLoadData);
            this.tabRouteSystem.Controls.Add(this.tabReports);
            this.tabRouteSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRouteSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabRouteSystem.ItemSize = new System.Drawing.Size(264, 25);
            this.tabRouteSystem.Location = new System.Drawing.Point(0, 0);
            this.tabRouteSystem.Multiline = true;
            this.tabRouteSystem.Name = "tabRouteSystem";
            this.tabRouteSystem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabRouteSystem.SelectedIndex = 0;
            this.tabRouteSystem.Size = new System.Drawing.Size(534, 286);
            this.tabRouteSystem.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabRouteSystem.TabIndex = 0;
            // 
            // tabLoadData
            // 
            this.tabLoadData.BackColor = System.Drawing.Color.Teal;
            this.tabLoadData.Controls.Add(this.loadExcelTextBox);
            this.tabLoadData.Controls.Add(this.loadXMLTextbox);
            this.tabLoadData.Controls.Add(this.loadSQLiteTextBox);
            this.tabLoadData.Controls.Add(this.loadSQLiteLabel);
            this.tabLoadData.Controls.Add(this.loadMySQLTextBox);
            this.tabLoadData.Controls.Add(this.loadMySQLLabel);
            this.tabLoadData.Controls.Add(this.loadXMLButton);
            this.tabLoadData.Controls.Add(this.loadXMLLabel);
            this.tabLoadData.Controls.Add(this.loadMongoDBTextBox);
            this.tabLoadData.Controls.Add(this.loadMongoDBLabel);
            this.tabLoadData.Controls.Add(this.loadExcelButton);
            this.tabLoadData.Controls.Add(this.loadExcelLabel);
            this.tabLoadData.Controls.Add(this.importDataTypeButton);
            this.tabLoadData.Controls.Add(this.importDataTypeLabel);
            this.tabLoadData.Controls.Add(this.importDataTypeSelect);
            this.tabLoadData.Location = new System.Drawing.Point(4, 29);
            this.tabLoadData.Name = "tabLoadData";
            this.tabLoadData.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoadData.Size = new System.Drawing.Size(526, 253);
            this.tabLoadData.TabIndex = 0;
            this.tabLoadData.Text = "Load Data";
            // 
            // loadExcelTextBox
            // 
            this.loadExcelTextBox.Location = new System.Drawing.Point(13, 177);
            this.loadExcelTextBox.Name = "loadExcelTextBox";
            this.loadExcelTextBox.Size = new System.Drawing.Size(416, 26);
            this.loadExcelTextBox.TabIndex = 14;
            // 
            // loadXMLTextbox
            // 
            this.loadXMLTextbox.Location = new System.Drawing.Point(13, 177);
            this.loadXMLTextbox.Name = "loadXMLTextbox";
            this.loadXMLTextbox.Size = new System.Drawing.Size(416, 26);
            this.loadXMLTextbox.TabIndex = 13;
            // 
            // loadSQLiteTextBox
            // 
            this.loadSQLiteTextBox.Location = new System.Drawing.Point(310, 177);
            this.loadSQLiteTextBox.Name = "loadSQLiteTextBox";
            this.loadSQLiteTextBox.Size = new System.Drawing.Size(119, 26);
            this.loadSQLiteTextBox.TabIndex = 12;
            // 
            // loadSQLiteLabel
            // 
            this.loadSQLiteLabel.AutoSize = true;
            this.loadSQLiteLabel.Location = new System.Drawing.Point(9, 180);
            this.loadSQLiteLabel.Name = "loadSQLiteLabel";
            this.loadSQLiteLabel.Size = new System.Drawing.Size(267, 20);
            this.loadSQLiteLabel.TabIndex = 11;
            this.loadSQLiteLabel.Text = "Enter SQLite Connection String:";
            // 
            // loadMySQLTextBox
            // 
            this.loadMySQLTextBox.Location = new System.Drawing.Point(310, 125);
            this.loadMySQLTextBox.Name = "loadMySQLTextBox";
            this.loadMySQLTextBox.Size = new System.Drawing.Size(119, 26);
            this.loadMySQLTextBox.TabIndex = 10;
            // 
            // loadMySQLLabel
            // 
            this.loadMySQLLabel.AutoSize = true;
            this.loadMySQLLabel.Location = new System.Drawing.Point(9, 128);
            this.loadMySQLLabel.Name = "loadMySQLLabel";
            this.loadMySQLLabel.Size = new System.Drawing.Size(269, 20);
            this.loadMySQLLabel.TabIndex = 9;
            this.loadMySQLLabel.Text = "Enter MySQL Connection String:";
            // 
            // loadXMLButton
            // 
            this.loadXMLButton.Location = new System.Drawing.Point(310, 124);
            this.loadXMLButton.Name = "loadXMLButton";
            this.loadXMLButton.Size = new System.Drawing.Size(119, 28);
            this.loadXMLButton.TabIndex = 8;
            this.loadXMLButton.Text = "Choose";
            this.loadXMLButton.UseVisualStyleBackColor = true;
            this.loadXMLButton.Click += new System.EventHandler(this.loadXMLButton_Click);
            // 
            // loadXMLLabel
            // 
            this.loadXMLLabel.AutoSize = true;
            this.loadXMLLabel.Location = new System.Drawing.Point(9, 128);
            this.loadXMLLabel.Name = "loadXMLLabel";
            this.loadXMLLabel.Size = new System.Drawing.Size(150, 20);
            this.loadXMLLabel.TabIndex = 7;
            this.loadXMLLabel.Text = "Choose XML File:";
            // 
            // loadMongoDBTextBox
            // 
            this.loadMongoDBTextBox.Location = new System.Drawing.Point(310, 125);
            this.loadMongoDBTextBox.Name = "loadMongoDBTextBox";
            this.loadMongoDBTextBox.Size = new System.Drawing.Size(119, 26);
            this.loadMongoDBTextBox.TabIndex = 6;
            // 
            // loadMongoDBLabel
            // 
            this.loadMongoDBLabel.AutoSize = true;
            this.loadMongoDBLabel.Location = new System.Drawing.Point(9, 128);
            this.loadMongoDBLabel.Name = "loadMongoDBLabel";
            this.loadMongoDBLabel.Size = new System.Drawing.Size(291, 20);
            this.loadMongoDBLabel.TabIndex = 5;
            this.loadMongoDBLabel.Text = "Enter MongoDB Connection String:";
            // 
            // loadExcelButton
            // 
            this.loadExcelButton.Location = new System.Drawing.Point(310, 124);
            this.loadExcelButton.Name = "loadExcelButton";
            this.loadExcelButton.Size = new System.Drawing.Size(119, 28);
            this.loadExcelButton.TabIndex = 4;
            this.loadExcelButton.Text = "Choose";
            this.loadExcelButton.UseVisualStyleBackColor = true;
            this.loadExcelButton.Click += new System.EventHandler(this.loadExcelButton_Click);
            // 
            // loadExcelLabel
            // 
            this.loadExcelLabel.AutoSize = true;
            this.loadExcelLabel.Location = new System.Drawing.Point(9, 128);
            this.loadExcelLabel.Name = "loadExcelLabel";
            this.loadExcelLabel.Size = new System.Drawing.Size(157, 20);
            this.loadExcelLabel.TabIndex = 3;
            this.loadExcelLabel.Text = "Choose Excel File:";
            // 
            // importDataTypeButton
            // 
            this.importDataTypeButton.Location = new System.Drawing.Point(310, 63);
            this.importDataTypeButton.Name = "importDataTypeButton";
            this.importDataTypeButton.Size = new System.Drawing.Size(119, 28);
            this.importDataTypeButton.TabIndex = 2;
            this.importDataTypeButton.Text = "Load";
            this.importDataTypeButton.UseVisualStyleBackColor = true;
            this.importDataTypeButton.Click += new System.EventHandler(this.importDataTypeButton_Click);
            // 
            // importDataTypeLabel
            // 
            this.importDataTypeLabel.AutoSize = true;
            this.importDataTypeLabel.Location = new System.Drawing.Point(9, 34);
            this.importDataTypeLabel.Name = "importDataTypeLabel";
            this.importDataTypeLabel.Size = new System.Drawing.Size(162, 20);
            this.importDataTypeLabel.TabIndex = 1;
            this.importDataTypeLabel.Text = "Choose Data Type:";
            // 
            // importDataTypeSelect
            // 
            this.importDataTypeSelect.FormattingEnabled = true;
            this.importDataTypeSelect.Items.AddRange(new object[] {
            "Excel",
            "MongoDB",
            "XML",
            "MySQL and SQLite"});
            this.importDataTypeSelect.Location = new System.Drawing.Point(13, 63);
            this.importDataTypeSelect.Name = "importDataTypeSelect";
            this.importDataTypeSelect.Size = new System.Drawing.Size(287, 28);
            this.importDataTypeSelect.TabIndex = 0;
            this.importDataTypeSelect.SelectedIndexChanged += new System.EventHandler(this.importDataTypeSelect_SelectedIndexChanged);
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.Teal;
            this.tabReports.Controls.Add(this.generateReportButton);
            this.tabReports.Controls.Add(this.reportFileTypeLabel);
            this.tabReports.Controls.Add(this.reportFileTypeSelect);
            this.tabReports.Controls.Add(this.expenseReportRadioButton);
            this.tabReports.Controls.Add(this.carsReportRadioButton);
            this.tabReports.Controls.Add(this.routesReportRadioButton);
            this.tabReports.Controls.Add(this.driversReportRadioButton);
            this.tabReports.Location = new System.Drawing.Point(4, 29);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(526, 253);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Generate Reports";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(281, 167);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(119, 28);
            this.generateReportButton.TabIndex = 6;
            this.generateReportButton.Text = "Export";
            this.generateReportButton.UseVisualStyleBackColor = true;
            // 
            // reportFileTypeLabel
            // 
            this.reportFileTypeLabel.AutoSize = true;
            this.reportFileTypeLabel.Location = new System.Drawing.Point(17, 132);
            this.reportFileTypeLabel.Name = "reportFileTypeLabel";
            this.reportFileTypeLabel.Size = new System.Drawing.Size(244, 20);
            this.reportFileTypeLabel.TabIndex = 5;
            this.reportFileTypeLabel.Text = "Choose File Type For Report:";
            // 
            // reportFileTypeSelect
            // 
            this.reportFileTypeSelect.FormattingEnabled = true;
            this.reportFileTypeSelect.Items.AddRange(new object[] {
            "PDF Report",
            "XML Report",
            "JSON Report"});
            this.reportFileTypeSelect.Location = new System.Drawing.Point(21, 167);
            this.reportFileTypeSelect.Name = "reportFileTypeSelect";
            this.reportFileTypeSelect.Size = new System.Drawing.Size(240, 28);
            this.reportFileTypeSelect.TabIndex = 4;
            // 
            // expenseReportRadioButton
            // 
            this.expenseReportRadioButton.AutoSize = true;
            this.expenseReportRadioButton.Location = new System.Drawing.Point(260, 74);
            this.expenseReportRadioButton.Name = "expenseReportRadioButton";
            this.expenseReportRadioButton.Size = new System.Drawing.Size(156, 24);
            this.expenseReportRadioButton.TabIndex = 3;
            this.expenseReportRadioButton.TabStop = true;
            this.expenseReportRadioButton.Text = "Expense Report";
            this.expenseReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // carsReportRadioButton
            // 
            this.carsReportRadioButton.AutoSize = true;
            this.carsReportRadioButton.Location = new System.Drawing.Point(260, 35);
            this.carsReportRadioButton.Name = "carsReportRadioButton";
            this.carsReportRadioButton.Size = new System.Drawing.Size(124, 24);
            this.carsReportRadioButton.TabIndex = 2;
            this.carsReportRadioButton.TabStop = true;
            this.carsReportRadioButton.Text = "Cars Report";
            this.carsReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // routesReportRadioButton
            // 
            this.routesReportRadioButton.AutoSize = true;
            this.routesReportRadioButton.Location = new System.Drawing.Point(19, 74);
            this.routesReportRadioButton.Name = "routesReportRadioButton";
            this.routesReportRadioButton.Size = new System.Drawing.Size(145, 24);
            this.routesReportRadioButton.TabIndex = 1;
            this.routesReportRadioButton.TabStop = true;
            this.routesReportRadioButton.Text = "Routes Report";
            this.routesReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // driversReportRadioButton
            // 
            this.driversReportRadioButton.AutoSize = true;
            this.driversReportRadioButton.Location = new System.Drawing.Point(21, 35);
            this.driversReportRadioButton.Name = "driversReportRadioButton";
            this.driversReportRadioButton.Size = new System.Drawing.Size(143, 24);
            this.driversReportRadioButton.TabIndex = 0;
            this.driversReportRadioButton.TabStop = true;
            this.driversReportRadioButton.Text = "Drivers Report";
            this.driversReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // loadExcelOpenFileDialog
            // 
            this.loadExcelOpenFileDialog.FileName = "Load Excel File";
            // 
            // loadXMLOpenFileDialog
            // 
            this.loadXMLOpenFileDialog.FileName = "Load XML File";
            // 
            // RoutesSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(534, 286);
            this.Controls.Add(this.tabRouteSystem);
            this.Name = "RoutesSystemForm";
            this.Text = "Routes System";
            this.tabRouteSystem.ResumeLayout(false);
            this.tabLoadData.ResumeLayout(false);
            this.tabLoadData.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRouteSystem;
        private System.Windows.Forms.TabPage tabLoadData;
        private System.Windows.Forms.Label importDataTypeLabel;
        private System.Windows.Forms.ComboBox importDataTypeSelect;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button importDataTypeButton;
        private System.Windows.Forms.TextBox loadSQLiteTextBox;
        private System.Windows.Forms.Label loadSQLiteLabel;
        private System.Windows.Forms.TextBox loadMySQLTextBox;
        private System.Windows.Forms.Label loadMySQLLabel;
        private System.Windows.Forms.Button loadXMLButton;
        private System.Windows.Forms.Label loadXMLLabel;
        private System.Windows.Forms.TextBox loadMongoDBTextBox;
        private System.Windows.Forms.Label loadMongoDBLabel;
        private System.Windows.Forms.Button loadExcelButton;
        private System.Windows.Forms.Label loadExcelLabel;
        private System.Windows.Forms.RadioButton carsReportRadioButton;
        private System.Windows.Forms.RadioButton routesReportRadioButton;
        private System.Windows.Forms.RadioButton driversReportRadioButton;
        private System.Windows.Forms.OpenFileDialog loadExcelOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog loadXMLOpenFileDialog;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.Label reportFileTypeLabel;
        private System.Windows.Forms.ComboBox reportFileTypeSelect;
        private System.Windows.Forms.RadioButton expenseReportRadioButton;
        private System.Windows.Forms.TextBox loadExcelTextBox;
        private System.Windows.Forms.TextBox loadXMLTextbox;
    }
}

