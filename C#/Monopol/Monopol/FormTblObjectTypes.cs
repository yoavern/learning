using System;
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
    public partial class FormTblObjectTypes : Form
    {
        bool isManager;
        public FormTblObjectTypes(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            if (!isManager)
            {
                saveButton.Enabled = false;
            }
        }

        private void FormObjectTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetObjectTypes.tblObjectTypes' table. You can move, or remove it, as needed.
            this.tblObjectTypesTableAdapter.Fill(this.dataSetObjectTypes.tblObjectTypes);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {

                DataSetObjectTypes changes = (DataSetObjectTypes)dataSetObjectTypes.GetChanges();
                if (changes == null)
                    return;

                // check for errors

                DataTable dt = changes.tblObjectTypes.GetChanges();

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

                int numRows = tblObjectTypesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");

                dataSetObjectTypes.AcceptChanges();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetObjectTypes.RejectChanges();

            }
        }
    }
}
