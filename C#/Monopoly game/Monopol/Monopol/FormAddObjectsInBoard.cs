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
    public partial class FormAddObjectsInBoard : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddObjectsInBoard(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblObjectsInBoard " +
                                     "(oibBoardID, oibRow, oibCol, oibObjectType, oibText1, oibText2, oibText3, oibPayment, oibPicture) " +
                                     " VALUES ({0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7}, \"{8}\")",
                                       oibBoardID.Text, oibRow.Text, oibCol.Text, oibObjectType.Text, oibText1.Text, oibText2.Text, oibText3.Text, oibPayment.Text, oibPicture.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblObjectsInBoard ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblObjectsInBoard failed \n" + err.Message, "Error",
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
                                     "FROM     tblObjectsInBoard " +
                                     "ORDER BY oibBoardID";
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

        private void FormAddObjectsInBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetObjectsInBoard.tblObjectsInBoard' table. You can move, or remove it, as needed.
            this.tblObjectsInBoardTableAdapter.Fill(this.dataSetObjectsInBoard.tblObjectsInBoard);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            oibPicture.Text = pictureFileName;
        }
    }
}
