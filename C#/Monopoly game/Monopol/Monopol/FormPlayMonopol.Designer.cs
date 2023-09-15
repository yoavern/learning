namespace Monopol
{
    partial class FormPlayMonopol
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
            this.movePlayer = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.GroupBox();
            this.property2 = new System.Windows.Forms.TextBox();
            this.cash2 = new System.Windows.Forms.TextBox();
            this.property1 = new System.Windows.Forms.TextBox();
            this.cash1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.whoseTurn = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Button();
            this.information.SuspendLayout();
            this.SuspendLayout();
            // 
            // movePlayer
            // 
            this.movePlayer.Enabled = false;
            this.movePlayer.Location = new System.Drawing.Point(43, 73);
            this.movePlayer.Name = "movePlayer";
            this.movePlayer.Size = new System.Drawing.Size(115, 40);
            this.movePlayer.TabIndex = 0;
            this.movePlayer.Text = "זוז כמספר הקוביות";
            this.movePlayer.UseVisualStyleBackColor = true;
            this.movePlayer.Click += new System.EventHandler(this.movePlayer_Click);
            // 
            // information
            // 
            this.information.Controls.Add(this.property2);
            this.information.Controls.Add(this.cash2);
            this.information.Controls.Add(this.property1);
            this.information.Controls.Add(this.cash1);
            this.information.Controls.Add(this.label6);
            this.information.Controls.Add(this.label4);
            this.information.Controls.Add(this.label5);
            this.information.Controls.Add(this.label3);
            this.information.Controls.Add(this.label2);
            this.information.Controls.Add(this.label1);
            this.information.Location = new System.Drawing.Point(331, 73);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(248, 183);
            this.information.TabIndex = 1;
            this.information.TabStop = false;
            this.information.Text = "information";
            // 
            // property2
            // 
            this.property2.Location = new System.Drawing.Point(19, 144);
            this.property2.Name = "property2";
            this.property2.Size = new System.Drawing.Size(129, 20);
            this.property2.TabIndex = 1;
            this.property2.TextChanged += new System.EventHandler(this.property2_TextChanged);
            // 
            // cash2
            // 
            this.cash2.Location = new System.Drawing.Point(19, 116);
            this.cash2.Name = "cash2";
            this.cash2.Size = new System.Drawing.Size(129, 20);
            this.cash2.TabIndex = 1;
            // 
            // property1
            // 
            this.property1.Location = new System.Drawing.Point(19, 68);
            this.property1.Name = "property1";
            this.property1.Size = new System.Drawing.Size(129, 20);
            this.property1.TabIndex = 1;
            this.property1.TextChanged += new System.EventHandler(this.property1_TextChanged);
            // 
            // cash1
            // 
            this.cash1.Location = new System.Drawing.Point(19, 38);
            this.cash1.Name = "cash1";
            this.cash1.Size = new System.Drawing.Size(129, 20);
            this.cash1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 119);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "מזומן:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 147);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "רכוש:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 41);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "מזומן:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 71);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "רכוש:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 106);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "שחקן 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "שחקן 1:";
            // 
            // whoseTurn
            // 
            this.whoseTurn.Location = new System.Drawing.Point(43, 144);
            this.whoseTurn.Name = "whoseTurn";
            this.whoseTurn.Size = new System.Drawing.Size(115, 28);
            this.whoseTurn.TabIndex = 2;
            this.whoseTurn.Text = "מי משחק עכשיו";
            this.whoseTurn.UseVisualStyleBackColor = true;
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(43, 206);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(115, 26);
            this.instructions.TabIndex = 3;
            this.instructions.Text = "הוראות משחק";
            this.instructions.UseVisualStyleBackColor = true;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // FormPlayMonopol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(693, 411);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.whoseTurn);
            this.Controls.Add(this.information);
            this.Controls.Add(this.movePlayer);
            this.Name = "FormPlayMonopol";
            this.Text = "FormPlayMonopol";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayMonopol_FormClosing);
            this.information.ResumeLayout(false);
            this.information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button movePlayer;
        private System.Windows.Forms.GroupBox information;
        private System.Windows.Forms.TextBox property2;
        private System.Windows.Forms.TextBox cash2;
        private System.Windows.Forms.TextBox property1;
        private System.Windows.Forms.TextBox cash1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button whoseTurn;
        private System.Windows.Forms.Button instructions;
    }
}