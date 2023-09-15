namespace Monopol
{
    partial class FormControlPlayMonopol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoard = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user1color = new System.Windows.Forms.Button();
            this.colorButton1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.ComboBox();
            this.user1LastName = new System.Windows.Forms.TextBox();
            this.user1FirstName = new System.Windows.Forms.TextBox();
            this.user1PictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.information = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.user2color = new System.Windows.Forms.Button();
            this.colorButton2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.ComboBox();
            this.user2LastName = new System.Windows.Forms.TextBox();
            this.user2FirstName = new System.Windows.Forms.TextBox();
            this.user2PictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRoll1 = new System.Windows.Forms.Button();
            this.buttonRoll2 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user1PictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(314, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "משחק מונופול";
            // 
            // comboBoard
            // 
            this.comboBoard.FormattingEnabled = true;
            this.comboBoard.Location = new System.Drawing.Point(472, 57);
            this.comboBoard.Name = "comboBoard";
            this.comboBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoard.Size = new System.Drawing.Size(121, 21);
            this.comboBoard.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 57);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "בחר מספר לוח";
            // 
            // startGame
            // 
            this.startGame.Enabled = false;
            this.startGame.Location = new System.Drawing.Point(297, 636);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(144, 50);
            this.startGame.TabIndex = 60;
            this.startGame.Text = "התחל משחק";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user1color);
            this.groupBox1.Controls.Add(this.colorButton1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.id1);
            this.groupBox1.Controls.Add(this.user1LastName);
            this.groupBox1.Controls.Add(this.user1FirstName);
            this.groupBox1.Controls.Add(this.user1PictureBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(472, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(201, 364);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "שחקן 1";
            // 
            // user1color
            // 
            this.user1color.BackColor = System.Drawing.Color.Transparent;
            this.user1color.Enabled = false;
            this.user1color.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.user1color.Location = new System.Drawing.Point(19, 305);
            this.user1color.Name = "user1color";
            this.user1color.Size = new System.Drawing.Size(43, 37);
            this.user1color.TabIndex = 113;
            this.user1color.UseVisualStyleBackColor = false;
            // 
            // colorButton1
            // 
            this.colorButton1.Location = new System.Drawing.Point(68, 305);
            this.colorButton1.Name = "colorButton1";
            this.colorButton1.Size = new System.Drawing.Size(53, 37);
            this.colorButton1.TabIndex = 112;
            this.colorButton1.Text = "בחר צבע";
            this.colorButton1.UseVisualStyleBackColor = true;
            this.colorButton1.Click += new System.EventHandler(this.colorButton1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "צבע שחקן 1";
            // 
            // id1
            // 
            this.id1.FormattingEnabled = true;
            this.id1.Location = new System.Drawing.Point(14, 31);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(93, 21);
            this.id1.TabIndex = 68;
            this.id1.SelectedIndexChanged += new System.EventHandler(this.id1_SelectedIndexChanged);
            // 
            // user1LastName
            // 
            this.user1LastName.Enabled = false;
            this.user1LastName.Location = new System.Drawing.Point(14, 84);
            this.user1LastName.Margin = new System.Windows.Forms.Padding(2);
            this.user1LastName.Name = "user1LastName";
            this.user1LastName.Size = new System.Drawing.Size(93, 20);
            this.user1LastName.TabIndex = 67;
            // 
            // user1FirstName
            // 
            this.user1FirstName.Enabled = false;
            this.user1FirstName.Location = new System.Drawing.Point(14, 56);
            this.user1FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.user1FirstName.Name = "user1FirstName";
            this.user1FirstName.Size = new System.Drawing.Size(93, 20);
            this.user1FirstName.TabIndex = 66;
            // 
            // user1PictureBox
            // 
            this.user1PictureBox.Location = new System.Drawing.Point(14, 126);
            this.user1PictureBox.Name = "user1PictureBox";
            this.user1PictureBox.Size = new System.Drawing.Size(161, 148);
            this.user1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user1PictureBox.TabIndex = 12;
            this.user1PictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "שם משפחה";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "ת.ז.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "שם פרטי";
            // 
            // information
            // 
            this.information.FormattingEnabled = true;
            this.information.Location = new System.Drawing.Point(134, 57);
            this.information.Name = "information";
            this.information.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.information.Size = new System.Drawing.Size(121, 21);
            this.information.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 60);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 106;
            this.label5.Text = "מידע:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.user2color);
            this.groupBox2.Controls.Add(this.colorButton2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.id2);
            this.groupBox2.Controls.Add(this.user2LastName);
            this.groupBox2.Controls.Add(this.user2FirstName);
            this.groupBox2.Controls.Add(this.user2PictureBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(70, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 364);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "שחקן 2";
            // 
            // user2color
            // 
            this.user2color.BackColor = System.Drawing.Color.Transparent;
            this.user2color.Enabled = false;
            this.user2color.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.user2color.Location = new System.Drawing.Point(13, 305);
            this.user2color.Name = "user2color";
            this.user2color.Size = new System.Drawing.Size(43, 37);
            this.user2color.TabIndex = 116;
            this.user2color.UseVisualStyleBackColor = false;
            // 
            // colorButton2
            // 
            this.colorButton2.Location = new System.Drawing.Point(62, 305);
            this.colorButton2.Name = "colorButton2";
            this.colorButton2.Size = new System.Drawing.Size(53, 37);
            this.colorButton2.TabIndex = 115;
            this.colorButton2.Text = "בחר צבע";
            this.colorButton2.UseVisualStyleBackColor = true;
            this.colorButton2.Click += new System.EventHandler(this.colorButton2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "צבע שחקן 2";
            // 
            // id2
            // 
            this.id2.Enabled = false;
            this.id2.FormattingEnabled = true;
            this.id2.Location = new System.Drawing.Point(24, 28);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(93, 21);
            this.id2.TabIndex = 68;
            this.id2.SelectedIndexChanged += new System.EventHandler(this.id2_SelectedIndexChanged);
            // 
            // user2LastName
            // 
            this.user2LastName.Enabled = false;
            this.user2LastName.Location = new System.Drawing.Point(24, 84);
            this.user2LastName.Margin = new System.Windows.Forms.Padding(2);
            this.user2LastName.Name = "user2LastName";
            this.user2LastName.Size = new System.Drawing.Size(93, 20);
            this.user2LastName.TabIndex = 72;
            // 
            // user2FirstName
            // 
            this.user2FirstName.Enabled = false;
            this.user2FirstName.Location = new System.Drawing.Point(24, 56);
            this.user2FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.user2FirstName.Name = "user2FirstName";
            this.user2FirstName.Size = new System.Drawing.Size(93, 20);
            this.user2FirstName.TabIndex = 71;
            // 
            // user2PictureBox
            // 
            this.user2PictureBox.Location = new System.Drawing.Point(24, 126);
            this.user2PictureBox.Name = "user2PictureBox";
            this.user2PictureBox.Size = new System.Drawing.Size(161, 148);
            this.user2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user2PictureBox.TabIndex = 70;
            this.user2PictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "שם משפחה";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ת.ז.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "שם פרטי";
            // 
            // buttonRoll1
            // 
            this.buttonRoll1.Location = new System.Drawing.Point(651, 483);
            this.buttonRoll1.Name = "buttonRoll1";
            this.buttonRoll1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonRoll1.Size = new System.Drawing.Size(114, 42);
            this.buttonRoll1.TabIndex = 108;
            this.buttonRoll1.Text = "הגרל קוביה 1";
            this.buttonRoll1.UseVisualStyleBackColor = true;
            this.buttonRoll1.Click += new System.EventHandler(this.buttonRoll1_Click);
            // 
            // buttonRoll2
            // 
            this.buttonRoll2.Enabled = false;
            this.buttonRoll2.Location = new System.Drawing.Point(261, 483);
            this.buttonRoll2.Name = "buttonRoll2";
            this.buttonRoll2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonRoll2.Size = new System.Drawing.Size(114, 42);
            this.buttonRoll2.TabIndex = 108;
            this.buttonRoll2.Text = "הגרל קוביה 2";
            this.buttonRoll2.UseVisualStyleBackColor = true;
            this.buttonRoll2.Click += new System.EventHandler(this.buttonRoll2_Click);
            // 
            // dice1
            // 
            this.dice1.Location = new System.Drawing.Point(486, 525);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(114, 87);
            this.dice1.TabIndex = 109;
            this.dice1.TabStop = false;
            // 
            // dice2
            // 
            this.dice2.Location = new System.Drawing.Point(94, 525);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(114, 87);
            this.dice2.TabIndex = 109;
            this.dice2.TabStop = false;
            // 
            // FormControlPlayMonopol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(777, 698);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.buttonRoll2);
            this.Controls.Add(this.buttonRoll1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.information);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoard);
            this.Controls.Add(this.label1);
            this.Name = "FormControlPlayMonopol";
            this.Text = "FormControlPlayMonopol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user1PictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox user1LastName;
        private System.Windows.Forms.TextBox user1FirstName;
        private System.Windows.Forms.PictureBox user1PictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox information;
        private System.Windows.Forms.ComboBox id1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox id2;
        private System.Windows.Forms.TextBox user2LastName;
        private System.Windows.Forms.TextBox user2FirstName;
        private System.Windows.Forms.PictureBox user2PictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button user1color;
        private System.Windows.Forms.Button colorButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button user2color;
        private System.Windows.Forms.Button colorButton2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRoll1;
        private System.Windows.Forms.Button buttonRoll2;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
    }
}