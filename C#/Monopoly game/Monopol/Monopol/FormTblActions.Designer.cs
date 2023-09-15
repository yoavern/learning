namespace Monopol
{
    partial class FormTblActions
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
            this.actionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionPayOrBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetActions = new Monopol.DataSetActions();
            this.saveButton = new System.Windows.Forms.Button();
            this.tblActionsTableAdapter = new Monopol.DataSetActionsTableAdapters.tblActionsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionNameDataGridViewTextBoxColumn,
            this.actionCostDataGridViewTextBoxColumn,
            this.actionPayOrBuyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblActionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // actionNameDataGridViewTextBoxColumn
            // 
            this.actionNameDataGridViewTextBoxColumn.DataPropertyName = "actionName";
            this.actionNameDataGridViewTextBoxColumn.HeaderText = "שם פעולה";
            this.actionNameDataGridViewTextBoxColumn.Name = "actionNameDataGridViewTextBoxColumn";
            // 
            // actionCostDataGridViewTextBoxColumn
            // 
            this.actionCostDataGridViewTextBoxColumn.DataPropertyName = "actionCost";
            this.actionCostDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.actionCostDataGridViewTextBoxColumn.Name = "actionCostDataGridViewTextBoxColumn";
            // 
            // actionPayOrBuyDataGridViewTextBoxColumn
            // 
            this.actionPayOrBuyDataGridViewTextBoxColumn.DataPropertyName = "actionPayOrBuy";
            this.actionPayOrBuyDataGridViewTextBoxColumn.HeaderText = "תשלום/קניה";
            this.actionPayOrBuyDataGridViewTextBoxColumn.Name = "actionPayOrBuyDataGridViewTextBoxColumn";
            // 
            // tblActionsBindingSource
            // 
            this.tblActionsBindingSource.DataMember = "tblActions";
            this.tblActionsBindingSource.DataSource = this.dataSetActions;
            // 
            // dataSetActions
            // 
            this.dataSetActions.DataSetName = "DataSetActions";
            this.dataSetActions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(261, 250);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // tblActionsTableAdapter
            // 
            this.tblActionsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(441, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת פעולות";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(488, 61);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "טבלת פעולות";
            // 
            // FormTblActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 313);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblActions";
            this.Text = "FormActions";
            this.Load += new System.EventHandler(this.FormActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetActions dataSetActions;
        private System.Windows.Forms.BindingSource tblActionsBindingSource;
        private DataSetActionsTableAdapters.tblActionsTableAdapter tblActionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionPayOrBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}