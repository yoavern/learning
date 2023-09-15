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
    public partial class FormTblBoards : Form
    {
        bool isManager;
        public FormTblBoards(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            if (!isManager)
            {
                saveButton.Enabled = false;
            }
        }

        private void FormBoards_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBoards.tblBoards' table. You can move, or remove it, as needed.
            this.tblBoardsTableAdapter.Fill(this.dataSetBoards.tblBoards);

        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            try
            {

                DataSetBoards changes = (DataSetBoards)dataSetBoards.GetChanges();
                if (changes == null)
                    return;

                // check for errors

                DataTable dt = changes.tblBoards.GetChanges();

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

                int numRows = tblBoardsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");

                dataSetBoards.AcceptChanges();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Erros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetBoards.RejectChanges();

            }
        }
    }
}
