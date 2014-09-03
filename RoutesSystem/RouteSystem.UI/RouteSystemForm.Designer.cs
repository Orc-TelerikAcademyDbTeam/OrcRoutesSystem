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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutesSystemForm));
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
            this.excelReportLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.expenseReportRadioButton = new System.Windows.Forms.RadioButton();
            this.xmlReportRadio = new System.Windows.Forms.RadioButton();
            this.CheckBoxVehicleInformationReport = new System.Windows.Forms.RadioButton();
            this.CheckBoxAggregateRouteReport = new System.Windows.Forms.RadioButton();
            this.loadExcelOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadXMLOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveReportDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.tabLoadData.BackColor = System.Drawing.Color.Transparent;
            this.tabLoadData.BackgroundImage = global::RouteSystem.UI.Properties.Resources.background;
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
            this.loadMySQLTextBox.Location = new System.Drawing.Point(310, 106);
            this.loadMySQLTextBox.Name = "loadMySQLTextBox";
            this.loadMySQLTextBox.Size = new System.Drawing.Size(119, 26);
            this.loadMySQLTextBox.TabIndex = 10;
            // 
            // loadMySQLLabel
            // 
            this.loadMySQLLabel.AutoSize = true;
            this.loadMySQLLabel.Location = new System.Drawing.Point(9, 109);
            this.loadMySQLLabel.Name = "loadMySQLLabel";
            this.loadMySQLLabel.Size = new System.Drawing.Size(269, 20);
            this.loadMySQLLabel.TabIndex = 9;
            this.loadMySQLLabel.Text = "Enter MySQL Connection String:";
            // 
            // loadXMLButton
            // 
            this.loadXMLButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loadXMLButton.Location = new System.Drawing.Point(310, 142);
            this.loadXMLButton.Name = "loadXMLButton";
            this.loadXMLButton.Size = new System.Drawing.Size(119, 28);
            this.loadXMLButton.TabIndex = 8;
            this.loadXMLButton.Text = "Choose";
            this.loadXMLButton.UseVisualStyleBackColor = false;
            this.loadXMLButton.Click += new System.EventHandler(this.loadXMLButton_Click);
            // 
            // loadXMLLabel
            // 
            this.loadXMLLabel.AutoSize = true;
            this.loadXMLLabel.Location = new System.Drawing.Point(14, 146);
            this.loadXMLLabel.Name = "loadXMLLabel";
            this.loadXMLLabel.Size = new System.Drawing.Size(150, 20);
            this.loadXMLLabel.TabIndex = 7;
            this.loadXMLLabel.Text = "Choose XML File:";
            // 
            // loadMongoDBTextBox
<<<<<<< HEAD
            // 
            this.loadMongoDBTextBox.Location = new System.Drawing.Point(310, 250);
            this.loadMongoDBTextBox.Location = new System.Drawing.Point(310, 106);
=======
            // 
            this.loadMongoDBTextBox.Location = new System.Drawing.Point(311, 106);
>>>>>>> origin/master
            this.loadMongoDBTextBox.Name = "loadMongoDBTextBox";
            this.loadMongoDBTextBox.Size = new System.Drawing.Size(119, 26);
            this.loadMongoDBTextBox.TabIndex = 6;
            // 
            // loadMongoDBLabel
            // 
<<<<<<< HEAD
            this.loadMongoDBLabel.AutoSize = true;
            this.loadMongoDBLabel.Location = new System.Drawing.Point(9, 250);
            this.loadMongoDBLabel.Location = new System.Drawing.Point(14, 109);
=======
            this.loadMongoDBLabel.AutoSize = true;
            this.loadMongoDBLabel.Location = new System.Drawing.Point(14, 109);
