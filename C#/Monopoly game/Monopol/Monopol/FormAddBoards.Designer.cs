namespace Monopol
{
    partial class FormAddBoards
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boardName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boardSubject = new System.Windows.Forms.TextBox();
            this.boardSquarePixels = new System.Windows.Forms.TextBox();
            this.boardRows = new System.Windows.Forms.TextBox();
            this.boardPicture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tblBoardsTableAdapter = new Monopol.DataSetBoardsTableAdapters.tblBoardsTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.boardCols = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.boardID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoards)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(246, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "הוספת לוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "שם לוח";
            // 
            // boardName
            // 
            this.boardName.Location = new System.Drawing.Point(282, 99);
            this.boardName.Name = "boardName";
            this.boardName.Size = new System.Drawing.Size(130, 20);
            this.boardName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "נושא";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "מספר שורות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "גודל ריבוע בפיקסלים";
            // 
            // boardSubject
            // 
            this.boardSubject.Location = new System.Drawing.Point(282, 136);
            this.boardSubject.Name = "boardSubject";
            this.boardSubject.Size = new System.Drawing.Size(130, 20);
            this.boardSubject.TabIndex = 30;
            // 
            // boardSquarePixels
            // 
            this.boardSquarePixels.Location = new System.Drawing.Point(12, 95);
            this.boardSquarePixels.Name = "boardSquarePixels";
            this.boardSquarePixels.Size = new System.Drawing.Size(130, 20);
            this.boardSquarePixels.TabIndex = 30;
            // 
            // boardRows
            // 
            this.boardRows.Location = new System.Drawing.Point(282, 169);
            this.boardRows.Name = "boardRows";
            this.boardRows.Size = new System.Drawing.Size(130, 20);
            this.boardRows.TabIndex = 30;
            // 
            // boardPicture
            // 
            this.boardPicture.Location = new System.Drawing.Point(12, 132);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(130, 20);
            this.boardPicture.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "תמונה";
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
            this.dataGridView1.Location = new System.Drawing.Point(35, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 170);
            this.dataGridView1.TabIndex = 31;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 48);
            this.button1.TabIndex = 32;
            this.button1.Text = "הוספה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblBoardsTableAdapter
            // 
            this.tblBoardsTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "מספר עמודות";
            // 
            // boardCols
            // 
            this.boardCols.Location = new System.Drawing.Point(12, 169);
            this.boardCols.Name = "boardCols";
            this.boardCols.Size = new System.Drawing.Size(130, 20);
            this.boardCols.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "מספר מזהה";
            // 
            // boardID
            // 
            this.boardID.Location = new System.Drawing.Point(478, 99);
            this.boardID.Name = "boardID";
            this.boardID.Size = new System.Drawing.Size(130, 20);
            this.boardID.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(504, 239);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "טבלת לוחות";
            // 
            // FormAddBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 466);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "FormAddBoards";
            this.Text = "FormAddBoards";
            this.Load += new System.EventHandler(this.FormAddBoards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boardName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boardSubject;
        private System.Windows.Forms.TextBox boardSquarePixels;
        private System.Windows.Forms.TextBox boardRows;
        private System.Windows.Forms.TextBox boardPicture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boardCols;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boardID;
        private System.Windows.Forms.Label label9;
    }
}