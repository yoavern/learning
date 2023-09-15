namespace Monopol
{
    partial class FormTblObjectsInBoard
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
            this.oibBoardIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibObjectTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibText1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibText2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibText3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblObjectsInBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetObjectsInBoard = new Monopol.DataSetObjectsInBoard();
            this.tblObjectsInBoardTableAdapter = new Monopol.DataSetObjectsInBoardTableAdapters.tblObjectsInBoardTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectsInBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectsInBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oibBoardIDDataGridViewTextBoxColumn,
            this.oibRowDataGridViewTextBoxColumn,
            this.oibColDataGridViewTextBoxColumn,
            this.oibObjectTypeDataGridViewTextBoxColumn,
            this.oibText1DataGridViewTextBoxColumn,
            this.oibText2DataGridViewTextBoxColumn,
            this.oibText3DataGridViewTextBoxColumn,
            this.oibPaymentDataGridViewTextBoxColumn,
            this.oibPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblObjectsInBoardBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // oibBoardIDDataGridViewTextBoxColumn
            // 
            this.oibBoardIDDataGridViewTextBoxColumn.DataPropertyName = "oibBoardID";
            this.oibBoardIDDataGridViewTextBoxColumn.HeaderText = "מספר לוח";
            this.oibBoardIDDataGridViewTextBoxColumn.Name = "oibBoardIDDataGridViewTextBoxColumn";
            // 
            // oibRowDataGridViewTextBoxColumn
            // 
            this.oibRowDataGridViewTextBoxColumn.DataPropertyName = "oibRow";
            this.oibRowDataGridViewTextBoxColumn.HeaderText = "שורה";
            this.oibRowDataGridViewTextBoxColumn.Name = "oibRowDataGridViewTextBoxColumn";
            // 
            // oibColDataGridViewTextBoxColumn
            // 
            this.oibColDataGridViewTextBoxColumn.DataPropertyName = "oibCol";
            this.oibColDataGridViewTextBoxColumn.HeaderText = "עמודה";
            this.oibColDataGridViewTextBoxColumn.Name = "oibColDataGridViewTextBoxColumn";
            // 
            // oibObjectTypeDataGridViewTextBoxColumn
            // 
            this.oibObjectTypeDataGridViewTextBoxColumn.DataPropertyName = "oibObjectType";
            this.oibObjectTypeDataGridViewTextBoxColumn.HeaderText = "סוג אובייקט";
            this.oibObjectTypeDataGridViewTextBoxColumn.Name = "oibObjectTypeDataGridViewTextBoxColumn";
            // 
            // oibText1DataGridViewTextBoxColumn
            // 
            this.oibText1DataGridViewTextBoxColumn.DataPropertyName = "oibText1";
            this.oibText1DataGridViewTextBoxColumn.HeaderText = "טקסט1";
            this.oibText1DataGridViewTextBoxColumn.Name = "oibText1DataGridViewTextBoxColumn";
            // 
            // oibText2DataGridViewTextBoxColumn
            // 
            this.oibText2DataGridViewTextBoxColumn.DataPropertyName = "oibText2";
            this.oibText2DataGridViewTextBoxColumn.HeaderText = "טקסט2";
            this.oibText2DataGridViewTextBoxColumn.Name = "oibText2DataGridViewTextBoxColumn";
            // 
            // oibText3DataGridViewTextBoxColumn
            // 
            this.oibText3DataGridViewTextBoxColumn.DataPropertyName = "oibText3";
            this.oibText3DataGridViewTextBoxColumn.HeaderText = "טקסט3";
            this.oibText3DataGridViewTextBoxColumn.Name = "oibText3DataGridViewTextBoxColumn";
            // 
            // oibPaymentDataGridViewTextBoxColumn
            // 
            this.oibPaymentDataGridViewTextBoxColumn.DataPropertyName = "oibPayment";
            this.oibPaymentDataGridViewTextBoxColumn.HeaderText = "תשלום";
            this.oibPaymentDataGridViewTextBoxColumn.Name = "oibPaymentDataGridViewTextBoxColumn";
            // 
            // oibPictureDataGridViewTextBoxColumn
            // 
            this.oibPictureDataGridViewTextBoxColumn.DataPropertyName = "oibPicture";
            this.oibPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.oibPictureDataGridViewTextBoxColumn.Name = "oibPictureDataGridViewTextBoxColumn";
            // 
            // tblObjectsInBoardBindingSource
            // 
            this.tblObjectsInBoardBindingSource.DataMember = "tblObjectsInBoard";
            this.tblObjectsInBoardBindingSource.DataSource = this.dataSetObjectsInBoard;
            // 
            // dataSetObjectsInBoard
            // 
            this.dataSetObjectsInBoard.DataSetName = "DataSetObjectsInBoard";
            this.dataSetObjectsInBoard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblObjectsInBoardTableAdapter
            // 
            this.tblObjectsInBoardTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(267, 256);
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
            this.label1.Location = new System.Drawing.Point(370, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "טבלת אובייקטים בלוח";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(453, 67);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "טבלת אובייקים בלוח";
            // 
            // FormTblObjectsInBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblObjectsInBoard";
            this.Text = "FormObjectsInBoard";
            this.Load += new System.EventHandler(this.FormObjectsInBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectsInBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectsInBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetObjectsInBoard dataSetObjectsInBoard;
        private System.Windows.Forms.BindingSource tblObjectsInBoardBindingSource;
        private DataSetObjectsInBoardTableAdapters.tblObjectsInBoardTableAdapter tblObjectsInBoardTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibBoardIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibColDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibObjectTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibText1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibText2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibText3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}