>>>>>>> origin/master
            this.loadMongoDBLabel.Name = "loadMongoDBLabel";
            this.loadMongoDBLabel.Size = new System.Drawing.Size(291, 20);
            this.loadMongoDBLabel.TabIndex = 5;
            this.loadMongoDBLabel.Text = "Enter MongoDB Connection String:";
            // 
            // loadExcelButton
            // 
            this.loadExcelButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loadExcelButton.Location = new System.Drawing.Point(310, 210);
            this.loadExcelButton.Name = "loadExcelButton";
            this.loadExcelButton.Size = new System.Drawing.Size(119, 28);
            this.loadExcelButton.TabIndex = 4;
            this.loadExcelButton.Text = "Choose";
            this.loadExcelButton.UseVisualStyleBackColor = false;
            this.loadExcelButton.Click += new System.EventHandler(this.loadExcelButton_Click);
            // 
            // loadExcelLabel
            // 
            this.loadExcelLabel.AutoSize = true;
            this.loadExcelLabel.Location = new System.Drawing.Point(14, 146);
            this.loadExcelLabel.Name = "loadExcelLabel";
            this.loadExcelLabel.Size = new System.Drawing.Size(157, 20);
            this.loadExcelLabel.TabIndex = 3;
            this.loadExcelLabel.Text = "Choose Excel File:";
            // 
            // importDataTypeButton
            // 
            this.importDataTypeButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.importDataTypeButton.Location = new System.Drawing.Point(310, 63);
            this.importDataTypeButton.Name = "importDataTypeButton";
            this.importDataTypeButton.Size = new System.Drawing.Size(119, 28);
            this.importDataTypeButton.TabIndex = 2;
            this.importDataTypeButton.Text = "Load";
            this.importDataTypeButton.UseVisualStyleBackColor = false;
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
            "MongoDB and Excel",
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
            this.tabReports.BackColor = System.Drawing.Color.Transparent;
            this.tabReports.BackgroundImage = global::RouteSystem.UI.Properties.Resources.background;
            this.tabReports.Controls.Add(this.excelReportLabel);
            this.tabReports.Controls.Add(this.label3);
            this.tabReports.Controls.Add(this.label2);
            this.tabReports.Controls.Add(this.label1);
            this.tabReports.Controls.Add(this.generateReportButton);
            this.tabReports.Controls.Add(this.expenseReportRadioButton);
            this.tabReports.Controls.Add(this.xmlReportRadio);
            this.tabReports.Controls.Add(this.CheckBoxVehicleInformationReport);
            this.tabReports.Controls.Add(this.CheckBoxAggregateRouteReport);
            this.tabReports.Location = new System.Drawing.Point(4, 29);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(526, 253);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Generate Reports";
            // 
            // excelReportLabel
            // 
            this.excelReportLabel.AutoSize = true;
            this.excelReportLabel.Location = new System.Drawing.Point(300, 131);
            this.excelReportLabel.Name = "excelReportLabel";
            this.excelReportLabel.Size = new System.Drawing.Size(124, 20);
            this.excelReportLabel.TabIndex = 11;
            this.excelReportLabel.Text = "(Excel Report)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "(XML Report)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "(JSON Report)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "(PDF Report)";
            // 
            // generateReportButton
            // 
            this.generateReportButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.generateReportButton.Location = new System.Drawing.Point(200, 192);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(119, 28);
            this.generateReportButton.TabIndex = 6;
            this.generateReportButton.Text = "Export";
            this.generateReportButton.UseVisualStyleBackColor = false;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // expenseReportRadioButton
            // 
            this.expenseReportRadioButton.AutoSize = true;
            this.expenseReportRadioButton.Location = new System.Drawing.Point(261, 104);
            this.expenseReportRadioButton.Name = "expenseReportRadioButton";
            this.expenseReportRadioButton.Size = new System.Drawing.Size(260, 24);
            this.expenseReportRadioButton.TabIndex = 3;
            this.expenseReportRadioButton.Text = "Average Driver Salary Report";
            this.expenseReportRadioButton.UseVisualStyleBackColor = true;
            // 
            // xmlReportRadio
            // 
            this.xmlReportRadio.AutoSize = true;
            this.xmlReportRadio.Location = new System.Drawing.Point(261, 35);
            this.xmlReportRadio.Name = "xmlReportRadio";
            this.xmlReportRadio.Size = new System.Drawing.Size(232, 24);
            this.xmlReportRadio.TabIndex = 2;
            this.xmlReportRadio.Text = "Fuel Consumption Report";
            this.xmlReportRadio.UseVisualStyleBackColor = true;
            this.xmlReportRadio.CheckedChanged += new System.EventHandler(this.xmlReportRadio_CheckedChanged);
            // 
            // CheckBoxVehicleInformationReport
            // 
            this.CheckBoxVehicleInformationReport.AutoSize = true;
            this.CheckBoxVehicleInformationReport.Location = new System.Drawing.Point(12, 104);
            this.CheckBoxVehicleInformationReport.Name = "CheckBoxVehicleInformationReport";
            this.CheckBoxVehicleInformationReport.Size = new System.Drawing.Size(243, 24);
            this.CheckBoxVehicleInformationReport.TabIndex = 1;
            this.CheckBoxVehicleInformationReport.Text = "Vehicle Information Report";
            this.CheckBoxVehicleInformationReport.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAggregateRouteReport
            // 
            this.CheckBoxAggregateRouteReport.AutoSize = true;
            this.CheckBoxAggregateRouteReport.Checked = true;
            this.CheckBoxAggregateRouteReport.Location = new System.Drawing.Point(14, 35);
            this.CheckBoxAggregateRouteReport.Name = "CheckBoxAggregateRouteReport";
            this.CheckBoxAggregateRouteReport.Size = new System.Drawing.Size(225, 24);
            this.CheckBoxAggregateRouteReport.TabIndex = 0;
            this.CheckBoxAggregateRouteReport.TabStop = true;
            this.CheckBoxAggregateRouteReport.Text = "Aggregate Route Report";
            this.CheckBoxAggregateRouteReport.UseVisualStyleBackColor = true;
            this.CheckBoxAggregateRouteReport.CheckedChanged += new System.EventHandler(this.CheckBoxAggregateRouteReport_CheckedChanged);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.RadioButton xmlReportRadio;
        private System.Windows.Forms.RadioButton CheckBoxVehicleInformationReport;
        private System.Windows.Forms.RadioButton CheckBoxAggregateRouteReport;
        private System.Windows.Forms.OpenFileDialog loadExcelOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog loadXMLOpenFileDialog;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.RadioButton expenseReportRadioButton;
        private System.Windows.Forms.TextBox loadExcelTextBox;
        private System.Windows.Forms.TextBox loadXMLTextbox;
        private System.Windows.Forms.SaveFileDialog SaveReportDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label excelReportLabel;
    }
}

