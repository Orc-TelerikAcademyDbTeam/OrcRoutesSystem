namespace RouteSystemUI
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using RouteSystem.UI;

    public partial class RoutesSystemForm : Form
    {
        public RoutesSystemForm()
        {
            InitializeComponent();

            this.importDataTypeSelect.SelectedIndex = 0;
        }

        private void loadExcelButton_Click(object sender, EventArgs e)
        {
            this.loadExcelOpenFileDialog.ShowDialog();
            this.loadExcelTextBox.Text = this.loadExcelOpenFileDialog.FileName;
        }

        private void loadXMLButton_Click(object sender, EventArgs e)
        {
            this.loadXMLOpenFileDialog.ShowDialog();
            this.loadXMLTextbox.Text = this.loadXMLOpenFileDialog.FileName;
        }

        private void hideUnusedLoadData()
        {
            this.loadExcelLabel.Visible = false;
            this.loadExcelButton.Visible = false;
            this.loadExcelTextBox.Visible = false;

            this.loadMongoDBLabel.Visible = false;
            this.loadMongoDBTextBox.Visible = false;

            this.loadXMLLabel.Visible = false;
            this.loadXMLButton.Visible = false;
            this.loadXMLTextbox.Visible = false;

            this.loadMySQLLabel.Visible = false;
            this.loadMySQLTextBox.Visible = false;

            this.loadSQLiteLabel.Visible = false;
            this.loadSQLiteTextBox.Visible = false;
        }

        private void importDataTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.importDataTypeSelect.SelectedItem.ToString() == "MongoDB and Excel")
            {
                hideUnusedLoadData();

                this.loadExcelLabel.Visible = true;
                this.loadExcelButton.Visible = true;
                this.loadExcelTextBox.Visible = true;

                this.loadMongoDBLabel.Visible = true;
                this.loadMongoDBTextBox.Visible = true;
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "XML")
            {
                hideUnusedLoadData();

                this.loadXMLLabel.Visible = true;
                this.loadXMLButton.Visible = true;
                this.loadXMLTextbox.Visible = true;
                this.loadMongoDBLabel.Visible = true;
                this.loadMongoDBTextBox.Visible = true;
            }
        }

        private void importDataTypeButton_Click(object sender, EventArgs e)
        {
            if (this.importDataTypeSelect.SelectedItem.ToString() == "MongoDB and Excel")
            {
                if (this.loadExcelTextBox.Text == "" && this.loadMongoDBTextBox.Text == "")
                {
                    MessageBox.Show("Choose MongoDB connection string and Excel file first!");
                }
                else if (this.loadExcelTextBox.Text == "")
                {
                    MessageBox.Show("Choose Excel file first!");
                }
                else if (this.loadMongoDBTextBox.Text == "")
                {
                    MessageBox.Show("Choose MongoDB connection string first!");
                }
                else
                {
                    UIEngine.ImportExcelAndMongoData(this.loadMongoDBTextBox.Text, this.loadExcelTextBox.Text);
                }
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "XML")
            {
                if (this.loadXMLTextbox.Text == "")
                {
                    MessageBox.Show("Choose XML file first!");
                }
                else if (this.loadMongoDBTextBox.Text == "")
                {
                    MessageBox.Show("Choose MongoDB connection string first!");
                }
                else
                {
                    UIEngine.ImportXMLToMongoAndSQLServer(this.loadMongoDBTextBox.Text, this.loadXMLTextbox.Text);
                }
            }
        }

        private void generateReportButton_Click(object sender, EventArgs e)
        {
            this.SaveReportDialog.ShowDialog();
            var filePathInfo = this.SaveReportDialog.FileName;
            var checkedButton = tabReports.Controls
                .OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            UIEngine.CreateReport(checkedButton, filePathInfo);
            MessageBox.Show("Report created!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckBoxAggregateRouteReport_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void xmlReportRadio_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}