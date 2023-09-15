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
    public partial class FormUpdateBoards : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateBoards(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            RefreshDataGridView();
            EnableButtons();
            if (!isManager)
            {
                button1.Enabled = false;
            }
        }

        private void FormUpdateBoards_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetBoards.tblBoards' table. You can move, or remove it, as needed.
            this.tblBoardsTableAdapter.Fill(this.dataSetBoards.tblBoards);

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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblBoards \n" + 
                                             "SET  boardName    =  \"" + boardName.Text + "\" , \n" +
                                                  "boardSubgect    =  \"" + boardSubject.Text + "\" , \n" +
                                                  "boardRows   =  \"" + boardRows.Text + "\" , \n" +
                                                  "boardCols    =  \"" + boardCols.Text + "\" , \n" +
                                                  "boardSquarePixels    =  \"" + boardSquarePixels.Text + "\" , \n" +
                                                  "boardPicture     =  \"" + boardPicture.Text + "\"  \n" +
                                          "WHERE  boardID = " + boardID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblBoards ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblBoards failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                boardID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                boardName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                boardSubject.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                boardRows.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                boardCols.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                boardSquarePixels.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                boardPicture.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }
    }
}
