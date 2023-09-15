namespace Monopol
{
    partial class FormAddSteps
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
            this.label11 = new System.Windows.Forms.Label();
            this.stepPlayerNum = new System.Windows.Forms.TextBox();
            this.stepOrderNum = new System.Windows.Forms.TextBox();
            this.stepGameID = new System.Windows.Forms.TextBox();
            this.stepDice1 = new System.Windows.Forms.TextBox();
            this.stepDice2 = new System.Windows.Forms.TextBox();
            this.stepCash2 = new System.Windows.Forms.TextBox();
            this.stepProperty1 = new System.Windows.Forms.TextBox();
            this.stepProperty2 = new System.Windows.Forms.TextBox();
            this.stepCash1 = new System.Windows.Forms.TextBox();
            this.stepAction = new System.Windows.Forms.TextBox();
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
            this.tblStepsTableAdapter = new Monopol.DataSetStepsTableAdapters.tblStepsTableAdapter();
            this.Button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(288, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "הוספת מהלכי משחק";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "מספר משחק";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "מספר מהלך";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 186);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "מספר שחקן-1/2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "קוביה 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "קוביה 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "פעולה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "מזומן שחקן 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "מזומן שחקן 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "רכוש שחקן 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "רכוש שחקן 2";
            // 
            // stepPlayerNum
            // 
            this.stepPlayerNum.Location = new System.Drawing.Point(396, 183);
            this.stepPlayerNum.Name = "stepPlayerNum";
            this.stepPlayerNum.Size = new System.Drawing.Size(165, 20);
            this.stepPlayerNum.TabIndex = 30;
            // 
            // stepOrderNum
            // 
            this.stepOrderNum.Location = new System.Drawing.Point(396, 156);
            this.stepOrderNum.Name = "stepOrderNum";
            this.stepOrderNum.Size = new System.Drawing.Size(165, 20);
            this.stepOrderNum.TabIndex = 30;
            // 
            // stepGameID
            // 
            this.stepGameID.Location = new System.Drawing.Point(396, 128);
            this.stepGameID.Name = "stepGameID";
            this.stepGameID.Size = new System.Drawing.Size(165, 20);
            this.stepGameID.TabIndex = 30;
            // 
            // stepDice1
            // 
            this.stepDice1.Location = new System.Drawing.Point(396, 208);
            this.stepDice1.Name = "stepDice1";
            this.stepDice1.Size = new System.Drawing.Size(165, 20);
            this.stepDice1.TabIndex = 30;
            // 
            // stepDice2
            // 
            this.stepDice2.Location = new System.Drawing.Point(396, 235);
            this.stepDice2.Name = "stepDice2";
            this.stepDice2.Size = new System.Drawing.Size(165, 20);
            this.stepDice2.TabIndex = 30;
            // 
            // stepCash2
            // 
            this.stepCash2.Location = new System.Drawing.Point(127, 183);
            this.stepCash2.Name = "stepCash2";
            this.stepCash2.Size = new System.Drawing.Size(165, 20);
            this.stepCash2.TabIndex = 30;
            // 
            // stepProperty1
            // 
            this.stepProperty1.Location = new System.Drawing.Point(127, 208);
            this.stepProperty1.Name = "stepProperty1";
            this.stepProperty1.Size = new System.Drawing.Size(165, 20);
            this.stepProperty1.TabIndex = 30;
            // 
            // stepProperty2
            // 
            this.stepProperty2.Location = new System.Drawing.Point(127, 235);
            this.stepProperty2.Name = "stepProperty2";
            this.stepProperty2.Size = new System.Drawing.Size(165, 20);
            this.stepProperty2.TabIndex = 30;
            // 
            // stepCash1
            // 
            this.stepCash1.Location = new System.Drawing.Point(127, 156);
            this.stepCash1.Name = "stepCash1";
            this.stepCash1.Size = new System.Drawing.Size(165, 20);
            this.stepCash1.TabIndex = 30;
            // 
            // stepAction
            // 
            this.stepAction.Location = new System.Drawing.Point(127, 128);
            this.stepAction.Name = "stepAction";
            this.stepAction.Size = new System.Drawing.Size(165, 20);
            this.stepAction.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(745, 182);
            this.dataGridView1.TabIndex = 31;
            // 
            // stepGameIDDataGridViewTextBoxColumn
            // 
            this.stepGameIDDataGridViewTextBoxColumn.DataPropertyName = "stepGameID";
            this.stepGameIDDataGridViewTextBoxColumn.HeaderText = "מספר משחק";
            this.stepGameIDDataGridViewTextBoxColumn.Name = "stepGameIDDataGridViewTextBoxColumn";
            this.stepGameIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepOrderNumDataGridViewTextBoxColumn
            // 
            this.stepOrderNumDataGridViewTextBoxColumn.DataPropertyName = "stepOrderNum";
            this.stepOrderNumDataGridViewTextBoxColumn.HeaderText = "מספר מהלך";
            this.stepOrderNumDataGridViewTextBoxColumn.Name = "stepOrderNumDataGridViewTextBoxColumn";
            this.stepOrderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepPlayerNumDataGridViewTextBoxColumn
            // 
            this.stepPlayerNumDataGridViewTextBoxColumn.DataPropertyName = "stepPlayerNum";
            this.stepPlayerNumDataGridViewTextBoxColumn.HeaderText = "מספר שחקן-1/2";
            this.stepPlayerNumDataGridViewTextBoxColumn.Name = "stepPlayerNumDataGridViewTextBoxColumn";
            this.stepPlayerNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepDice1DataGridViewTextBoxColumn
            // 
            this.stepDice1DataGridViewTextBoxColumn.DataPropertyName = "stepDice1";
            this.stepDice1DataGridViewTextBoxColumn.HeaderText = "קוביה 1";
            this.stepDice1DataGridViewTextBoxColumn.Name = "stepDice1DataGridViewTextBoxColumn";
            this.stepDice1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepDice2DataGridViewTextBoxColumn
            // 
            this.stepDice2DataGridViewTextBoxColumn.DataPropertyName = "stepDice2";
            this.stepDice2DataGridViewTextBoxColumn.HeaderText = "קוביה 2";
            this.stepDice2DataGridViewTextBoxColumn.Name = "stepDice2DataGridViewTextBoxColumn";
            this.stepDice2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepActionDataGridViewTextBoxColumn
            // 
            this.stepActionDataGridViewTextBoxColumn.DataPropertyName = "stepAction";
            this.stepActionDataGridViewTextBoxColumn.HeaderText = "פעולה";
            this.stepActionDataGridViewTextBoxColumn.Name = "stepActionDataGridViewTextBoxColumn";
            this.stepActionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepCash1DataGridViewTextBoxColumn
            // 
            this.stepCash1DataGridViewTextBoxColumn.DataPropertyName = "stepCash1";
            this.stepCash1DataGridViewTextBoxColumn.HeaderText = "מזומן שחקן 1";
            this.stepCash1DataGridViewTextBoxColumn.Name = "stepCash1DataGridViewTextBoxColumn";
            this.stepCash1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepCash2DataGridViewTextBoxColumn
            // 
            this.stepCash2DataGridViewTextBoxColumn.DataPropertyName = "stepCash2";
            this.stepCash2DataGridViewTextBoxColumn.HeaderText = "מזומן שחקן 2";
            this.stepCash2DataGridViewTextBoxColumn.Name = "stepCash2DataGridViewTextBoxColumn";
            this.stepCash2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepProperty1DataGridViewTextBoxColumn
            // 
            this.stepProperty1DataGridViewTextBoxColumn.DataPropertyName = "stepProperty1";
            this.stepProperty1DataGridViewTextBoxColumn.HeaderText = "רכוש שחקן 1";
            this.stepProperty1DataGridViewTextBoxColumn.Name = "stepProperty1DataGridViewTextBoxColumn";
            this.stepProperty1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stepProperty2DataGridViewTextBoxColumn
            // 
            this.stepProperty2DataGridViewTextBoxColumn.DataPropertyName = "stepProperty2";
            this.stepProperty2DataGridViewTextBoxColumn.HeaderText = "רכוש שחקן 2";
            this.stepProperty2DataGridViewTextBoxColumn.Name = "stepProperty2DataGridViewTextBoxColumn";
            this.stepProperty2DataGridViewTextBoxColumn.ReadOnly = true;
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
            // tblStepsTableAdapter
            // 
            this.tblStepsTableAdapter.ClearBeforeFill = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(301, 285);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(186, 63);
            this.Button1.TabIndex = 32;
            this.Button1.Text = "הוספה";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(645, 346);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(115, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "טבלת מהלכי משחק";
            // 
            // FormAddSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 575);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stepAction);
            this.Controls.Add(this.stepGameID);
            this.Controls.Add(this.stepCash1);
            this.Controls.Add(this.stepOrderNum);
            this.Controls.Add(this.stepProperty2);
            this.Controls.Add(this.stepDice2);
            this.Controls.Add(this.stepProperty1);
            this.Controls.Add(this.stepDice1);
            this.Controls.Add(this.stepCash2);
            this.Controls.Add(this.stepPlayerNum);
            this.Controls.Add(this.label11);
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
            this.Name = "FormAddSteps";
            this.Text = "FormAddSteps";
            this.Load += new System.EventHandler(this.FormAddSteps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSteps)).EndInit();
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox stepPlayerNum;
        private System.Windows.Forms.TextBox stepOrderNum;
        private System.Windows.Forms.TextBox stepGameID;
        private System.Windows.Forms.TextBox stepDice1;
        private System.Windows.Forms.TextBox stepDice2;
        private System.Windows.Forms.TextBox stepCash2;
        private System.Windows.Forms.TextBox stepProperty1;
        private System.Windows.Forms.TextBox stepProperty2;
        private System.Windows.Forms.TextBox stepCash1;
        private System.Windows.Forms.TextBox stepAction;
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
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label12;
    }
}