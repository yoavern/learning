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
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormLogin()
        {
            InitializeComponent();
            if (!OpenDb())
                this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private bool OpenDb()// פעולה שפותחת את מסד הנתונים
        {

            dataConnection = new OleDbConnection();
            try
            {

                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2017\\Project_YoavErnst\\Access\\dbMonopol.accdb";
                dataConnection.Open();
                return true;
            }

            catch (Exception e)
            {

                MessageBox.Show("Error accessing the database: " + e.Message, "Errors",

                MessageBoxButtons.OK,

                MessageBoxIcon.Error);
                return false;
            }


        }

        private void CheckButtonClick(object sender, EventArgs e)// פעולה שבודקת האם ת"ז והסיסמא נכונים
        {
             string firstName, lastName, password, pictureLocation;
             int id;
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  userID, userFirstName, userLastName, userPassword, userIsManager, userPicture  " +
                                          "FROM    tblUsers " +
                                          "WHERE   userID = " + loginID.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                firstName = dataReader.GetString(1);
                lastName = dataReader.GetString(2);
                password = dataReader.GetString(3);
                isManager = dataReader.GetBoolean(4);

               if(dataReader.GetString(5)!="0")
                   pictureLocation = dataReader.GetString(5);
               else
                   pictureLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\noPicture.jpg";
                if (password == loginPassword.Text)
                {
                    loginMessage.Text = "שלום," + " " + firstName + " " + lastName;
                    loginEnter.Visible = false;
                    loginContinue.Visible = true;
                    pictureBox1.ImageLocation = pictureLocation;
                }
                else
                {
                    MessageBox.Show("Invalid password: ", "Error");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Select tblUsers failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

                
          

        }

        void frMenu_Disposed(object sender, EventArgs e)//Menu פעולה שמטפלת בארוע סגירת מסך ה
        {
            loginID.Text = "";
            loginPassword.Text = "";
            loginMessage.Text = "";
            pictureBox1.ImageLocation = "";
            loginEnter.Visible = true;
            loginContinue.Visible = false;
            this.Show();
            this.Activate();
        }

        private void loginContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu frMenu = new FormMenu(dataConnection,isManager);
            frMenu.Show();
            frMenu.Disposed += new EventHandler(frMenu_Disposed);
        }
        

        

    }
}
