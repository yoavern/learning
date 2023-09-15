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
    public partial class FormUpdateSteps : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateSteps(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            RefreshDataGridView();
            EnableButtons();
            if (!isManager)
            {
                Button1.Enabled = false;
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblSteps " +
                                     "ORDER BY stepGameID";
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
                datacommand.CommandText = "UPDATE tblSteps  \n" +
                                           "SET    stepPlayerNum    =  \"" + stepPlayerNum.Text + "\" , \n" +
                                                  "stepDice1    =  \"" + stepDice1.Text + "\" , \n" +
                                                  "stepDice2   =  \"" + stepDice2.Text + "\" , \n" +
                                                  "stepAction    =  \"" + stepAction.Text + "\" , \n" +
                                                  "stepCash1    =  \"" + stepCash1.Text + "\" , \n" +
                                                  "stepCash2      =  \"" + stepCash2.Text + "\" , \n" +
                                                  "stepProperty1 =    \"" + stepProperty1.Text + "\"   , \n" +
                                                  "stepProperty2     =  \"" + stepProperty2.Text + "\"  \n" +
                                          "WHERE  stepGameID = " + stepGameID.Text + " and " + "stepOrderNum = " + stepOrderNum.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblSteps ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblSteps failed \n" + err.Message, "Error",
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
                stepGameID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                stepOrderNum.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                stepPlayerNum.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                stepDice1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                stepDice2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                stepAction.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                stepCash1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                stepCash2.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                stepProperty1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                stepProperty2.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
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

        private void FormUpdateSteps_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSteps.tblSteps' table. You can move, or remove it, as needed.
            this.tblStepsTableAdapter.Fill(this.dataSetSteps.tblSteps);

        }
    }
}
