namespace Monopol
{
    partial class FormRptStepsByGame
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
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
            this.tblGamesTableAdapter = new Monopol.DataSetGamesTableAdapters.tblGamesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonColor = new System.Windows.Forms.Button();
            this.cleanRpt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(341, 464);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 96;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(276, 464);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 95;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(57, 464);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 94;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(123, 464);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 93;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 341);
            this.dataGridView1.TabIndex = 92;
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
            // tblGamesTableAdapter
            // 
            this.tblGamesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(447, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 126;
            this.label1.Text = "דוח מהלכי משחק";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Location = new System.Drawing.Point(565, 97);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(846, 341);
            this.listView1.TabIndex = 127;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "מספר משחק";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "מספר מהלך";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "מספר שחקן -1/2";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "קוביה 1";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "קוביה 2";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "פעולה";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "מזומן שחקן 1";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "מזומן שחקן 2";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "רכוש שחקן 1";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "רכוש שחקן 2";
            this.columnHeader11.Width = 100;
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonColor.Location = new System.Drawing.Point(1006, 456);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(116, 41);
            this.buttonColor.TabIndex = 128;
            this.buttonColor.Text = "בחר צבע";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // cleanRpt
            // 
            this.cleanRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cleanRpt.Location = new System.Drawing.Point(542, 456);
            this.cleanRpt.Margin = new System.Windows.Forms.Padding(2);
            this.cleanRpt.Name = "cleanRpt";
            this.cleanRpt.Size = new System.Drawing.Size(116, 41);
            this.cleanRpt.TabIndex = 129;
            this.cleanRpt.Text = "נקה דוח";
            this.cleanRpt.UseVisualStyleBackColor = true;
            this.cleanRpt.Click += new System.EventHandler(this.cleanRpt_Click);
            // 
            // FormRptStepsByGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 527);
            this.Controls.Add(this.cleanRpt);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRptStepsByGame";
            this.Text = "FormRptStepsByGame";
            this.Load += new System.EventHandler(this.FormRptStepsByGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button cleanRpt;
    }
}