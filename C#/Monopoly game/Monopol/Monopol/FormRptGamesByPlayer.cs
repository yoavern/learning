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
    public partial class FormRptGamesByPlayer : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        private int counter;
        private string userID;
        private string gameID;
        private string gameBoardID;
        private string gamePlayerID1;
        private string gamePlayerID2;
        private string gameColor1;
        private string gameColor2;
        private string gameDate;
        private string gameTime;
        private string gameMinutes;
        private string gameMoves;
        private string gameFinished;
        private string saveColor = "";
        public FormRptGamesByPlayer(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            gameID = null;
            EnableButtons();
            
        }

        private void FormRptGamesByPlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

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
        private void Relocation()
        {
            try
            {
                userID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
                GetGames(userID);
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
            Relocation();
        }
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            Relocation();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            Relocation();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            Relocation();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            Relocation();
        }

        private void GetGames(string userID)
        {
            try
            {
                counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   gameID, gameBoardID, gamePlayerID1, gamePlayerID2, gameColor1, gameColor2, gameDate, gameTime, gameMinutes, gameMoves, gameFinished " +
                                          "FROM     tblGames   " +
                                          "WHERE    gamePlayerID1 = " + userID + " OR gamePlayerID2  = " + userID  + " " +
                                          "ORDER BY gameID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    gameID = dataReader.GetInt32(0).ToString();
                    gameBoardID = dataReader.GetInt32(1).ToString();
                    gamePlayerID1 = dataReader.GetInt32(2).ToString();
                    gamePlayerID2 = dataReader.GetInt32(3).ToString();
                    gameColor1 = dataReader.GetString(4);
                    gameColor2 = dataReader.GetString(5);
                    gameDate = dataReader.GetDateTime(6).ToShortDateString();
                    gameTime = dataReader.GetDateTime(7).ToShortTimeString();
                    gameMinutes = dataReader.GetInt32(8).ToString();
                    gameMoves = dataReader.GetInt32(9).ToString();
                    gameFinished = dataReader.GetBoolean(10).ToString();
                    counter++;
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblGames failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            try
            {
                string[] arr = new string[12];
                if (counter == 1)
                    arr[0] = userID;
                arr[1] = gameBoardID;
                arr[2] = gamePlayerID1;
                arr[3] = gamePlayerID2;
                arr[4] = gameColor1;
                arr[5] = gameColor2;
                arr[6] = gameDate;
                arr[7] = gameTime;
                arr[8] = gameMinutes;
                arr[9] = gameMoves;
                arr[10] = gameFinished;
                arr[11] = gameID;

                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void cleanRpt_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
