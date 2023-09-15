﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopol
{
    public partial class FormTblSteps : Form
    {
        bool isManager;
        public FormTblSteps(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            if (!isManager)
            {
                saveButton.Enabled = false;
            }
        }

        private void FormSteps_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSteps.tblSteps' table. You can move, or remove it, as needed.
            this.tblStepsTableAdapter.Fill(this.dataSetSteps.tblSteps);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {

                DataSetSteps changes = (DataSetSteps)dataSetSteps.GetChanges();
                if (changes == null)
                    return;

                // check for errors

                DataTable dt = changes.tblSteps.GetChanges();

                DataRow[] badRows = dt.GetErrors(); //find the errors and tell the user

                if (badRows.Length > 0)
                {

                    string errorMsg = "";

                    foreach (DataRow row in badRows)
                    {

                        foreach (DataColumn col in row.GetColumnsInError())
                        {

                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";

                        }

                    }

                    MessageBox.Show("Errors in data: " + errorMsg,

                    "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                //no error found, update the database

                int numRows = tblStepsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");

                dataSetSteps.AcceptChanges();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetSteps.RejectChanges();

            }
        }
    }
}
