namespace Monopol
{
    partial class FormUpdateSteps
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
            this.Button1 = new System.Windows.Forms.Button();
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
            this.stepAction = new System.Windows.Forms.TextBox();
            this.stepGameID = new System.Windows.Forms.TextBox();
            this.stepCash1 = new System.Windows.Forms.TextBox();
            this.stepOrderNum = new System.Windows.Forms.TextBox();
            this.stepProperty2 = new System.Windows.Forms.TextBox();
            this.stepDice2 = new System.Windows.Forms.TextBox();
            this.stepProperty1 = new System.Windows.Forms.TextBox();
            this.stepDice1 = new System.Windows.Forms.TextBox();
            this.stepCash2 = new System.Windows.Forms.TextBox();
            this.stepPlayerNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.tblStepsTableAdapter = new Monopol.DataSetStepsTableAdapters.tblStepsTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(348, 288);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(186, 63);
            this.Button1.TabIndex = 55;
            this.Button1.Text = "עדכון";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(54, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 182);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.stepPlayerNumDataGridViewTextBoxColumn.HeaderText = "מספר שחקן 1/2 ";
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
            // stepAction
            // 
            this.stepAction.Location = new System.Drawing.Point(182, 97);
            this.stepAction.Name = "stepAction";
            this.stepAction.Size = new System.Drawing.Size(165, 20);
            this.stepAction.TabIndex = 52;
            // 
            // stepGameID
            // 
            this.stepGameID.Location = new System.Drawing.Point(451, 97);
            this.stepGameID.Name = "stepGameID";
            this.stepGameID.ReadOnly = true;
            this.stepGameID.Size = new System.Drawing.Size(165, 20);
            this.stepGameID.TabIndex = 51;
            // 
            // stepCash1
            // 
            this.stepCash1.Location = new System.Drawing.Point(182, 125);
            this.stepCash1.Name = "stepCash1";
            this.stepCash1.Size = new System.Drawing.Size(165, 20);
            this.stepCash1.TabIndex = 50;
            // 
            // stepOrderNum
            // 
            this.stepOrderNum.Location = new System.Drawing.Point(451, 125);
            this.stepOrderNum.Name = "stepOrderNum";
            this.stepOrderNum.Size = new System.Drawing.Size(165, 20);
            this.stepOrderNum.TabIndex = 49;
            // 
            // stepProperty2
            // 
            this.stepProperty2.Location = new System.Drawing.Point(182, 204);
            this.stepProperty2.Name = "stepProperty2";
            this.stepProperty2.Size = new System.Drawing.Size(165, 20);
            this.stepProperty2.TabIndex = 48;
            // 
            // stepDice2
            // 
            this.stepDice2.Location = new System.Drawing.Point(451, 204);
            this.stepDice2.Name = "stepDice2";
            this.stepDice2.Size = new System.Drawing.Size(165, 20);
            this.stepDice2.TabIndex = 47;
            // 
            // stepProperty1
            // 
            this.stepProperty1.Location = new System.Drawing.Point(182, 177);
            this.stepProperty1.Name = "stepProperty1";
            this.stepProperty1.Size = new System.Drawing.Size(165, 20);
            this.stepProperty1.TabIndex = 46;
            // 
            // stepDice1
            // 
            this.stepDice1.Location = new System.Drawing.Point(451, 177);
            this.stepDice1.Name = "stepDice1";
            this.stepDice1.Size = new System.Drawing.Size(165, 20);
            this.stepDice1.TabIndex = 45;
            // 
            // stepCash2
            // 
            this.stepCash2.Location = new System.Drawing.Point(182, 152);
            this.stepCash2.Name = "stepCash2";
            this.stepCash2.Size = new System.Drawing.Size(165, 20);
            this.stepCash2.TabIndex = 53;
            // 
            // stepPlayerNum
            // 
            this.stepPlayerNum.Location = new System.Drawing.Point(451, 152);
            this.stepPlayerNum.Name = "stepPlayerNum";
            this.stepPlayerNum.Size = new System.Drawing.Size(165, 20);
            this.stepPlayerNum.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(355, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "רכוש שחקן 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "רכוש שחקן 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "מזומן שחקן 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "מזומן שחקן 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "פעולה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "קוביה 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "קוביה 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 155);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "מספר שחקן-1/2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "מספר מהלך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "מספר משחק";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(343, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "עדכון מהלכי משחק";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(548, 250);
            this.buttonFirst.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(60, 33);
            this.buttonFirst.TabIndex = 91;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(483, 250);
            this.buttonLast.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(61, 33);
            this.buttonLast.TabIndex = 90;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(264, 250);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(62, 33);
            this.buttonNext.TabIndex = 89;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(330, 250);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(62, 33);
            this.buttonPrev.TabIndex = 88;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // tblStepsTableAdapter
            // 
            this.tblStepsTableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(687, 335);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(115, 16);
            this.label12.TabIndex = 92;
            this.label12.Text = "טבלת מהלכי משחק";
            // 
            // FormUpdateSteps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 551);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
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
            this.Name = "FormUpdateSteps";
            this.Text = "FormUpdateSteps";
            this.Load += new System.EventHandler(this.FormUpdateSteps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox stepAction;
        private System.Windows.Forms.TextBox stepGameID;
        private System.Windows.Forms.TextBox stepCash1;
        private System.Windows.Forms.TextBox stepOrderNum;
        private System.Windows.Forms.TextBox stepProperty2;
        private System.Windows.Forms.TextBox stepDice2;
        private System.Windows.Forms.TextBox stepProperty1;
        private System.Windows.Forms.TextBox stepDice1;
        private System.Windows.Forms.TextBox stepCash2;
        private System.Windows.Forms.TextBox stepPlayerNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
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
        private System.Windows.Forms.Label label12;

    }
}