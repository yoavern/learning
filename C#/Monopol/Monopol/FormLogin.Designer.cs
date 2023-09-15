namespace Monopol
{
    partial class FormLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginEnter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginContinue = new System.Windows.Forms.Button();
            this.loginMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "כניסה למערכת";
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(242, 237);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(98, 20);
            this.loginPassword.TabIndex = 13;
            this.loginPassword.UseSystemPasswordChar = true;
            // 
            // loginID
            // 
            this.loginID.Location = new System.Drawing.Point(242, 197);
            this.loginID.Margin = new System.Windows.Forms.Padding(2);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(98, 20);
            this.loginID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "סיסמה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ת\"ז";
            // 
            // loginEnter
            // 
            this.loginEnter.Location = new System.Drawing.Point(294, 320);
            this.loginEnter.Name = "loginEnter";
            this.loginEnter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginEnter.Size = new System.Drawing.Size(97, 42);
            this.loginEnter.TabIndex = 14;
            this.loginEnter.Text = "כניסה";
            this.loginEnter.UseVisualStyleBackColor = true;
            this.loginEnter.Click += new System.EventHandler(this.CheckButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(444, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // loginContinue
            // 
            this.loginContinue.Location = new System.Drawing.Point(137, 320);
            this.loginContinue.Name = "loginContinue";
            this.loginContinue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginContinue.Size = new System.Drawing.Size(97, 42);
            this.loginContinue.TabIndex = 14;
            this.loginContinue.Text = "המשך";
            this.loginContinue.UseVisualStyleBackColor = true;
            this.loginContinue.Visible = false;
            this.loginContinue.Click += new System.EventHandler(this.loginContinue_Click);
            // 
            // loginMessage
            // 
            this.loginMessage.AutoSize = true;
            this.loginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMessage.Location = new System.Drawing.Point(69, 237);
            this.loginMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginMessage.Name = "loginMessage";
            this.loginMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loginMessage.Size = new System.Drawing.Size(13, 20);
            this.loginMessage.TabIndex = 16;
            this.loginMessage.Text = ".";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 455);
            this.Controls.Add(this.loginMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginContinue);
            this.Controls.Add(this.loginEnter);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginEnter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginContinue;
        private System.Windows.Forms.Label loginMessage;
    }
}

