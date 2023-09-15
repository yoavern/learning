namespace Monopol
{
    partial class FormAddObjectsInBoard
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.oibBoardID = new System.Windows.Forms.TextBox();
            this.oibRow = new System.Windows.Forms.TextBox();
            this.oibCol = new System.Windows.Forms.TextBox();
            this.oibObjectType = new System.Windows.Forms.TextBox();
            this.oibText1 = new System.Windows.Forms.TextBox();
            this.oibText2 = new System.Windows.Forms.TextBox();
            this.oibText3 = new System.Windows.Forms.TextBox();
            this.oibPayment = new System.Windows.Forms.TextBox();
            this.oibPicture = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectsInBoardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectsInBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(267, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "הוספת אובייקטים בלוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "מספר לוח";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "שורה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "עמודה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "סוג אובייקט";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "טקסט 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "טקסט 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "טקסט 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "תשלום";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "תמונה";
            // 
            // oibBoardID
            // 
            this.oibBoardID.Location = new System.Drawing.Point(567, 106);
            this.oibBoardID.Name = "oibBoardID";
            this.oibBoardID.Size = new System.Drawing.Size(136, 20);
            this.oibBoardID.TabIndex = 31;
            // 
            // oibRow
            // 
            this.oibRow.Location = new System.Drawing.Point(567, 135);
            this.oibRow.Name = "oibRow";
            this.oibRow.Size = new System.Drawing.Size(136, 20);
            this.oibRow.TabIndex = 31;
            // 
            // oibCol
            // 
            this.oibCol.Location = new System.Drawing.Point(567, 167);
            this.oibCol.Name = "oibCol";
            this.oibCol.Size = new System.Drawing.Size(136, 20);
            this.oibCol.TabIndex = 31;
            // 
            // oibObjectType
            // 
            this.oibObjectType.Location = new System.Drawing.Point(567, 203);
            this.oibObjectType.Name = "oibObjectType";
            this.oibObjectType.Size = new System.Drawing.Size(136, 20);
            this.oibObjectType.TabIndex = 31;
            // 
            // oibText1
            // 
            this.oibText1.Location = new System.Drawing.Point(567, 234);
            this.oibText1.Name = "oibText1";
            this.oibText1.Size = new System.Drawing.Size(136, 20);
            this.oibText1.TabIndex = 31;
            // 
            // oibText2
            // 
            this.oibText2.Location = new System.Drawing.Point(134, 106);
            this.oibText2.Name = "oibText2";
            this.oibText2.Size = new System.Drawing.Size(147, 20);
            this.oibText2.TabIndex = 31;
            // 
            // oibText3
            // 
            this.oibText3.Location = new System.Drawing.Point(134, 135);
            this.oibText3.Name = "oibText3";
            this.oibText3.Size = new System.Drawing.Size(147, 20);
            this.oibText3.TabIndex = 31;
            // 
            // oibPayment
            // 
            this.oibPayment.Location = new System.Drawing.Point(134, 164);
            this.oibPayment.Name = "oibPayment";
            this.oibPayment.Size = new System.Drawing.Size(147, 20);
            this.oibPayment.TabIndex = 31;
            // 
            // oibPicture
            // 
            this.oibPicture.Location = new System.Drawing.Point(134, 194);
            this.oibPicture.Name = "oibPicture";
            this.oibPicture.Size = new System.Drawing.Size(147, 20);
            this.oibPicture.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 32;
            this.button1.Text = "הוספה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(547, 204);
            this.dataGridView1.TabIndex = 33;
            // 
            // oibBoardIDDataGridViewTextBoxColumn
            // 
            this.oibBoardIDDataGridViewTextBoxColumn.DataPropertyName = "oibBoardID";
            this.oibBoardIDDataGridViewTextBoxColumn.HeaderText = "מספר לוח";
            this.oibBoardIDDataGridViewTextBoxColumn.Name = "oibBoardIDDataGridViewTextBoxColumn";
            this.oibBoardIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibRowDataGridViewTextBoxColumn
            // 
            this.oibRowDataGridViewTextBoxColumn.DataPropertyName = "oibRow";
            this.oibRowDataGridViewTextBoxColumn.HeaderText = "שורה";
            this.oibRowDataGridViewTextBoxColumn.Name = "oibRowDataGridViewTextBoxColumn";
            this.oibRowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibColDataGridViewTextBoxColumn
            // 
            this.oibColDataGridViewTextBoxColumn.DataPropertyName = "oibCol";
            this.oibColDataGridViewTextBoxColumn.HeaderText = "עמודה";
            this.oibColDataGridViewTextBoxColumn.Name = "oibColDataGridViewTextBoxColumn";
            this.oibColDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibObjectTypeDataGridViewTextBoxColumn
            // 
            this.oibObjectTypeDataGridViewTextBoxColumn.DataPropertyName = "oibObjectType";
            this.oibObjectTypeDataGridViewTextBoxColumn.HeaderText = "סוג אובייקט";
            this.oibObjectTypeDataGridViewTextBoxColumn.Name = "oibObjectTypeDataGridViewTextBoxColumn";
            this.oibObjectTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibText1DataGridViewTextBoxColumn
            // 
            this.oibText1DataGridViewTextBoxColumn.DataPropertyName = "oibText1";
            this.oibText1DataGridViewTextBoxColumn.HeaderText = "טקסט 1";
            this.oibText1DataGridViewTextBoxColumn.Name = "oibText1DataGridViewTextBoxColumn";
            this.oibText1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibText2DataGridViewTextBoxColumn
            // 
            this.oibText2DataGridViewTextBoxColumn.DataPropertyName = "oibText2";
            this.oibText2DataGridViewTextBoxColumn.HeaderText = "טקסט 2";
            this.oibText2DataGridViewTextBoxColumn.Name = "oibText2DataGridViewTextBoxColumn";
            this.oibText2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibText3DataGridViewTextBoxColumn
            // 
            this.oibText3DataGridViewTextBoxColumn.DataPropertyName = "oibText3";
            this.oibText3DataGridViewTextBoxColumn.HeaderText = "טקסט 3";
            this.oibText3DataGridViewTextBoxColumn.Name = "oibText3DataGridViewTextBoxColumn";
            this.oibText3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibPaymentDataGridViewTextBoxColumn
            // 
            this.oibPaymentDataGridViewTextBoxColumn.DataPropertyName = "oibPayment";
            this.oibPaymentDataGridViewTextBoxColumn.HeaderText = "תשלום";
            this.oibPaymentDataGridViewTextBoxColumn.Name = "oibPaymentDataGridViewTextBoxColumn";
            this.oibPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oibPictureDataGridViewTextBoxColumn
            // 
            this.oibPictureDataGridViewTextBoxColumn.DataPropertyName = "oibPicture";
            this.oibPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.oibPictureDataGridViewTextBoxColumn.Name = "oibPictureDataGridViewTextBoxColumn";
            this.oibPictureDataGridViewTextBoxColumn.ReadOnly = true;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 192);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "עיון...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(592, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 204);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(427, 330);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(135, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "טבלת אובייקטים בלוח";
            // 
            // FormAddObjectsInBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 579);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.oibPicture);
            this.Controls.Add(this.oibPayment);
            this.Controls.Add(this.oibText3);
            this.Controls.Add(this.oibText2);
            this.Controls.Add(this.oibText1);
            this.Controls.Add(this.oibObjectType);
            this.Controls.Add(this.oibCol);
            this.Controls.Add(this.oibRow);
            this.Controls.Add(this.oibBoardID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddObjectsInBoard";
            this.Text = "FormAddObjectsInBoard";
            this.Load += new System.EventHandler(this.FormAddObjectsInBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectsInBoardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectsInBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox oibBoardID;
        private System.Windows.Forms.TextBox oibRow;
        private System.Windows.Forms.TextBox oibCol;
        private System.Windows.Forms.TextBox oibObjectType;
        private System.Windows.Forms.TextBox oibText1;
        private System.Windows.Forms.TextBox oibText2;
        private System.Windows.Forms.TextBox oibText3;
        private System.Windows.Forms.TextBox oibPayment;
        private System.Windows.Forms.TextBox oibPicture;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
    }
}