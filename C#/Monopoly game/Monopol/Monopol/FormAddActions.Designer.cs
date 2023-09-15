namespace Monopol
{
    partial class FormAddActions
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
            this.actionCost = new System.Windows.Forms.TextBox();
            this.actionName = new System.Windows.Forms.TextBox();
            this.actionPayOrBuy = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionPayOrBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetActions = new Monopol.DataSetActions();
            this.tblActionsTableAdapter = new Monopol.DataSetActionsTableAdapters.tblActionsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(185, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "הוספת פעולה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "שם פעולה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "מחיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "תשלום/קניה";
            // 
            // actionCost
            // 
            this.actionCost.Location = new System.Drawing.Point(169, 154);
            this.actionCost.Name = "actionCost";
            this.actionCost.Size = new System.Drawing.Size(155, 20);
            this.actionCost.TabIndex = 30;
            // 
            // actionName
            // 
            this.actionName.Location = new System.Drawing.Point(169, 128);
            this.actionName.Name = "actionName";
            this.actionName.Size = new System.Drawing.Size(155, 20);
            this.actionName.TabIndex = 30;
            // 
            // actionPayOrBuy
            // 
            this.actionPayOrBuy.Location = new System.Drawing.Point(169, 180);
            this.actionPayOrBuy.Name = "actionPayOrBuy";
            this.actionPayOrBuy.Size = new System.Drawing.Size(155, 20);
            this.actionPayOrBuy.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionNameDataGridViewTextBoxColumn,
            this.actionCostDataGridViewTextBoxColumn,
            this.actionPayOrBuyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblActionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 31;
            // 
            // actionNameDataGridViewTextBoxColumn
            // 
            this.actionNameDataGridViewTextBoxColumn.DataPropertyName = "actionName";
            this.actionNameDataGridViewTextBoxColumn.HeaderText = "שם פעולה";
            this.actionNameDataGridViewTextBoxColumn.Name = "actionNameDataGridViewTextBoxColumn";
            this.actionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionCostDataGridViewTextBoxColumn
            // 
            this.actionCostDataGridViewTextBoxColumn.DataPropertyName = "actionCost";
            this.actionCostDataGridViewTextBoxColumn.HeaderText = "מחיר";
            this.actionCostDataGridViewTextBoxColumn.Name = "actionCostDataGridViewTextBoxColumn";
            this.actionCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actionPayOrBuyDataGridViewTextBoxColumn
            // 
            this.actionPayOrBuyDataGridViewTextBoxColumn.DataPropertyName = "actionPayOrBuy";
            this.actionPayOrBuyDataGridViewTextBoxColumn.HeaderText = "תשלום או קניה";
            this.actionPayOrBuyDataGridViewTextBoxColumn.Name = "actionPayOrBuyDataGridViewTextBoxColumn";
            this.actionPayOrBuyDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tblActionsTableAdapter
            // 
            this.tblActionsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 60);
            this.button1.TabIndex = 32;
            this.button1.Text = "הוספה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(446, 312);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "טבלת פעולות";
            // 
            // FormAddActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 529);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.actionName);
            this.Controls.Add(this.actionPayOrBuy);
            this.Controls.Add(this.actionCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddActions";
            this.Text = "FormAddActions";
            this.Load += new System.EventHandler(this.FormAddActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetActions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox actionCost;
        private System.Windows.Forms.TextBox actionName;
        private System.Windows.Forms.TextBox actionPayOrBuy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetActions dataSetActions;
        private System.Windows.Forms.BindingSource tblActionsBindingSource;
        private DataSetActionsTableAdapters.tblActionsTableAdapter tblActionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionPayOrBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;

    }
}