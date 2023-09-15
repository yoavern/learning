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
    public partial class FormRptStepsByGame : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        private int counter;
        private string gameID;
        private string stepOrderNum;
        private string stepPlayerNum;
        private string stepDice1;
        private string stepDice2;
        private string stepAction;
        private string stepCash1;
        private string stepCash2;
        private string stepProperty1;
        private string stepProperty2;
        private string saveColor = "";
        public FormRptStepsByGame(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            EnableButtons();
        }

        private void FormRptStepsByGame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGames.tblGames' table. You can move, or remove it, as needed.
            this.tblGamesTableAdapter.Fill(this.dataSetGames.tblGames);

        }
        private void Relocation()
        {
            try
            {
                gameID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
                GetSteps(gameID);
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
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

        private void GetSteps(string gameID)
        {
            try
            {
                counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   stepOrderNum, stepPlayerNum, stepdice1, stepDice2, stepAction, stepCash1, stepCash2, stepProperty1, stepProperty2 " +
                                          "FROM     tblSteps   " +
                                          "WHERE    stepGameID = " + gameID + " " +
                                          "ORDER BY stepGameID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    stepOrderNum = dataReader.GetInt32(0).ToString();
                    stepPlayerNum = dataReader.GetInt32(1).ToString();
                    stepDice1 = dataReader.GetInt32(2).ToString();
                    stepDice2 = dataReader.GetInt32(3).ToString();
                    stepAction = dataReader.GetString(4);
                    stepCash1 = dataReader.GetInt32(5).ToString();
                    stepCash2 = dataReader.GetInt32(6).ToString();
                    stepProperty1 = dataReader.GetInt32(7).ToString();
                    stepProperty2 = dataReader.GetInt32(8).ToString();
                    counter++;
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblSteps failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            try
            {
                string[] arr = new string[10];
                if (counter == 1)
                    arr[0] = gameID;
                arr[1] = stepOrderNum;
                arr[2] = stepPlayerNum;
                arr[3] = stepDice1;
                arr[4] = stepDice2;
                arr[5] = stepAction;
                arr[6] = stepCash1;
                arr[7] = stepCash2;
                arr[8] = stepProperty1;
                arr[9] = stepProperty2;

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
