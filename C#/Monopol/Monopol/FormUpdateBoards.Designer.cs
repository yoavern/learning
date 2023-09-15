namespace Monopol
{
    partial class FormUpdateBoards
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
            this.button1 = new System.Windows.Forms.Button();
            this.boardRows = new System.Windows.Forms.TextBox();
            this.boardCols = new System.Windows.Forms.TextBox();
            this.boardPicture = new System.Windows.Forms.TextBox();
            this.boardSquarePixels = new System.Windows.Forms.TextBox();
            this.boardSubject = new System.Windows.Forms.TextBox();
            this.boardID = new System.Windows.Forms.TextBox();
            this.boardName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardSubgectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardRowsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardColsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardSquarePixelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boardPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBoardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBoards = new Monopol.DataSetBoards();
            this.tblBoardsTableAdapter = new Monopol.DataSetBoardsTableAdapters.tblBoardsTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoards)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 45);
            this.button1.TabIndex = 48;
            this.button1.Text = "עדכון";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // boardRows
            // 
            this.boardRows.Location = new System.Drawing.Point(357, 141);
            this.boardRows.Name = "boardRows";
            this.boardRows.Size = new System.Drawing.Size(130, 20);
            this.boardRows.TabIndex = 41;
            // 
            // boardCols
            // 
            this.boardCols.Location = new System.Drawing.Point(87, 141);
            this.boardCols.Name = "boardCols";
            this.boardCols.Size = new System.Drawing.Size(130, 20);
            this.boardCols.TabIndex = 42;
            // 
            // boardPicture
            // 
            this.boardPicture.Location = new System.Drawing.Point(87, 104);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(130, 20);
            this.boardPicture.TabIndex = 43;
            // 
            // boardSquarePixels
            // 
            this.boardSquarePixels.Location = new System.Drawing.Point(87, 67);
            this.boardSquarePixels.Name = "boardSquarePixels";
            this.boardSquarePixels.Size = new System.Drawing.Size(130, 20);
            this.boardSquarePixels.TabIndex = 44;
            // 
            // boardSubject
            // 
            this.boardSubject.Location = new System.Drawing.Point(357, 108);
            this.boardSubject.Name = "boardSubject";
            this.boardSubject.Size = new System.Drawing.Size(130, 20);
            this.boardSubject.TabIndex = 45;
            // 
            // boardID
            // 
            this.boardID.Location = new System.Drawing.Point(553, 71);
            this.boardID.Name = "boardID";
            this.boardID.ReadOnly = true;
            this.boardID.Size = new System.Drawing.Size(130, 20);
            this.boardID.TabIndex = 46;
            // 
            // boardName
            // 
            this.boardName.Location = new System.Drawing.Point(357, 71);
            this.boardName.Name = "boardName";
            this.boardName.Size = new System.Drawing.Size(130, 20);
            this.boardName.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "מספר עמודות";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "תמונה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "גודל ריבוע בפיקסלים";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "מספר שורות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "נושא";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "מספר מזהה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(493, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "שם לוח";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "עדכון לוח";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(491, 221);
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
            this.buttonLast.Location = new System.Drawing.Point(426, 221);
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
            this.buttonNext.Location = new System.Drawing.Point(216, 221);
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
            this.buttonPrev.Location = new System.Drawing.Point(282, 221);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 88;
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
            this.boardIDDataGridViewTextBoxColumn,
            this.boardNameDataGridViewTextBoxColumn,
            this.boardSubgectDataGridViewTextBoxColumn,
            this.boardRowsDataGridViewTextBoxColumn,
            this.boardColsDataGridViewTextBoxColumn,
            this.boardSquarePixelsDataGridViewTextBoxColumn,
            this.boardPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblBoardsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 170);
            this.dataGridView1.TabIndex = 92;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // boardIDDataGridViewTextBoxColumn
            // 
            this.boardIDDataGridViewTextBoxColumn.DataPropertyName = "boardID";
            this.boardIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.boardIDDataGridViewTextBoxColumn.Name = "boardIDDataGridViewTextBoxColumn";
            this.boardIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardNameDataGridViewTextBoxColumn
            // 
            this.boardNameDataGridViewTextBoxColumn.DataPropertyName = "boardName";
            this.boardNameDataGridViewTextBoxColumn.HeaderText = "שם לוח";
            this.boardNameDataGridViewTextBoxColumn.Name = "boardNameDataGridViewTextBoxColumn";
            this.boardNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardSubgectDataGridViewTextBoxColumn
            // 
            this.boardSubgectDataGridViewTextBoxColumn.DataPropertyName = "boardSubgect";
            this.boardSubgectDataGridViewTextBoxColumn.HeaderText = "נושא";
            this.boardSubgectDataGridViewTextBoxColumn.Name = "boardSubgectDataGridViewTextBoxColumn";
            this.boardSubgectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardRowsDataGridViewTextBoxColumn
            // 
            this.boardRowsDataGridViewTextBoxColumn.DataPropertyName = "boardRows";
            this.boardRowsDataGridViewTextBoxColumn.HeaderText = "מספר שורות";
            this.boardRowsDataGridViewTextBoxColumn.Name = "boardRowsDataGridViewTextBoxColumn";
            this.boardRowsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardColsDataGridViewTextBoxColumn
            // 
            this.boardColsDataGridViewTextBoxColumn.DataPropertyName = "boardCols";
            this.boardColsDataGridViewTextBoxColumn.HeaderText = "מספר עמודות";
            this.boardColsDataGridViewTextBoxColumn.Name = "boardColsDataGridViewTextBoxColumn";
            this.boardColsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardSquarePixelsDataGridViewTextBoxColumn
            // 
            this.boardSquarePixelsDataGridViewTextBoxColumn.DataPropertyName = "boardSquarePixels";
            this.boardSquarePixelsDataGridViewTextBoxColumn.HeaderText = "גודל ריבוע בפיקסלים";
            this.boardSquarePixelsDataGridViewTextBoxColumn.Name = "boardSquarePixelsDataGridViewTextBoxColumn";
            this.boardSquarePixelsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boardPictureDataGridViewTextBoxColumn
            // 
            this.boardPictureDataGridViewTextBoxColumn.DataPropertyName = "boardPicture";
            this.boardPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.boardPictureDataGridViewTextBoxColumn.Name = "boardPictureDataGridViewTextBoxColumn";
            this.boardPictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblBoardsBindingSource
            // 
            this.tblBoardsBindingSource.DataMember = "tblBoards";
            this.tblBoardsBindingSource.DataSource = this.dataSetBoards;
            // 
            // dataSetBoards
            // 
            this.dataSetBoards.DataSetName = "DataSetBoards";
            this.dataSetBoards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBoardsTableAdapter
            // 
            this.tblBoardsTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(594, 288);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 93;
            this.label9.Text = "טבלת לוחות";
            // 
            // FormUpdateBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boardRows);
            this.Controls.Add(this.boardCols);
            this.Controls.Add(this.boardPicture);
            this.Controls.Add(this.boardSquarePixels);
            this.Controls.Add(this.boardSubject);
            this.Controls.Add(this.boardID);
            this.Controls.Add(this.boardName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateBoards";
            this.Text = "FormUpdateBoards";
            this.Load += new System.EventHandler(this.FormUpdateBoards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boardRows;
        private System.Windows.Forms.TextBox boardCols;
        private System.Windows.Forms.TextBox boardPicture;
        private System.Windows.Forms.TextBox boardSquarePixels;
        private System.Windows.Forms.TextBox boardSubject;
        private System.Windows.Forms.TextBox boardID;
        private System.Windows.Forms.TextBox boardName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetBoards dataSetBoards;
        private System.Windows.Forms.BindingSource tblBoardsBindingSource;
        private DataSetBoardsTableAdapters.tblBoardsTableAdapter tblBoardsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardSubgectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardRowsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardColsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardSquarePixelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boardPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
    }
}