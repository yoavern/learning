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
    public partial class FormTblObjectsInBoard : Form
    {
        bool isManager;
        public FormTblObjectsInBoard(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            if (!isManager)
            {
                saveButton.Enabled = false;
            }
        }

        private void FormObjectsInBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetObjectsInBoard.tblObjectsInBoard' table. You can move, or remove it, as needed.
            this.tblObjectsInBoardTableAdapter.Fill(this.dataSetObjectsInBoard.tblObjectsInBoard);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {

                DataSetObjectsInBoard changes = (DataSetObjectsInBoard)dataSetObjectsInBoard.GetChanges();
                if (changes == null)
                    return;

                // check for errors

                DataTable dt = changes.tblObjectsInBoard.GetChanges();

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

                int numRows = tblObjectsInBoardTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");

                dataSetObjectsInBoard.AcceptChanges();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetObjectsInBoard.RejectChanges();

            }
        }
    }
}
