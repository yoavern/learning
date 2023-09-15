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
    public partial class FormControlPlayMonopol : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int color1, color2;
        private int user1Dice, user2Dice;
        private bool firstPlayerStart, RolledTheDice;
        public FormControlPlayMonopol(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            FillBoardCombo();
            FillInformationLabel();
            FillID1Combo();
        }



        private void FillID1Combo()                                   // Populate users1 combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID " +
                                          "FROM tblUsers " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    id1.Items.Add(dataReader.GetValue(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill users combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillID2Combo()                                   // Populate users2 combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT userID " +
                                          "FROM tblUsers " +
                                          "ORDER BY userID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string read = dataReader.GetValue(0).ToString();
                    if(read !=id1.Text)
                        id2.Items.Add(read);
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill users combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillInformationLabel()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT boardID, boardName " +
                                          "FROM tblBoards " +
                                          "ORDER BY boardID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    information.Items.Add(dataReader.GetInt32(0) + " - " + dataReader.GetString(1));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill information label failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillBoardCombo()                                   // Populate boards combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT boardID " +
                                          "FROM tblBoards " +
                                          "ORDER BY boardID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoard.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill boards combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startGame_Click(object sender, EventArgs e)                    // מתחיל את המשחק
        {
            if (color1 == color2)
            {
                MessageBox.Show("the color of user 1 equals to the color of user 2", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (id1.Text == "" || id2.Text == "")
            {
                MessageBox.Show("you need to chose two players", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (comboBoard.Text == "")
            {
                MessageBox.Show("you need to chose a board", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.RolledTheDice == false)
                MessageBox.Show("every player have to roll the dice", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
            else
            {
                bool saveInfoSucceeded;
                saveInfoInDataBase(out saveInfoSucceeded);
                this.Hide();
                FormPlayMonopol frActions = new FormPlayMonopol(comboBoard.Text, dataConnection, isManager, firstPlayerStart, color1, color2, id1.Text, id2.Text);
                frActions.Show();
                frActions.Disposed += new EventHandler(frActions_Disposed);

            }  
        }

        private void saveInfoInDataBase(out bool saveInfoSucceeded)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblGames " +
                                     "(gameBoardID ,gamePlayerID1, gamePlayerID2, gameColor1, gameColor2, gameDate, gameTime, gameMinutes, gameMoves, gameFinished) " +
                                     " VALUES ( {0}, {1}, {2}, \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7}, {8}, {9})",
                                      comboBoard.Text ,id1.Text, id2.Text, color1, color2, DateTime.Today, DateTime.Now, 0, 0, false);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                saveInfoSucceeded = true;
            }
            catch (Exception err)
            {
                saveInfoSucceeded = false;
                MessageBox.Show("Insert into tblGames failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void frActions_Disposed(object sender, EventArgs e)
        {
            comboBoard.Text = "";
                                                           // מאפס את כל הדברים שהמשתמש הכניס
            id1.Text = "";
            user1FirstName.Text = "";
            user1LastName.Text = "";
            user1color.BackColor = Color.Transparent;
            user1PictureBox.ImageLocation = "";
            dice1.ImageLocation = "";

            id2.Text = "";
            user2FirstName.Text = "";
            user2LastName.Text = "";
            user2color.BackColor = Color.Transparent;
            user2PictureBox.ImageLocation = "";
            dice2.ImageLocation = "";

            buttonRoll1.Enabled = true;
            RolledTheDice = false;
            startGame.Enabled = false;


            this.Show();
            this.Activate();

        }

        private void id1_SelectedIndexChanged(object sender, EventArgs e)  
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT userFirstName, userLastName, userPicture " +
                                      "FROM tblUsers " +
                                      "WHERE    userID = " + id1.Text;
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                user1FirstName.Text = dataReader.GetValue(0).ToString();
                user1LastName.Text = dataReader.GetValue(1).ToString();
                user1PictureBox.ImageLocation = dataReader.GetValue(2).ToString();
                user1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            id2.Enabled = true;
            id2.Items.Clear();
            FillID2Combo();
        }

        private void id2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT userFirstName, userLastName, userPicture " +
                                      "FROM tblUsers " +
                                      "WHERE    userID = " + id2.Text;
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                user2FirstName.Text = dataReader.GetValue(0).ToString();
                user2LastName.Text = dataReader.GetValue(1).ToString();
                user2PictureBox.ImageLocation = dataReader.GetValue(2).ToString();
                user2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            
        }

        private void colorButton1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            user1color.BackColor = cd.Color;
            color1 = user1color.BackColor.ToArgb();
        }

        private void colorButton2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            user2color.BackColor = cd.Color;
            color2 = user2color.BackColor.ToArgb();
        }

        private void buttonRoll1_Click(object sender, EventArgs e)
        {
            buttonRoll1.Enabled = false;
            Random rand = new Random();
            this.user1Dice = rand.Next(1, 7);
            switch (this.user1Dice)
            {
                case 1:
                    dice1.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice1.jpg";
                    break;
                case 2:
                    dice1.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice2.jpg";
                    break;
                case 3:
                    dice1.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice3.jpg";
                    break;
                case 4:
                    dice1.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice4.jpg";
                    break;
                case 5:
                    dice1.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice5.jpg";
                    break;
                case 6:
                    dice1.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice6.jpg";
                    break;
            }

            dice1.SizeMode = PictureBoxSizeMode.StretchImage;
            buttonRoll2.Enabled = true;
        }

        private void buttonRoll2_Click(object sender, EventArgs e)
        {
            buttonRoll2.Enabled = false;
            Random rand = new Random();
            this.user2Dice = rand.Next(1, 7);
            switch (this.user2Dice)
            {
                case 1:
                    dice2.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice1.jpg";
                    break;
                case 2:
                    dice2.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice2.jpg";
                    break;
                case 3:
                    dice2.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice3.jpg";
                    break;
                case 4:
                    dice2.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice4.jpg";
                    break;
                case 5:
                    dice2.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice5.jpg";
                    break;
                case 6:
                    dice2.ImageLocation = "C:\\Projects_2017\\Project_YoavErnst\\Pictures\\dice6.jpg";
                    break;
            }

            dice2.SizeMode = PictureBoxSizeMode.StretchImage;


            if (this.user1Dice > this.user2Dice)                             // checks who need to start the game
            {
                MessageBox.Show("the first player start", "good luck!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.firstPlayerStart = true;
                this.RolledTheDice = true;
            }
                
            else if (this.user1Dice < this.user2Dice)
            {
                MessageBox.Show("the second player start", "good luck!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.firstPlayerStart = false;
                this.RolledTheDice = true;
            }
                
            else
            {
                MessageBox.Show("you need to reroll again", "good luck!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                buttonRoll1.Enabled = true;
                buttonRoll2.Enabled = false;
            }
            startGame.Enabled = true;
                
        }

        
        
    }
}
