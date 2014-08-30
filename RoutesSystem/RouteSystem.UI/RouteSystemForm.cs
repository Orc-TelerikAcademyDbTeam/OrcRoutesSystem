﻿namespace RouteSystemUI
{
    using System;
    using System.Windows.Forms;

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
            if (this.importDataTypeSelect.SelectedItem.ToString() == "Excel")
            {
                hideUnusedLoadData();

                this.loadExcelLabel.Visible = true;
                this.loadExcelButton.Visible = true;
                this.loadExcelTextBox.Visible = true;
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "MongoDB")
            {
                hideUnusedLoadData();

                this.loadMongoDBLabel.Visible = true;
                this.loadMongoDBTextBox.Visible = true;
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "XML")
            {
                hideUnusedLoadData();

                this.loadXMLLabel.Visible = true;
                this.loadXMLButton.Visible = true;
                this.loadXMLTextbox.Visible = true;
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "MySQL and SQLite")
            {
                hideUnusedLoadData();

                this.loadMySQLLabel.Visible = true;
                this.loadMySQLTextBox.Visible = true;

                this.loadSQLiteLabel.Visible = true;
                this.loadSQLiteTextBox.Visible = true;
            }
        }

        private void importDataTypeButton_Click(object sender, EventArgs e)
        {
            if (this.importDataTypeSelect.SelectedItem.ToString() == "Excel")
            {
                if (this.loadExcelTextBox.Text == "")
                {
                    MessageBox.Show("Choose Excel file first!");
                }
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "MongoDB")
            {
                if (this.loadMongoDBTextBox.Text == "")
                {
                    MessageBox.Show("Choose MongoDB connection string first!");
                }
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "XML")
            {
                if (this.loadXMLTextbox.Text == "")
                {
                    MessageBox.Show("Choose XML file first!");
                }
            }
            else if (this.importDataTypeSelect.SelectedItem.ToString() == "MySQL and SQLite")
            {
                if (this.loadMySQLTextBox.Text == "" && this.loadSQLiteTextBox.Text == "")
                {
                    MessageBox.Show("Choose MongoDB and SQLite connection strings first!");
                }
                else if (this.loadMySQLTextBox.Text == "")
                {
                    MessageBox.Show("Choose MongoDB connection string first!");
                }
                else if (this.loadSQLiteTextBox.Text == "")
                {
                    MessageBox.Show("Choose SQLite connection string first!");
                }
            }
        }
    }
}