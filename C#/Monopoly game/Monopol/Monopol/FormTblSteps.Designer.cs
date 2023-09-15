namespace Monopol
{
    partial class FormTblSteps
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
            this.stepGameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepOrderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepPlayerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepDice1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepDice2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepActionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepCash1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepCash2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepProperty1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepProperty2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSteps = new Monopol.DataSetSteps();
            this.saveButton = new System.Windows.Forms.Button();
            this.tblStepsTableAdapter = new Monopol.DataSetStepsTableAdapters.tblStepsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepGameIDDataGridViewTextBoxColumn,
            this.stepOrderNumDataGridViewTextBoxColumn,
            this.stepPlayerNumDataGridViewTextBoxColumn,
            this.stepDice1DataGridViewTextBoxColumn,
            this.stepDice2DataGridViewTextBoxColumn,
            this.stepActionDataGridViewTextBoxColumn,
            this.stepCash1DataGridViewTextBoxColumn,
            this.stepCash2DataGridViewTextBoxColumn,
            this.stepProperty1DataGridViewTextBoxColumn,
            this.stepProperty2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStepsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // stepGameIDDataGridViewTextBoxColumn
            // 
            this.stepGameIDDataGridViewTextBoxColumn.DataPropertyName = "stepGameID";
            this.stepGameIDDataGridViewTextBoxColumn.HeaderText = "מספר משחק";
            this.stepGameIDDataGridViewTextBoxColumn.Name = "stepGameIDDataGridViewTextBoxColumn";
            // 
            // stepOrderNumDataGridViewTextBoxColumn
            // 
            this.stepOrderNumDataGridViewTextBoxColumn.DataPropertyName = "stepOrderNum";
            this.stepOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר מהלך";
            this.stepOrderNumDataGridViewTextBoxColumn.Name = "stepOrderNumDataGridViewTextBoxColumn";
            // 
            // stepPlayerNumDataGridViewTextBoxColumn
            // 
            this.stepPlayerNumDataGridViewTextBoxColumn.DataPropertyName = "stepPlayerNum";
            this.stepPlayerNumDataGridViewTextBoxColumn.HeaderText = "(מספר שחקן(1/2";
            this.stepPlayerNumDataGridViewTextBoxColumn.Name = "stepPlayerNumDataGridViewTextBoxColumn";
            // 
            // stepDice1DataGridViewTextBoxColumn
            // 
            this.stepDice1DataGridViewTextBoxColumn.DataPropertyName = "stepDice1";
            this.stepDice1DataGridViewTextBoxColumn.HeaderText = "קוביה 1";
            this.stepDice1DataGridViewTextBoxColumn.Name = "stepDice1DataGridViewTextBoxColumn";
            // 
            // stepDice2DataGridViewTextBoxColumn
            // 
            this.stepDice2DataGridViewTextBoxColumn.DataPropertyName = "stepDice2";
            this.stepDice2DataGridViewTextBoxColumn.HeaderText = "קוביה 2";
            this.stepDice2DataGridViewTextBoxColumn.Name = "stepDice2DataGridViewTextBoxColumn";
            // 
            // stepActionDataGridViewTextBoxColumn
            // 
            this.stepActionDataGridViewTextBoxColumn.DataPropertyName = "stepAction";
            this.stepActionDataGridViewTextBoxColumn.HeaderText = "פעולה";
            this.stepActionDataGridViewTextBoxColumn.Name = "stepActionDataGridViewTextBoxColumn";
            // 
            // stepCash1DataGridViewTextBoxColumn
            // 
            this.stepCash1DataGridViewTextBoxColumn.DataPropertyName = "stepCash1";
            this.stepCash1DataGridViewTextBoxColumn.HeaderText = "מזומן שחקן 1";
            this.stepCash1DataGridViewTextBoxColumn.Name = "stepCash1DataGridViewTextBoxColumn";
            // 
            // stepCash2DataGridViewTextBoxColumn
            // 
            this.stepCash2DataGridViewTextBoxColumn.DataPropertyName = "stepCash2";
            this.stepCash2DataGridViewTextBoxColumn.HeaderText = "מזומן שחקן 2";
            this.stepCash2DataGridViewTextBoxColumn.Name = "stepCash2DataGridViewTextBoxColumn";
            // 
            // stepProperty1DataGridViewTextBoxColumn
            // 
            this.stepProperty1DataGridViewTextBoxColumn.DataPropertyName = "stepProperty1";
            this.stepProperty1DataGridViewTextBoxColumn.HeaderText = "רכוש שחקן 1";
            this.stepProperty1DataGridViewTextBoxColumn.Name = "stepProperty1DataGridViewTextBoxColumn";
            // 
            // stepProperty2DataGridViewTextBoxColumn
            // 
            this.stepProperty2DataGridViewTextBoxColumn.DataPropertyName = "stepProperty2";
            this.stepProperty2DataGridViewTextBoxColumn.HeaderText = "רכוש שחקן 2";
            this.stepProperty2DataGridViewTextBoxColumn.Name = "stepProperty2DataGridViewTextBoxColumn";
            // 
            // tblStepsBindingSource
            // 
            this.tblStepsBindingSource.DataMember = "tblSteps";
            this.tblStepsBindingSource.DataSource = this.dataSetSteps;
            // 
            // dataSetSteps
            // 
            this.dataSetSteps.DataSetName = "DataSetSteps";
            this.dataSetSteps.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(261, 253);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // tblStepsTableAdapter
            // 
            this.tblStepsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(391, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "טבלת מהלכי משחק";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(459, 64);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "טבלת מהלכי משחק";
            // 
            // FormTblSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblSteps";
            this.Text = "FormSteps";
            this.Load += new System.EventHandler(this.FormSteps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetSteps dataSetSteps;
        private System.Windows.Forms.BindingSource tblStepsBindingSource;
        private DataSetStepsTableAdapters.tblStepsTableAdapter tblStepsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepGameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepOrderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepPlayerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepDice1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepDice2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepActionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepCash1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepCash2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepProperty1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepProperty2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}