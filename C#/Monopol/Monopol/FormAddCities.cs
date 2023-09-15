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
    public partial class FormAddCities : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddCities(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
            {
                button1.Enabled = false;
            }
        }

        private void FormAddCities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCities.tblCities' table. You can move, or remove it, as needed.
            this.tblCitiesTableAdapter.Fill(this.dataSetCities.tblCities);

        }

        private void button1_Click(object sender, EventArgs e)     // מוסיף עיר
        {
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    string str = string.Format
                                        ("INSERT INTO tblCities " +
                                         "(cityName) " +
                                         " VALUES (\"{0}\")",
                                           city.Text);
                    datacommand.CommandText = str;
                    datacommand.ExecuteNonQuery();
                    MessageBox.Show("Insert into tblCities ended successfully");
                    RefreshDataGridView();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Insert into tblCities failed \n" + err.Message, "Error",
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
                                     "FROM     tblCities " +
                                     "ORDER BY cityName";
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
