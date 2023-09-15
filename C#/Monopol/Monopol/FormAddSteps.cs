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
    public partial class FormAddSteps : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddSteps(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
            {
                Button1.Enabled = false;
            }
        }

        private void FormAddSteps_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSteps.tblSteps' table. You can move, or remove it, as needed.
            this.tblStepsTableAdapter.Fill(this.dataSetSteps.tblSteps);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblSteps " +
                                     "(stepGameID, stepOrderNum, stepPlayerNum, stepdice1, stepDice2, stepAction, stepCash1, stepCash2, stepProperty1, stepProperty2) " +
                                     " VALUES ({0}, {1}, {2}, {3}, {4}, \"{5}\", {6}, {7}, {8}, {9})",
                                       stepGameID.Text, stepOrderNum.Text, stepPlayerNum.Text, stepDice1.Text, stepDice2.Text, stepAction.Text, stepCash1.Text, stepCash2.Text, stepProperty1.Text, stepProperty2.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblSteps ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblSteps failed \n" + err.Message, "Error",
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
    }
}
