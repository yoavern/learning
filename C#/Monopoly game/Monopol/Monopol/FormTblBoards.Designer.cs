namespace Monopol
{
    partial class FormTblBoards
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoards)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(33, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // boardIDDataGridViewTextBoxColumn
            // 
            this.boardIDDataGridViewTextBoxColumn.DataPropertyName = "boardID";
            this.boardIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.boardIDDataGridViewTextBoxColumn.Name = "boardIDDataGridViewTextBoxColumn";
            // 
            // boardNameDataGridViewTextBoxColumn
            // 
            this.boardNameDataGridViewTextBoxColumn.DataPropertyName = "boardName";
            this.boardNameDataGridViewTextBoxColumn.HeaderText = "שם לוח";
            this.boardNameDataGridViewTextBoxColumn.Name = "boardNameDataGridViewTextBoxColumn";
            // 
            // boardSubgectDataGridViewTextBoxColumn
            // 
            this.boardSubgectDataGridViewTextBoxColumn.DataPropertyName = "boardSubgect";
            this.boardSubgectDataGridViewTextBoxColumn.HeaderText = "נושא לוח";
            this.boardSubgectDataGridViewTextBoxColumn.Name = "boardSubgectDataGridViewTextBoxColumn";
            // 
            // boardRowsDataGridViewTextBoxColumn
            // 
            this.boardRowsDataGridViewTextBoxColumn.DataPropertyName = "boardRows";
            this.boardRowsDataGridViewTextBoxColumn.HeaderText = "מספר שורות בלוח";
            this.boardRowsDataGridViewTextBoxColumn.Name = "boardRowsDataGridViewTextBoxColumn";
            // 
            // boardColsDataGridViewTextBoxColumn
            // 
            this.boardColsDataGridViewTextBoxColumn.DataPropertyName = "boardCols";
            this.boardColsDataGridViewTextBoxColumn.HeaderText = "מספר עמודות בלוח";
            this.boardColsDataGridViewTextBoxColumn.Name = "boardColsDataGridViewTextBoxColumn";
            // 
            // boardSquarePixelsDataGridViewTextBoxColumn
            // 
            this.boardSquarePixelsDataGridViewTextBoxColumn.DataPropertyName = "boardSquarePixels";
            this.boardSquarePixelsDataGridViewTextBoxColumn.HeaderText = "גודל ריבוע בפיקסלים";
            this.boardSquarePixelsDataGridViewTextBoxColumn.Name = "boardSquarePixelsDataGridViewTextBoxColumn";
            // 
            // boardPictureDataGridViewTextBoxColumn
            // 
            this.boardPictureDataGridViewTextBoxColumn.DataPropertyName = "boardPicture";
            this.boardPictureDataGridViewTextBoxColumn.HeaderText = "תמונה של לוח";
            this.boardPictureDataGridViewTextBoxColumn.Name = "boardPictureDataGridViewTextBoxColumn";
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(268, 254);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(460, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת לוחות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(495, 65);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "טבלת לוחות";
            // 
            // FormTblBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblBoards";
            this.Text = "FormBoards";
            this.Load += new System.EventHandler(this.FormBoards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBoardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBoards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}