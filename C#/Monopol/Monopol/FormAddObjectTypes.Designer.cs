namespace Monopol
{
    partial class FormAddObjectTypes
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
            this.objectCshName = new System.Windows.Forms.TextBox();
            this.objectHebName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.objectHebNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectCshNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblObjectTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetObjectTypes = new Monopol.DataSetObjectTypes();
            this.tblObjectTypesTableAdapter = new Monopol.DataSetObjectTypesTableAdapters.tblObjectTypesTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(96, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "הוספת סוג אובייקט";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 160);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "שם בסי שרפ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 117);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "שם בעברית";
            // 
            // objectCshName
            // 
            this.objectCshName.Location = new System.Drawing.Point(88, 157);
            this.objectCshName.Name = "objectCshName";
            this.objectCshName.Size = new System.Drawing.Size(191, 20);
            this.objectCshName.TabIndex = 31;
            // 
            // objectHebName
            // 
            this.objectHebName.Location = new System.Drawing.Point(88, 114);
            this.objectHebName.Name = "objectHebName";
            this.objectHebName.Size = new System.Drawing.Size(191, 20);
            this.objectHebName.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 51);
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
            this.objectHebNameDataGridViewTextBoxColumn,
            this.objectCshNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblObjectTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(348, 159);
            this.dataGridView1.TabIndex = 33;
            // 
            // objectHebNameDataGridViewTextBoxColumn
            // 
            this.objectHebNameDataGridViewTextBoxColumn.DataPropertyName = "objectHebName";
            this.objectHebNameDataGridViewTextBoxColumn.HeaderText = "שם בעברית";
            this.objectHebNameDataGridViewTextBoxColumn.Name = "objectHebNameDataGridViewTextBoxColumn";
            this.objectHebNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // objectCshNameDataGridViewTextBoxColumn
            // 
            this.objectCshNameDataGridViewTextBoxColumn.DataPropertyName = "objectCshName";
            this.objectCshNameDataGridViewTextBoxColumn.HeaderText = "שם בסי שרפ";
            this.objectCshNameDataGridViewTextBoxColumn.Name = "objectCshNameDataGridViewTextBoxColumn";
            this.objectCshNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblObjectTypesBindingSource
            // 
            this.tblObjectTypesBindingSource.DataMember = "tblObjectTypes";
            this.tblObjectTypesBindingSource.DataSource = this.dataSetObjectTypes;
            // 
            // dataSetObjectTypes
            // 
            this.dataSetObjectTypes.DataSetName = "DataSetObjectTypes";
            this.dataSetObjectTypes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblObjectTypesTableAdapter
            // 
            this.tblObjectTypesTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(247, 262);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "טבלת סוגי אובייקטים";
            // 
            // FormAddObjectTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.objectHebName);
            this.Controls.Add(this.objectCshName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddObjectTypes";
            this.Text = "FormAddObjectTypes";
            this.Load += new System.EventHandler(this.FormAddObjectTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox objectCshName;
        private System.Windows.Forms.TextBox objectHebName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetObjectTypes dataSetObjectTypes;
        private System.Windows.Forms.BindingSource tblObjectTypesBindingSource;
        private DataSetObjectTypesTableAdapters.tblObjectTypesTableAdapter tblObjectTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectHebNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectCshNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
    }
}