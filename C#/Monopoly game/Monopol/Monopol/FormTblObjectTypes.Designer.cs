namespace Monopol
{
    partial class FormTblObjectTypes
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
            this.objectHebNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectCshNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblObjectTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetObjectTypes = new Monopol.DataSetObjectTypes();
            this.tblObjectTypesTableAdapter = new Monopol.DataSetObjectTypesTableAdapters.tblObjectTypesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectHebNameDataGridViewTextBoxColumn,
            this.objectCshNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblObjectTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // objectHebNameDataGridViewTextBoxColumn
            // 
            this.objectHebNameDataGridViewTextBoxColumn.DataPropertyName = "objectHebName";
            this.objectHebNameDataGridViewTextBoxColumn.HeaderText = "שם בעברית של אובייקט";
            this.objectHebNameDataGridViewTextBoxColumn.Name = "objectHebNameDataGridViewTextBoxColumn";
            // 
            // objectCshNameDataGridViewTextBoxColumn
            // 
            this.objectCshNameDataGridViewTextBoxColumn.DataPropertyName = "objectCshName";
            this.objectCshNameDataGridViewTextBoxColumn.HeaderText = "שם בסי שרפ של אובייקט";
            this.objectCshNameDataGridViewTextBoxColumn.Name = "objectCshNameDataGridViewTextBoxColumn";
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
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(264, 249);
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
            this.label1.Location = new System.Drawing.Point(374, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "טבלת סוגי אובייקטים";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(447, 60);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "טבלת סוגי אובייקטים";
            // 
            // FormTblObjectTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblObjectTypes";
            this.Text = "FormObjectTypes";
            this.Load += new System.EventHandler(this.FormObjectTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblObjectTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObjectTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetObjectTypes dataSetObjectTypes;
        private System.Windows.Forms.BindingSource tblObjectTypesBindingSource;
        private DataSetObjectTypesTableAdapters.tblObjectTypesTableAdapter tblObjectTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectHebNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectCshNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}