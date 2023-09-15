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
using System.Diagnostics;

namespace Monopol
{
    public partial class FormPlayMonopol : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private BUserControl[,] arrControl;
        private string selectedBoard;
        private int btnWidth = 0, btnHight = 0;
        private int moves;
        private int steps;
        private int result1, result2;                   // מכיל את תוצאת הטלת הקוביות
        private int color1, color2;
        private string id1, id2;
        private bool hadDouble1 = false, hadDouble2 = false;
        private Button RollingButton = new Button();
        private PictureBox dice2 = new PictureBox();
        private PictureBox dice1 = new PictureBox();
        private string firstName1, firstName2, lastName1, lastName2;
        private bool player1Turn;
        private bool finishedGame = false;
        private int player1X = 0, player1Y = 0, player2X = 0, player2Y = 0;
        private int lngRows = 0, lngCols = 0;
        private int prison1 = 0, prison2 = 0;
        private bool inPrison1 = false, inPrison2 = false;
        private string action1, action2;
        private Stopwatch watch;
        public FormPlayMonopol(string selectedBoard, OleDbConnection dataConnection, bool isManager, bool firstPlayerStart, int color1, int color2, string id1, string id2)
        {
            InitializeComponent();
            watch = new Stopwatch();
            this.steps = 0;
            this.selectedBoard = selectedBoard;
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            this.color1 = color1;
            this.color2 = color2;
            this.id1 = id1;
            this.id2 = id2;
            this.player1Turn = firstPlayerStart;
            property1.Text = "1500";
            property2.Text = "1500";
            cash1.Text = property1.Text;
            cash2.Text = property2.Text;
            SetName1();
            SetName2();
            ShowsFrame();
            AddRollingButtons();
            StartGame();
        }

