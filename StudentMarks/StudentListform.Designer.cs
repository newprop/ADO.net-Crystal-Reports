namespace StudentMarks
{
    partial class StudentListform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnstudentlist = new System.Windows.Forms.Button();
            this.studentgrit = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classRollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentgrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnedit);
            this.groupBox1.Controls.Add(this.btnload);
            this.groupBox1.Controls.Add(this.btnstudentlist);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(759, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "data filter";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(545, 64);
            this.btnedit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(56, 36);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(432, 64);
            this.btnload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(56, 36);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnstudentlist
            // 
            this.btnstudentlist.Location = new System.Drawing.Point(116, 64);
            this.btnstudentlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstudentlist.Name = "btnstudentlist";
            this.btnstudentlist.Size = new System.Drawing.Size(138, 36);
            this.btnstudentlist.TabIndex = 0;
            this.btnstudentlist.Text = "studentReport";
            this.btnstudentlist.UseVisualStyleBackColor = true;
            this.btnstudentlist.Click += new System.EventHandler(this.btnstudentlist_Click);
            // 
            // studentgrit
            // 
            this.studentgrit.AllowUserToAddRows = false;
            this.studentgrit.AllowUserToDeleteRows = false;
            this.studentgrit.AutoGenerateColumns = false;
            this.studentgrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentgrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.classRollDataGridViewTextBoxColumn});
            this.studentgrit.DataSource = this.studentBindingSource;
            this.studentgrit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentgrit.Location = new System.Drawing.Point(0, 134);
            this.studentgrit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentgrit.MultiSelect = false;
            this.studentgrit.Name = "studentgrit";
            this.studentgrit.ReadOnly = true;
            this.studentgrit.RowHeadersWidth = 51;
            this.studentgrit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentgrit.Size = new System.Drawing.Size(759, 232);
            this.studentgrit.TabIndex = 1;
            this.studentgrit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classRollDataGridViewTextBoxColumn
            // 
            this.classRollDataGridViewTextBoxColumn.DataPropertyName = "ClassRoll";
            this.classRollDataGridViewTextBoxColumn.HeaderText = "ClassRoll";
            this.classRollDataGridViewTextBoxColumn.Name = "classRollDataGridViewTextBoxColumn";
            this.classRollDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentMarks.App_data.Student);
            // 
            // StudentListform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 366);
            this.Controls.Add(this.studentgrit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentListform";
            this.Text = "StudentListform";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentgrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnstudentlist;
        private System.Windows.Forms.DataGridView studentgrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classRollDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}