namespace Monopol
{
    partial class FormUpdateGames
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
            this.components = new System.ComponentModel.Container();
            this.gameFinished = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBoardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePlayerID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameColor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameColor2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameMovesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblGamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGames = new Monopol.DataSetGames();
            this.button1 = new System.Windows.Forms.Button();
            this.gameColor2 = new System.Windows.Forms.TextBox();
            this.gameColor1 = new System.Windows.Forms.TextBox();
            this.gamePlayerID2 = new System.Windows.Forms.TextBox();
            this.gamePlayerID1 = new System.Windows.Forms.TextBox();
            this.gameBoardID = new System.Windows.Forms.TextBox();
            this.gameMoves = new System.Windows.Forms.TextBox();
            this.gameMinutes = new System.Windows.Forms.TextBox();
            this.gameTime = new System.Windows.Forms.TextBox();
            this.gameDate = new System.Windows.Forms.TextBox();
            this.gameID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.tblGamesTableAdapter = new Monopol.DataSetGamesTableAdapters.tblGamesTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).BeginInit();
            this.SuspendLayout();
            // 
            // gameFinished
            // 
            this.gameFinished.AutoSize = true;
            this.gameFinished.Location = new System.Drawing.Point(338, 206);
            this.gameFinished.Name = "gameFinished";
            this.gameFinished.Size = new System.Drawing.Size(104, 17);
            this.gameFinished.TabIndex = 58;
            this.gameFinished.Text = "המשחק הסתיים";
            this.gameFinished.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.gameBoardIDDataGridViewTextBoxColumn,
            this.gamePlayerID1DataGridViewTextBoxColumn,
            this.gamePlayerID2DataGridViewTextBoxColumn,
            this.gameColor1DataGridViewTextBoxColumn,
            this.gameColor2DataGridViewTextBoxColumn,
            this.gameDateDataGridViewTextBoxColumn,
            this.gameTimeDataGridViewTextBoxColumn,
            this.gameMinutesDataGridViewTextBoxColumn,
            this.gameMovesDataGridViewTextBoxColumn,
            this.gameFinishedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblGamesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(711, 189);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "gameID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            this.gameIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameBoardIDDataGridViewTextBoxColumn
            // 
            this.gameBoardIDDataGridViewTextBoxColumn.DataPropertyName = "gameBoardID";
            this.gameBoardIDDataGridViewTextBoxColumn.HeaderText = "מספר לוח";
            this.gameBoardIDDataGridViewTextBoxColumn.Name = "gameBoardIDDataGridViewTextBoxColumn";
            this.gameBoardIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gamePlayerID1DataGridViewTextBoxColumn
            // 
            this.gamePlayerID1DataGridViewTextBoxColumn.DataPropertyName = "gamePlayerID1";
            this.gamePlayerID1DataGridViewTextBoxColumn.HeaderText = "ת\"ז שחקן 1";
            this.gamePlayerID1DataGridViewTextBoxColumn.Name = "gamePlayerID1DataGridViewTextBoxColumn";
            this.gamePlayerID1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gamePlayerID2DataGridViewTextBoxColumn
            // 
            this.gamePlayerID2DataGridViewTextBoxColumn.DataPropertyName = "gamePlayerID2";
            this.gamePlayerID2DataGridViewTextBoxColumn.HeaderText = "ת\"ז שחקן 2";
            this.gamePlayerID2DataGridViewTextBoxColumn.Name = "gamePlayerID2DataGridViewTextBoxColumn";
            this.gamePlayerID2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameColor1DataGridViewTextBoxColumn
            // 
            this.gameColor1DataGridViewTextBoxColumn.DataPropertyName = "gameColor1";
            this.gameColor1DataGridViewTextBoxColumn.HeaderText = "צבע שחקן 1";
            this.gameColor1DataGridViewTextBoxColumn.Name = "gameColor1DataGridViewTextBoxColumn";
            this.gameColor1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameColor2DataGridViewTextBoxColumn
            // 
            this.gameColor2DataGridViewTextBoxColumn.DataPropertyName = "gameColor2";
            this.gameColor2DataGridViewTextBoxColumn.HeaderText = "צבע שחקן 2";
            this.gameColor2DataGridViewTextBoxColumn.Name = "gameColor2DataGridViewTextBoxColumn";
            this.gameColor2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameDateDataGridViewTextBoxColumn
            // 
            this.gameDateDataGridViewTextBoxColumn.DataPropertyName = "gameDate";
            this.gameDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.gameDateDataGridViewTextBoxColumn.Name = "gameDateDataGridViewTextBoxColumn";
            this.gameDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameTimeDataGridViewTextBoxColumn
            // 
            this.gameTimeDataGridViewTextBoxColumn.DataPropertyName = "gameTime";
            this.gameTimeDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.gameTimeDataGridViewTextBoxColumn.Name = "gameTimeDataGridViewTextBoxColumn";
            this.gameTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameMinutesDataGridViewTextBoxColumn
            // 
            this.gameMinutesDataGridViewTextBoxColumn.DataPropertyName = "gameMinutes";
            this.gameMinutesDataGridViewTextBoxColumn.HeaderText = "משך המשחק בדקות";
            this.gameMinutesDataGridViewTextBoxColumn.Name = "gameMinutesDataGridViewTextBoxColumn";
            this.gameMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameMovesDataGridViewTextBoxColumn
            // 
            this.gameMovesDataGridViewTextBoxColumn.DataPropertyName = "gameMoves";
            this.gameMovesDataGridViewTextBoxColumn.HeaderText = "מספר מהלכים";
            this.gameMovesDataGridViewTextBoxColumn.Name = "gameMovesDataGridViewTextBoxColumn";
            this.gameMovesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameFinishedDataGridViewCheckBoxColumn
            // 
            this.gameFinishedDataGridViewCheckBoxColumn.DataPropertyName = "gameFinished";
            this.gameFinishedDataGridViewCheckBoxColumn.HeaderText = "המשחק הסתיים";
            this.gameFinishedDataGridViewCheckBoxColumn.Name = "gameFinishedDataGridViewCheckBoxColumn";
            this.gameFinishedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // tblGamesBindingSource
            // 
            this.tblGamesBindingSource.DataMember = "tblGames";
            this.tblGamesBindingSource.DataSource = this.dataSetGames;
            // 
            // dataSetGames
            // 
            this.dataSetGames.DataSetName = "DataSetGames";
            this.dataSetGames.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 58);
            this.button1.TabIndex = 56;
            this.button1.Text = "עדכון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // gameColor2
            // 
            this.gameColor2.Location = new System.Drawing.Point(457, 230);
            this.gameColor2.Name = "gameColor2";
            this.gameColor2.Size = new System.Drawing.Size(177, 20);
            this.gameColor2.TabIndex = 54;
            // 
            // gameColor1
            // 
            this.gameColor1.Location = new System.Drawing.Point(457, 204);
            this.gameColor1.Name = "gameColor1";
            this.gameColor1.Size = new System.Drawing.Size(177, 20);
            this.gameColor1.TabIndex = 53;
            // 
            // gamePlayerID2
            // 
            this.gamePlayerID2.Location = new System.Drawing.Point(456, 170);
            this.gamePlayerID2.Name = "gamePlayerID2";
            this.gamePlayerID2.Size = new System.Drawing.Size(177, 20);
            this.gamePlayerID2.TabIndex = 52;
            // 
            // gamePlayerID1
            // 
            this.gamePlayerID1.Location = new System.Drawing.Point(457, 139);
            this.gamePlayerID1.Name = "gamePlayerID1";
            this.gamePlayerID1.Size = new System.Drawing.Size(177, 20);
            this.gamePlayerID1.TabIndex = 51;
            // 
            // gameBoardID
            // 
            this.gameBoardID.Location = new System.Drawing.Point(457, 109);
            this.gameBoardID.Name = "gameBoardID";
            this.gameBoardID.Size = new System.Drawing.Size(177, 20);
            this.gameBoardID.TabIndex = 50;
            // 
            // gameMoves
            // 
            this.gameMoves.Location = new System.Drawing.Point(153, 170);
            this.gameMoves.Name = "gameMoves";
            this.gameMoves.Size = new System.Drawing.Size(177, 20);
            this.gameMoves.TabIndex = 49;
            // 
            // gameMinutes
            // 
            this.gameMinutes.Location = new System.Drawing.Point(153, 135);
            this.gameMinutes.Name = "gameMinutes";
            this.gameMinutes.Size = new System.Drawing.Size(177, 20);
            this.gameMinutes.TabIndex = 48;
            // 
            // gameTime
            // 
            this.gameTime.Location = new System.Drawing.Point(153, 109);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(177, 20);
            this.gameTime.TabIndex = 55;
            // 
            // gameDate
            // 
            this.gameDate.Location = new System.Drawing.Point(153, 81);
            this.gameDate.Name = "gameDate";
            this.gameDate.Size = new System.Drawing.Size(177, 20);
            this.gameDate.TabIndex = 47;
            // 
            // gameID
            // 
            this.gameID.Location = new System.Drawing.Point(457, 81);
            this.gameID.Name = "gameID";
            this.gameID.ReadOnly = true;
            this.gameID.Size = new System.Drawing.Size(177, 20);
            this.gameID.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "מספר מזהה";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "מספר מהלכים";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "משך המשחק בדקות";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "שעה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "תאריך";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "צבע שחקן 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "צבע שחקן 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "ת\"ז שחקן 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "ת\"ז שחקן 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "מספר לוח";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(349, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "עדכון משחק";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(539, 277);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 91;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(474, 277);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 90;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(255, 277);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 89;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(321, 277);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 88;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // tblGamesTableAdapter
            // 
            this.tblGamesTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(701, 357);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 92;
            this.label12.Text = "טבלת משחקים";
            // 
            // FormUpdateGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 580);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.gameFinished);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gameColor2);
            this.Controls.Add(this.gameColor1);
            this.Controls.Add(this.gamePlayerID2);
            this.Controls.Add(this.gamePlayerID1);
            this.Controls.Add(this.gameBoardID);
            this.Controls.Add(this.gameMoves);
            this.Controls.Add(this.gameMinutes);
            this.Controls.Add(this.gameTime);
            this.Controls.Add(this.gameDate);
            this.Controls.Add(this.gameID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateGames";
            this.Text = "FormUpdateGames";
            this.Load += new System.EventHandler(this.FormUpdateGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox gameFinished;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox gameColor2;
        private System.Windows.Forms.TextBox gameColor1;
        private System.Windows.Forms.TextBox gamePlayerID2;
        private System.Windows.Forms.TextBox gamePlayerID1;
        private System.Windows.Forms.TextBox gameBoardID;
        private System.Windows.Forms.TextBox gameMoves;
        private System.Windows.Forms.TextBox gameMinutes;
        private System.Windows.Forms.TextBox gameTime;
        private System.Windows.Forms.TextBox gameDate;
        private System.Windows.Forms.TextBox gameID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private DataSetGames dataSetGames;
        private System.Windows.Forms.BindingSource tblGamesBindingSource;
        private DataSetGamesTableAdapters.tblGamesTableAdapter tblGamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameBoardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayerID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePlayerID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameColor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameColor2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameMovesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gameFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label12;
    }
}