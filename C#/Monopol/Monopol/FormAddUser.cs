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
    public partial class FormAddUser : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddUser(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
            {
                buttonAdd.Enabled = false;
                dataGridView1.Columns[5].Visible = false;
            }

            FillCityCombo();
        }
        private void FillCityCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)        //מוסיף משתמש 
        {
            if (userCheckPassword.Text == userPassword.Text)
            {
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    string str = string.Format
                                        ("INSERT INTO tblUsers " +
                                         "(userId, UserFirstName, UserLastName, UserAddress, UserCity, userPassword, UserPhone, userIsManager, UserMobile, userMail, userPicture) " +
                                         " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7}, \"{8}\", \"{9}\", \"{10}\")",
                                           userId.Text, userFirstName.Text, userLastName.Text,
                                           userAddress.Text, comboCity.Text, userPassword.Text, userPhone.Text, userIsManager.Checked, userMobile.Text, userEmail.Text, userPictureLocation.Text);
                    datacommand.CommandText = str;
                    datacommand.ExecuteNonQuery();
                    MessageBox.Show("Insert into tblUsers ended successfully");
                    RefreshDataGridView();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Insert into tblUsers failed \n" + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("the 2 passwords didnt matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }
        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
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
        private void CheckingStrongPasswrod()                     // בודק האם הסיסמא חזקה
        {
            string pass = userPassword.Text;
            if (pass.Length > 0)
            {
                if (pass.Length >= 8)
                {
                    if (ContainNumbersAndChars(pass))
                    {
                        checkStrongPassword.ForeColor = Color.Green;
                        checkStrongPassword.Text = "סיסמה חזקה!!";
                    }
                    else
                    {
                        checkStrongPassword.ForeColor = Color.MediumSpringGreen;
                        checkStrongPassword.Text = "כדאי לך לשים גם אותיות וגם מספרים";
                    }
                }
                else
                    if (pass.Length >= 4)
                    {
                        if (ContainNumbersAndChars(pass))
                        {
                            checkStrongPassword.ForeColor = Color.Blue;
                            checkStrongPassword.Text = "סיסמה בינונית";
                        }
                        else
                        {
                            checkStrongPassword.ForeColor = Color.MediumBlue;
                            checkStrongPassword.Text = "כדאי לך לשים גם אותיות וגם מספרים";
                        }
                    }
                    else
                    {
                        checkStrongPassword.ForeColor = Color.Red;
                        checkStrongPassword.Text = "סיסמה חלשה!";
                    }

            }
        }

        private bool ContainNumbersAndChars(string pass)
        {
            bool isLetters = false;

            for (int i = 0; i < pass.Length; i++)
            {
                for (int t = 65; t <= 90; t++)
                    if (pass[i] == (char)t)
                        isLetters = true;

                for (int n = 97; n <= 122; n++)
                    if (pass[i] == (char)n)
                        isLetters = true;
            }
            if (!isLetters)
                return false;
            else
            {
                if (ContainNumbers(pass))
                    return true;
                else
                    return false;
            }


        }
        private bool ContainNumbers(string pass)
        {
            int z;
            for (int i = 0; i < pass.Length; i++)
            {
                for (z = 49; z <= 57; z++)
                {
                    if (pass[i] == (char)z)
                        return true;
                }
            }
            return false;
        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {
            CheckingStrongPasswrod();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)       // מוסיף תמונה  
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            userPictureLocation.Text = pictureFileName;
        }


    }
}
