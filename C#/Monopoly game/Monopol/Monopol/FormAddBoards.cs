using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Monopol
{
    public partial class FormAddBoards : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddBoards(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if(!isManager)
            {
                button1.Enabled = false;
            }
        }

        private void FormAddBoards_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBoards.tblBoards' table. You can move, or remove it, as needed.
            this.tblBoardsTableAdapter.Fill(this.dataSetBoards.tblBoards);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblBoards " +
                                     "(boardID, boardName, boardSubgect, boardRows, boardCols, boardSquarePixels, boardPicture) " +
                                     " VALUES ({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, \"{6}\")",
                                       boardID.Text, boardName.Text, boardSubject.Text, boardRows.Text, boardCols.Text, boardSquarePixels.Text,boardPicture.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblBoards ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblBoards failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblBoards " +
                                     "ORDER BY boardID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