        public void SetName1()
        {
            OleDbCommand datacommand = new OleDbCommand();                      // נותן את שם השחקן הראשון
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT userFirstName, userLastName " +
                                      "FROM tblUsers " +
                                      "WHERE    userID = " + id1;
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                firstName1 = dataReader.GetValue(0).ToString();
                lastName1 = dataReader.GetValue(1).ToString();
            }
        }
        public void SetName2()
        {
            OleDbCommand datacommand = new OleDbCommand();                  // נותן את שם השחקן השני
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT userFirstName, userLastName " +
                                      "FROM tblUsers " +
                                      "WHERE    userID = " + id2;
            OleDbDataReader dataReader = datacommand.ExecuteReader();
            while (dataReader.Read())
            {
                firstName2 = dataReader.GetValue(0).ToString();
                lastName2 = dataReader.GetValue(1).ToString();
            }
        }

        public void StartGame()  // מתחיל את המשחק
        {
            this.WindowState = FormWindowState.Maximized;                                   // משנה את המסמך כך שיהיה על כל המסך
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //שם את הצבעים של השחקנים איפה שהם נמצאים
            arrControl[0, 0].GetPlayer1Button().BackColor = Color.FromArgb(color1);
            arrControl[0, 0].GetPlayer2Button().BackColor = Color.FromArgb(color2);

            switch (player1Turn)                                      // מראה לשחקנים איזה שחקן מתחיל
            {
                case true: whoseTurn.BackColor = Color.FromArgb(color1);
                    whoseTurn.Text = "1";
                    break;
                case false: whoseTurn.BackColor = Color.FromArgb(color2);
                    whoseTurn.Text = "2";
                    break;
            }
            watch.Start();
        }



        private void ShowsFrame()
        {
            // ref סי שרפ דורש לאפס את המשתנים לפני שעושים להם  
            GetLnginfo(ref lngRows, ref lngCols, ref this.btnWidth);
            btnHight = this.btnWidth;
            frameButtonsMaker(lngRows, lngCols, this.btnWidth, btnHight);
        }
        private void AddRollingButtons()
        {

            int dice1X = this.btnWidth + 20, dice1Y = this.btnHight + 20;           // מוסיף פקד היודע להכיל תמונה

            dice1 = new System.Windows.Forms.PictureBox();
            dice1.Location = new System.Drawing.Point(dice1X, dice1Y);
            dice1.Name = "dice1";
            dice1.Size = new System.Drawing.Size(114, 87);
            dice1.TabIndex = 12;
            dice1.TabStop = false;
            this.Controls.Add(dice1);

            // מוסיף פקד היודע להכיל תמונה
            int dice2X = this.btnWidth + 20, dice2Y = this.btnHight + dice1.Size.Height + 20;

            dice2 = new System.Windows.Forms.PictureBox();
            dice2.Location = new System.Drawing.Point(dice2X, dice2Y);
            dice2.Name = "dice2";
            dice2.Size = new System.Drawing.Size(114, 87);
            dice2.TabIndex = 12;
            dice2.TabStop = false;
            this.Controls.Add(dice2);
            // מוסיף לחצן שיזרוק קוביות
            int buttonX = btnWidth + btnWidth + 20 + 20, buttonY = btnHight + 20;
            RollingButton = new System.Windows.Forms.Button();
            RollingButton.Location = new System.Drawing.Point(buttonX, buttonY);
            RollingButton.Name = "RollingButton";
            RollingButton.Size = new System.Drawing.Size(114, 42);
            RollingButton.Text = "זרוק קוביות";
            RollingButton.UseVisualStyleBackColor = true;
            RollingButton.Click += new EventHandler(RollingButtons_Click);
            this.Controls.Add(RollingButton);

            movePlayer.Location = new System.Drawing.Point(buttonX, buttonY + 50);  // שם את הלחצן שמזיז את השחקנים לפי הקוביות מתחת ללחצן שזורק את הקוביות

            information.Location = new System.Drawing.Point(buttonX + RollingButton.Size.Width + 50, buttonY);

            whoseTurn.Location = new System.Drawing.Point(movePlayer.Location.X, movePlayer.Location.Y + 45);      // שם לחצן שמראה תור מי מתחת ללחצן שמזיז את השחקנים

            instructions.Location = new System.Drawing.Point(whoseTurn.Location.X, whoseTurn.Location.Y + 45);
        }

        private void RollingButtons_Click(object sender, EventArgs e)
        {
            RollingButton.Enabled = false;
            movePlayer.Enabled = true;
            Random rand = new Random();
            result1 = rand.Next(1, 7);
            result2 = rand.Next(1, 7);
            switch (result1)
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
            switch (result2)
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
            this.moves = result1 + result2;
        }



        private void GetLnginfo(ref int lngRows, ref int lngCols, ref int btnWidth)     // לקבל את מספר השורות, העמודות וגודל הריבועים
        {
            try
            {

                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  boardRows, boardCols, boardSquarePixels " +
                                          "FROM    tblBoards " +
                                          "WHERE   boardID = " + selectedBoard;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                lngRows = dataReader.GetInt32(0);
                lngCols = dataReader.GetInt32(1);
                btnWidth = dataReader.GetInt32(2);
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Get information failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frameButtonsMaker(int lngRows, int lngCols, int btnWidth, int btnHight)
        {
            if (btnHight < 120)
            {
                btnHight = 120;
                btnWidth = btnHight;
                MessageBox.Show("the minimum size is 120! " + "\n" + "therefore the size changed to 120");
            }
            arrControl = new BUserControl[lngRows, lngCols];   
            int i, j;
            SetBounds(0, 0, lngCols * (btnWidth + 5) + 15, lngRows * (btnHight + 5) + 40);
            for (i = 0; i < lngRows; i++)
                for (j = 0; j < lngCols; j++)
                    AddButton(i, j, btnWidth, btnHight, lngRows, lngCols);
        }

        private void AddButton(int i, int j, int btnWidth, int btnHight, int lngRows, int lngCols)
        {
            if ((i == 0 || i == lngRows - 1) || ((j == 0) && (i != 0) && (i != lngRows - 1)) || ((j == lngCols - 1) && (i != 0) && (i != lngRows - 1))) // מציג רק את המסגרת 
            {
                int X = j * (btnWidth + 5);
                int Y = i * (btnHight + 5);

                string oibObjectType, oibText1 = "", oibText2 = "", oibText3 = "", oibPicture = "";
                try
                {

                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "SELECT  oibObjectType, oibText1, oibText2, oibText3, oibPicture " +
                                              "FROM    tblObjectsInBoard " +
                                              "WHERE   oibBoardID = " + selectedBoard + " and " + "oibRow = " + i + " and " + "oibCol = " + j;
                    OleDbDataReader dataReader = datacommand.ExecuteReader();
                    dataReader.Read();
                    oibObjectType = dataReader.GetString(0);
                    oibText1 = dataReader.GetString(1);
                    oibText2 = dataReader.GetString(2);
                    oibText3 = dataReader.GetString(3);
                    oibPicture = dataReader.GetString(4);
                    dataReader.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Get information failed \n" + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                arrControl[i, j] = new BUserControl();
                arrControl[i, j].Location = new System.Drawing.Point(X, Y);
                arrControl[i, j].Name = "userControl_" + i.ToString() + "_" + j.ToString();
                arrControl[i, j].GetBt().Name = i.ToString() + "_" + j.ToString();
                arrControl[i, j].Size = new System.Drawing.Size(btnWidth, btnHight);
                arrControl[i, j].TabIndex = i + j;
                arrControl[i, j].GetBt().Click += new EventHandler(Buy_Click);
                arrControl[i, j].GetBt().Text = "buy";
                arrControl[i, j].BackColor = System.Drawing.Color.Blue;
                arrControl[i, j].Visible = true;
                if (oibPicture != "")   // אם יש תמונה 
                {
                    arrControl[i, j].GetPicture().SizeMode = PictureBoxSizeMode.StretchImage;
                    arrControl[i, j].GetPicture().ImageLocation = oibPicture;
                }

                arrControl[i, j].GetRtx1().Text = oibText1;
                arrControl[i, j].GetRtx2().Text = oibText2;
                arrControl[i, j].GetRtx3().Text = oibText3;

                                                                                // שם את השמות של השחקנים
                arrControl[i, j].GetPlayer1Button().Text = firstName1;
                arrControl[i, j].GetPlayer2Button().Text = firstName2;



                this.Controls.Add(arrControl[i, j]);
            }

        }

        private int GetGameID()
        {
            int gameID = 0;

            OleDbCommand datacommand = new OleDbCommand();
            datacommand.Connection = dataConnection;
            datacommand.CommandText = "SELECT MAX(gameID) " +
                                      "FROM tblGames";
            datacommand.ExecuteNonQuery();
            OleDbDataReader dataReader = datacommand.ExecuteReader();

            while (dataReader.Read())
            {
                gameID = int.Parse(dataReader.GetValue(0).ToString());
            }
            dataReader.Close();

            return gameID;
        }

        public void SaveStepUser1()                     // שומר את התור של השחקן הראשון
        {
            int gameID = GetGameID();       // מחזיר את מספר המשחק שעכשיו משוחק

            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblSteps " +
                                     "(stepGameID, stepOrderNum ,stepPlayerNum, stepdice1, stepDice2, stepAction, stepCash1, stepCash2, stepProperty1, stepProperty2) " +
                                     " VALUES ({0}, {1}, {2}, {3}, {4}, \"{5}\", {6}, {7}, {8}, {9})",
                                       gameID, steps, 1, result1, result2, action1, cash1.Text, cash2.Text, property1.Text, property2.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblSteps failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveStepUser2()                     // שומר את התור של השחקן השני 
        {
            int gameID = GetGameID();       // מחזיר את מספר המשחק שעכשיו משוחק

            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblSteps " +
                                     "(stepGameID, stepOrderNum ,stepPlayerNum, stepdice1, stepDice2, stepAction, stepCash1, stepCash2, stepProperty1, stepProperty2) " +
                                     " VALUES ({0}, {1}, {2}, {3}, {4}, \"{5}\", {6}, {7}, {8}, {9})",
                                       gameID, steps, 2, result1, result2, action2, cash1.Text, cash2.Text, property1.Text, property2.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblSteps failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Buy_Click(object sender, EventArgs e)    // קונה מקום
        {
            Button bt = (Button)sender;
            int i, j;
            int price;

            if (player1Turn)
            {
                if (arrControl[player1Y, player1X].GetBt().BackColor == Color.FromArgb(color1))  // מטפל במקרה שהמשתמש כבר קנה מקום זה
                {
                    MessageBox.Show("you already bought this place ", "information",       // אומר למשתמש שהוא כבר קנה את המקום הזה
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    player1Turn = false;                                        // מעביר את התור לשחקן השני
                    whoseTurn.BackColor = Color.FromArgb(color2);
                    whoseTurn.Text = "2";

                    action1 = "Nothing";
                }

                else if (arrControl[player1Y, player1X].GetBt().BackColor == Color.FromArgb(color2))   // מטפל במקרה שהמשתמש נמצא במקום שנקנה על ידי השחקן השני
                {
                    double charge, percent = 0.2;
                    charge = double.Parse(arrControl[player1Y, player1X].GetRtx3().Text) * percent;     // מוריד לשחקן שנמצא על המקום שלא שלו 20 אחוז ממחיר המקום שהוא נמצא עליו
                    //מוריד מהמזומן
                    double money = double.Parse(cash1.Text) - charge;
                    cash1.Text = money.ToString();

                    money = double.Parse(property1.Text);                  // מוריד מהרכוש
                    money -= charge;
                    property1.Text = money.ToString();
                    // מוסיף מזומן לשחקן השני
                    double money2 = double.Parse(cash2.Text) + charge;
                    cash2.Text = money2.ToString();
                    //מוסיף לרכוש של השחקן השני 
                    money2 = double.Parse(property2.Text);
                    money2 += charge;
                    property2.Text = money2.ToString();

                    MessageBox.Show("This place has already been purchased" + "\n" +          // אומר למשתמש שהוא צריך לשלם 20 אחוז ששלקים ממחיר המקום שהוא נמצא עליו
                    "Therefore you will be charged in 20% of the price of the place you stand on." + "\n \n" +
                    "you're charged at: " + charge, "information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    player1Turn = false;                                        // מעביר את התור לשחקן השני
                    whoseTurn.BackColor = Color.FromArgb(color2);
                    whoseTurn.Text = "2";

                    action1 = "inPlaceThatIs'ntBelongHim";
                }
                else
                {
                    i = player1Y;
                    j = player1X;

                    if (arrControl[player1Y, player1X].GetRtx1().Text == "הפתעה")        //מטפל במקרה שאתה נמצא על הפתעה
                    {
                        int bonus;
                        Random rand = new Random();
                        bonus = rand.Next(1, 201);                  // מוסיף למזומן
                        int money = int.Parse(cash1.Text) + bonus;
                        cash1.Text = money.ToString();

                        money = int.Parse(property1.Text);                  //מוסיף לרכוש
                        money += bonus;
                        property1.Text = money.ToString();

                        MessageBox.Show("you got bonus of " + bonus.ToString(), "information",    // כותב למשתמש כמה בונוס הוא קיבל
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action1 = "surprise";
                    }
                    else if (arrControl[player1Y, player1X].GetRtx1().Text == "דרך צלחה")        // מטפל במקרה שהמשתמש הגיע להתחלה - דרך צלחה
                    {
                        int bonus = 400;                                            // מוסיף למזומן
                        int money = int.Parse(cash1.Text) + bonus;
                        cash1.Text = money.ToString();

                        money = int.Parse(property1.Text);                  //מוסיף לרכוש
                        money += bonus;
                        property1.Text = money.ToString();

                        MessageBox.Show("you got bonus of " + bonus.ToString(), "information",    // כותב למשתמש כמה בונוס הוא קיבל
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action1 = "godspeed";
                    }
                    else if (arrControl[player1Y, player1X].GetRtx1().Text == "פקודה")               // מטפל במקרה שהמשתמש נמצא על פקודה
                    {
                        int charge;
                        Random rand = new Random();
                        charge = rand.Next(-200, 0);                  //מוריד מהמזומן
                        int money = int.Parse(cash1.Text) + charge;
                        cash1.Text = money.ToString();

                        money = int.Parse(property1.Text);                  // מוריד מהרכוש
                        money += charge;
                        property1.Text = money.ToString();

                        MessageBox.Show("you got charge of " + Math.Abs(charge), "information",    // כותב למשתמש כמה בונוס הוא קיבל
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action1 = "directive";
                    }
                    else if (arrControl[player1Y, player1X].GetRtx1().Text == "בית כלא")       // מטפל במקרה שאתה נמצא על בית כלא
                    {
                        arrControl[player1Y, player1X].GetBt().Enabled = false;
                        player1Turn = false;
                        RollingButton.Enabled = true;
                        MessageBox.Show("you will be stuck in the prison for 3 turns. \n" +
                                        "after 3 turns you will get out of the prison, \n" +
                                        "every turn you will throw the dice, \n" +
                                        "if one dice is equal to the other, \n" +
                                        "You'll get out of prison in the next turn.", "Jail",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action1 = "jail";
                    }

                    else if (arrControl[player1Y, player1X].GetRtx3().Text != "")                           // קניה רגילה
                    {
                        price = int.Parse(arrControl[i, j].GetRtx3().Text);
                        if (price > 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("if you want to buy choose yes, if not choose no ", "do you want to buy?", MessageBoxButtons.YesNo); // אם משהו לא רוצה לקנות
                            if (dialogResult == DialogResult.No)
                            {
                                arrControl[player1Y, player1X].GetBt().Enabled = false;
                                player1Turn = false;
                                whoseTurn.BackColor = Color.FromArgb(color2);
                                whoseTurn.Text = "2";
                                RollingButton.Enabled = true;

                                action1 = "Nothing";
                            }
                            else
                            {
                                if(int.Parse(cash1.Text) < price)                   // במקרה שאין לשחקן מספיק כסף לקנות את המקום
                                {
                                    MessageBox.Show("you dont have enough money to buy this place ", "information",      
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    action1 = "Nothing";
                                }
                                else
                                {
                                    int cash = int.Parse(cash1.Text);       // מעדכן את information
                                    cash -= Math.Abs(price);
                                    cash1.Text = cash.ToString();
                                    if (price < 0)                            // משנה את הרכוש במקרה הצורך
                                    {
                                        int money = int.Parse(property1.Text);
                                        money -= Math.Abs(price);
                                        property1.Text = money.ToString();
                                    }
                                    action1 = "buying";
                                    arrControl[i, j].GetBt().BackColor = Color.FromArgb(color1);  // משנה את צבע הלחצן לצבע של השחקן שקנה את המקום
                                }

                                
                            }
                        }
                        else                                                                    // במקרה של קנס 
                        {
                            int cash = int.Parse(cash1.Text);       // מעדכן את information
                            cash -= Math.Abs(price);
                            cash1.Text = cash.ToString();
                            if (price < 0)                            // משנה את הרכוש במקרה הצורך
                            {
                                int money = int.Parse(property1.Text);
                                money -= Math.Abs(price);
                                property1.Text = money.ToString();
                            }
                            this.action1 = "fine";
                        }



                    }
                    player1Turn = false;
                    whoseTurn.BackColor = Color.FromArgb(color2);
                    whoseTurn.Text = "2";
                    arrControl[player1Y, player1X].GetBt().Enabled = false;
                }
                steps++;
                SaveStepUser1();
            }

            else
            {
                if (arrControl[player2Y, player2X].GetBt().BackColor == Color.FromArgb(color2))  // מטפל במקרה שהמשתמש כבר קנה מקום זה
                {
                    MessageBox.Show("you already bought this place ", "information",       // אומר למשתמש שהוא כבר קנה את המקום הזה
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    player1Turn = true;                                        // מעביר את התור לשחקן השני
                    whoseTurn.BackColor = Color.FromArgb(color1);
                    whoseTurn.Text = "1";

                    action2 = "Nothing";
                }

                else if (arrControl[player2Y, player2X].GetBt().BackColor == Color.FromArgb(color1))   // מטפל במקרה שהמשתמש נמצא במקום שנקנה על ידי השחקן השני
                {
                    double charge, percent = 0.2;
                    charge = double.Parse(arrControl[player2Y, player2X].GetRtx3().Text) * percent;    // מוריד לשחקן שנמצא על המקום שלא שלו 20 אחוז ממחיר המקום שהוא נמצא עליו
                    //מוריד מהמזומן
                    double money = double.Parse(cash2.Text) - charge;
                    cash2.Text = money.ToString();

                    money = double.Parse(property2.Text);                  // מוריד מהרכוש
                    money -= charge;
                    property2.Text = money.ToString();

                    // מוסיף מזומן לשחקן השני
                    double money2 = double.Parse(cash1.Text) + charge;
                    cash1.Text = money2.ToString();
                    //מוסיף לרכוש של השחקן השני 
                    money2 = double.Parse(property1.Text);
                    money2 += charge;
                    property1.Text = money2.ToString();

                    MessageBox.Show("This is a place has already been purchased" + "\n" +          // אומר למשתמש שהוא צריך לשלם 20 אחוז ששלקים ממחיר המקום שהוא נמצא עליו
                    "therefore you will be charged in 20% of the price of the place you stand on." + "\n \n" +
                    "you're charged at: " + charge, "information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    player1Turn = true;                                        // מעביר את התור לשחקן השני
                    whoseTurn.BackColor = Color.FromArgb(color1);
                    whoseTurn.Text = "1";

                    action2 = "inPlaceThatIs'ntBelongHim";
                }
                else
                {

                    i = player2Y;
                    j = player2X;

                    if (arrControl[player2Y, player2X].GetRtx1().Text == "הפתעה")        //מטפל במקרה שאתה נמצא על הפתעה
                    {
                        int bonus;
                        Random rand = new Random();
                        bonus = rand.Next(1, 201);                  // מוסיף למזומן
                        int money = int.Parse(cash2.Text) + bonus;
                        cash2.Text = money.ToString();

                        money = int.Parse(property2.Text);                  //מוסיף לרכוש
                        money += bonus;
                        property2.Text = money.ToString();
                        MessageBox.Show("you got bonus of " + bonus.ToString(), "information",          // כותב למשתמש כמה בונוס הוא קיבל
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action2 = "surprise";
                    }
                    else if (arrControl[player2Y, player2X].GetRtx1().Text == "דרך צלחה")        // מטפל במקרה שהמשתמש הגיע להתחלה - דרך צלחה
                    {
                        int bonus = 400;                                            // מוסיף למזומן
                        int money = int.Parse(cash2.Text) + bonus;
                        cash1.Text = money.ToString();

                        money = int.Parse(property2.Text);                  //מוסיף לרכוש
                        money += bonus;
                        property1.Text = money.ToString();

                        MessageBox.Show("you got bonus of " + bonus.ToString(), "information",    // כותב למשתמש כמה בונוס הוא קיבל
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action2 = "godspeed";
                    }
                    else if (arrControl[player2Y, player2X].GetRtx1().Text == "פקודה")      // מטפל במקרה שהמשתמש נמצא על פקודה
                    {
                        int charge;
                        Random rand = new Random();
                        charge = rand.Next(-200, 0);                  //מוריד מהמזומן
                        int money = int.Parse(cash2.Text) + charge;
                        cash2.Text = money.ToString();

                        money = int.Parse(property2.Text);                  // מוריד מהרכוש
                        money += charge;
                        property2.Text = money.ToString();

                        MessageBox.Show("you got charge of " + Math.Abs(charge), "information",    // כותב למשתמש כמה קנס הוא קיבל
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action2 = "directive";
                    }
                    else if (arrControl[player2Y, player2X].GetRtx1().Text == "בית כלא")           // מטפל במקרה שאתה נמצא על בית כלא
                    {
                        arrControl[player2Y, player2X].GetBt().Enabled = false;
                        player1Turn = true;
                        RollingButton.Enabled = true;
                        MessageBox.Show("you will be stuck in the prison for 3 turns. \n" +
                                       "after 3 turns you will get out of the prison, \n" +
                                       "every turn you will throw the dice, \n" +
                                       "if one dice is equal to the other, \n" +
                                       "You'll get out of prison in the next turn.", "Jail",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                        action2 = "jail";
                    }



                    if (arrControl[player2Y, player2X].GetRtx3().Text != "")                       // קניה רגילה
                    {
                        price = int.Parse(arrControl[i, j].GetRtx3().Text);
                        if (price > 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("if you want to buy choose yes, if not choose no ", "do you want to buy?", MessageBoxButtons.YesNo); // אם משהו לא רוצה לקנות
                            if (dialogResult == DialogResult.No)
                            {
                                arrControl[player2Y, player2X].GetBt().Enabled = false;
                                player1Turn = true;
                                whoseTurn.BackColor = Color.FromArgb(color1);
                                whoseTurn.Text = "1";
                                RollingButton.Enabled = true;

                                action2 = "Nothing";
                            }
                            else
                            {
                                if(int.Parse(cash2.Text) < price)           // מטפל במקרה שאין לשחקן מספיק כסף לשלם על המקום
                                {
                                    MessageBox.Show("you dont have enough money to buy this place ", "information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    action2 = "Nothing";
                                }
                                else
                                {
                                    int cash = int.Parse(cash2.Text);               // מעדכן את information
                                    cash -= price;
                                    cash2.Text = cash.ToString();
                                    if (price < 0)                   // משנה את הרכוש במקרה הצורך
                                    {
                                        int money = int.Parse(property2.Text);
                                        money -= price;
                                        property2.Text = money.ToString();
                                    }

                                    action2 = "buying";
                                    arrControl[i, j].GetBt().BackColor = Color.FromArgb(color2);      // משנה את צבע הלחצן לצבע של השחקן שקנה את המקום
                                }  
                            }
                        }
                        else                                        // במקרה של קנס
                        {
                            int cash = int.Parse(cash2.Text);               // מעדכן את information
                            cash -= Math.Abs(price);
                            cash2.Text = cash.ToString();
                            if (price < 0)                   // משנה את הרכוש במקרה הצורך
                            {
                                int money = int.Parse(property2.Text);
                                money -= Math.Abs(price);
                                property2.Text = money.ToString();
                            }
                            this.action2 = "fine";
                        }


                    }
                    player1Turn = true;
                    whoseTurn.BackColor = Color.FromArgb(color1);
                    whoseTurn.Text = "1";
                    arrControl[player2Y, player2X].GetBt().Enabled = false;

                    steps++;
                    SaveStepUser2();
                }
            }
            if(!finishedGame)
            {
                RollingButton.Enabled = true;
            }   
        }

        private void movePlayer_Click(object sender, EventArgs e)  // מזיז את השחקנים 
        {

            movePlayer.Enabled = false;
            if (player1Turn)
            {
                if (arrControl[player1Y, player1X].GetRtx1().Text != "בית כלא")
                {
                    arrControl[player1Y, player1X].GetPlayer1Button().BackColor = System.Drawing.Color.Transparent;
                    movePlayer_A(ref player1X, ref player1Y);
                    arrControl[player1Y, player1X].GetPlayer1Button().BackColor = Color.FromArgb(color1);
                    arrControl[player1Y, player1X].GetBt().Enabled = true;
                }
                else
                {
                    action1 = "jail";
                    steps++;
                    SaveStepUser1();

                    if (this.dice1.ImageLocation == this.dice2.ImageLocation && !hadDouble1)
                        {
                            prison1 = 0;
                            inPrison1 = true;
                            hadDouble1 = true;
                            player1Turn = false;
                            RollingButton.Enabled = true;
                            whoseTurn.BackColor = Color.FromArgb(color2);
                            whoseTurn.Text = "2";
                            MessageBox.Show("After " + (prison1 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    
                    else
                        if (prison1 == 0 && !inPrison1)
                        {
                            prison1 = 2;
                            inPrison1 = true;
                            player1Turn = false;
                            RollingButton.Enabled = true;
                            whoseTurn.BackColor = Color.FromArgb(color2);
                            whoseTurn.Text = "2";
                            MessageBox.Show("After " + (prison1 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       
                        else
                            if (prison1 == 0 && inPrison1)
                            {
                                hadDouble1 = false;
                                inPrison1 = false;

                                arrControl[player1Y, player1X].GetBt().Enabled = false;
                                arrControl[player1Y, player1X].GetPlayer1Button().BackColor = System.Drawing.Color.Transparent;
                                movePlayer_A(ref player1X, ref player1Y);
                                arrControl[player1Y, player1X].GetPlayer1Button().BackColor = Color.FromArgb(color1);
                                arrControl[player1Y, player1X].GetBt().Enabled = true;
                            }
                            else if (prison1 == 2 || prison1 == 1)
                            {
                                prison1--;
                                player1Turn = false;
                                RollingButton.Enabled = true;
                                whoseTurn.BackColor = Color.FromArgb(color2);
                                whoseTurn.Text = "2";
                                MessageBox.Show("After " + (prison1 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (prison1 == 2)
                            {
                                prison1--;
                                player1Turn = false;
                                RollingButton.Enabled = true;
                                whoseTurn.BackColor = Color.FromArgb(color2);
                                whoseTurn.Text = "2";
                                MessageBox.Show("After " + (prison1 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                }

            }

            else
            {

                if (arrControl[player2Y, player2X].GetRtx1().Text != "בית כלא")
                {
                    arrControl[player2Y, player2X].GetPlayer2Button().BackColor = System.Drawing.Color.Transparent;
                    movePlayer_A(ref player2X, ref player2Y);
                    arrControl[player2Y, player2X].GetPlayer2Button().BackColor = Color.FromArgb(color2);
                    arrControl[player2Y, player2X].GetBt().Enabled = true;
                }
                else
                {
                    action2 = "jail";
                    steps++;
                    SaveStepUser2();

                     if (this.dice1.ImageLocation == this.dice2.ImageLocation && !hadDouble2)
                        {
                            prison2 = 0;
                            inPrison2 = true;
                            hadDouble2 = true;
                            player1Turn = true;
                            RollingButton.Enabled = true;
                            whoseTurn.BackColor = Color.FromArgb(color1);
                            whoseTurn.Text = "1";
                            MessageBox.Show("After " + (prison2 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    
                    else
                         if (prison2 == 0 && !inPrison2)
                         {
                             prison2 = 2;
                             inPrison2 = true;
                             player1Turn = true;
                             RollingButton.Enabled = true;
                             whoseTurn.BackColor = Color.FromArgb(color1);
                             whoseTurn.Text = "1";
                             MessageBox.Show("After " + (prison2 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }

                        else if (prison2 == 0 && inPrison2)
                        {
                            hadDouble2 = false;
                            inPrison2 = false;

                            arrControl[player2Y, player2X].GetBt().Enabled = false;
                            arrControl[player2Y, player2X].GetPlayer2Button().BackColor = System.Drawing.Color.Transparent;
                            movePlayer_A(ref player2X, ref player2Y);
                            arrControl[player2Y, player2X].GetPlayer2Button().BackColor = Color.FromArgb(color2);
                            arrControl[player2Y, player2X].GetBt().Enabled = true;
                        }
                        else if (prison2 == 2 || prison2 == 1)
                        {
                            prison2--;
                            player1Turn = true;
                            RollingButton.Enabled = true;
                            whoseTurn.BackColor = Color.FromArgb(color1);
                            whoseTurn.Text = "1";
                            MessageBox.Show("After " + (prison2 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (prison2 == 2)
                        {
                            prison2--;
                            player1Turn = true;
                            RollingButton.Enabled = true;
                            whoseTurn.BackColor = Color.FromArgb(color1);
                            whoseTurn.Text = "1";
                            MessageBox.Show("After " + (prison2 + 1).ToString() + " turns you will leave the prison", "information",    // כותב למשתמש עוד כמה תורות נשאר לו בכלא
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }



                }
            }
        }

        private void movePlayer_A(ref int x, ref int y)  // מזיז את השחקנים בפועל
        {
            for (int i = 1; i <= moves; i++)
            {
                if (y == 0 && x != this.lngCols - 1)
                    x += 1;
                else
                {
                    if (x == lngCols - 1 && y != lngRows - 1)
                        y += 1;
                    else if (y == lngRows - 1 && x != 0)
                        x -= 1;
                    else if (x == 0 && y != 0)
                        y -= 1;
                }
            }
        }

        private void FormPlayMonopol_FormClosing(object sender, FormClosingEventArgs e)   // במקרה שהשחקן רוצה לצאת מהמשחק
        {
            if (MessageBox.Show("Do you want to close this application?", "Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else                       // אם השחקן יוצא מהמשחק, התוכנה שומרת את כל מה שצריך לשמור בטבלת המשחקים
            {
                if(!finishedGame)
                {
                    int gameID = GetGameID();
                    double timeOfGameMillisec = watch.ElapsedMilliseconds;
                    double timeOfgameMins = timeOfGameMillisec * 0.000016667;
                    try
                    {
                        OleDbCommand datacommand = new OleDbCommand();
                        datacommand.Connection = dataConnection;
                        datacommand.CommandText = "UPDATE tblGames  \n" +
                                                  "SET     gameMinutes     =  \"" + timeOfgameMins + "\" , \n" +
                                                          "gameMoves     =  \"" + steps + "\" , \n" +
                                                          "gameFinished       =  " + false + "  \n" +
                                                  "WHERE  gameID = " + gameID;
                        datacommand.ExecuteNonQuery();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Update tblGames failed \n" + err.Message, "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // אומר מי ניצח
                    if (int.Parse(property1.Text) > int.Parse(property2.Text))
                    {
                        MessageBox.Show("player 1 won ", "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (int.Parse(property1.Text) == int.Parse(property2.Text))
                        {
                            MessageBox.Show("tie", "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("player 2 won ", "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
        }

        private void instructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("הלוח מורכב מ-34 משבצות שמקיפות אותו. \n "
                            + "כל שחקן בתורו מטיל זוג קוביות ומתקדם לפי תוצאת הקובייה לכיוון קבוע. \n"
                            + "אם שחקן נוחת על משבצת המייצגת רחוב, קו רכבת, חברת המים או חברת החשמל ביכולתו לרכוש אותו, \n"
                            + "במקרה והשחקנים לא רוצים לקנות את הנכס ואף אחד לא מציע הצעה, אז אפשר לדלג על הנכס או לרכוש אותו. \n "
                            + "אם שחקן נוחת על שטח שכבר שייך לשחקן אחר עליו לשלם לו סכום מסוים (התלוי בערך השטח). \n"
                            + "בכל פעם שנוחתים על משבצת הפתיחה זוכים בסכום של 200 שח \n"
                            + "אם שחקן נוחת על משבצות מסוימות עליו לקחת קלף הפתעה או קלף פקודה, ולבצע את ההוראות שכתובות בו (לרוב לזכות או לשלם סכום כסף מסוים). \n"
                            + "אם דורכים על משבצת הכלא, נכנסים לכלא ולאחר 3 תורות יוצאים מהכלא \n"
                            + " אם בזמן ששחקן נמצא בכלא הוא הטיל דאבל, השחקן יצא מהכלא בתור הבא \n"
                            + "המנצח במשחק הוא השחקן בעל הרכוש הגדול ביותר. \n"
                            + " המשחק נגמר כאשר יוצאים מהמשחק או שהרכוש של אחד השחקנים הוא שלילי.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading
                                                                                                                     | MessageBoxOptions.RightAlign);


        }

        private void property1_TextChanged(object sender, EventArgs e) // בודק אם הרכוש קטן מאפס וצריך לסיים את המשחק
        {
            int property = int.Parse(property1.Text);

            if(property < 0)
            {
                int gameID = GetGameID();
                double timeOfGameMillisec = watch.ElapsedMilliseconds;
                double timeOfgameMins = timeOfGameMillisec * 0.000016667;
                finishedGame = true;
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "UPDATE tblGames  \n" +
                                              "SET     gameMinutes     =  \"" + timeOfgameMins + "\" , \n" +
                                                      "gameMoves     =  \"" + steps + "\" , \n" +
                                                      "gameFinished       =  " + finishedGame + "  \n" +
                                              "WHERE  gameID = " + gameID;
                    datacommand.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Update tblGames failed \n" + err.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // אומר מי ניצח
                if (int.Parse(property1.Text) > int.Parse(property2.Text))
                {
                    MessageBox.Show("player 1 won, the game finished ", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (int.Parse(property1.Text) == int.Parse(property2.Text))
                    {
                        MessageBox.Show("tie, the game finished", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("player 2 won, the game finished ", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                RollingButton.Enabled = false;
                
            }
        }

        private void property2_TextChanged(object sender, EventArgs e)  // בודק אם הרכוש קטן מאפס וצריך לסיים את המשחק
        {
            int property = int.Parse(property2.Text);

            if(property < 0)
            {
                int gameID = GetGameID();
                double timeOfGameMillisec = watch.ElapsedMilliseconds;
                double timeOfgameMins = timeOfGameMillisec * 0.000016667;
                finishedGame = true;
                try
                {
                    OleDbCommand datacommand = new OleDbCommand();
                    datacommand.Connection = dataConnection;
                    datacommand.CommandText = "UPDATE tblGames  \n" +
                                              "SET     gameMinutes     =  \"" + timeOfgameMins + "\" , \n" +
                                                      "gameMoves     =  \"" + steps + "\" , \n" +
                                                      "gameFinished       =  " + finishedGame + "  \n" +
                                              "WHERE  gameID = " + gameID;
                    datacommand.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Update tblGames failed \n" + err.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // אומר מי ניצח
                if (int.Parse(property1.Text) > int.Parse(property2.Text))
                {
                    MessageBox.Show("player 1 won, the game finished ", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (int.Parse(property1.Text) == int.Parse(property2.Text))
                    {
                        MessageBox.Show("tie", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("player 2 won, the game finished ", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                RollingButton.Enabled = false;
            }
        }

    }

}
