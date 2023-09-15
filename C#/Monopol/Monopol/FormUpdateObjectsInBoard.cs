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
    public partial class FormUpdateObjectsInBoard : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateObjectsInBoard(OleDbConnection dataConnection, bool isManager)
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

        private void FormUpdateObjectsInBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetObjectsInBoard.tblObjectsInBoard' table. You can move, or remove it, as needed.
            this.tblObjectsInBoardTableAdapter.Fill(this.dataSetObjectsInBoard.tblObjectsInBoard);

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

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = pictureFileName;
            oibPicture.Text = pictureFileName;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblObjectsInBoard  \n" +    
                                           "SET   oibObjectType   =  \"" + oibObjectType.Text + "\" , \n" +
                                                  "oibText1   =  \"" + oibText1.Text + "\" , \n" +
                                                  "oibText2    =  \"" + oibText2.Text + "\" , \n" +
                                                  "oibText3      =  \"" + oibText3.Text + "\" , \n" +
                                                  "oibPayment =    \"" + oibPayment.Text + "\"   , \n" +
                                                  "oibPicture     =  \"" + oibPicture.Text + "\"  \n" +
                                          "WHERE  oibBoardID = " + oibBoardID.Text + " and " + "oibRow = " +oibRow.Text + " and " + "oibCol = " + oibCol.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblObjectsInBoard ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblObjectsInBoard failed \n" + err.Message, "Error",
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
                oibBoardID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                oibRow.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                oibCol.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                oibObjectType.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                oibText1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                oibText2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                oibText3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                oibPayment.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                oibPicture.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                pictureBox1.ImageLocation = oibPicture.Text;
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
    }
}
