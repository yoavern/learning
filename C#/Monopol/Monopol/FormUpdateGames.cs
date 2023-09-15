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
    public partial class FormUpdateGames : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateGames(OleDbConnection dataConnection, bool isManager)
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

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblGames " +
                                     "ORDER BY gameID";
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
                datacommand.CommandText = "UPDATE tblGames  \n" +
                                           "SET   gameBoardID    =  \"" + gameBoardID.Text + "\" , \n" +
                                                  "gamePlayerID1    =  \"" + gamePlayerID1.Text + "\" , \n" +
                                                  "gamePlayerID2   =  \"" + gamePlayerID2.Text + "\" , \n" +
                                                  "gameColor1    =  \"" + gameColor1.Text + "\" , \n" +
                                                  "gameColor2    =  \"" + gameColor2.Text + "\" , \n" +
                                                  "gameDate      =  \"" + gameDate.Text + "\" , \n" +
                                                  " gameTime =    \"" + gameTime.Text + "\"   , \n" +
                                                  "gameMinutes     =  \"" + gameMinutes.Text + "\" , \n" +
                                                  "gameMoves     =  \"" + gameMoves.Text + "\" , \n" +
                                                  "gameFinished       =  " + gameFinished.Checked + "  \n" +
                                          "WHERE  gameID = " + gameID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblGames ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblGames failed \n" + err.Message, "Error",
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
                gameID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                gameBoardID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                gamePlayerID1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                gamePlayerID2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                gameColor1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                gameColor2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                gameDate.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                gameTime.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                gameMinutes.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                gameMoves.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                gameFinished.Checked = dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "True";
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
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

        private void FormUpdateGames_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);

        }
    }
}
