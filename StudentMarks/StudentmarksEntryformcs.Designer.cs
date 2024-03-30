namespace StudentMarks
{
    partial class StudentmarksEntryformcs
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtroll = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.marksgrit = new System.Windows.Forms.DataGridView();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtainedNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksgrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.txtroll);
            this.groupBox1.Controls.Add(this.txtclass);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(244, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "studentmarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ClassRoll:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "studentname:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "studentId:";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(158, 292);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(56, 19);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(76, 292);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(56, 19);
            this.btnreset.TabIndex = 1;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(9, 292);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(56, 19);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // txtroll
            // 
            this.txtroll.Location = new System.Drawing.Point(78, 223);
            this.txtroll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtroll.Name = "txtroll";
            this.txtroll.Size = new System.Drawing.Size(144, 20);
            this.txtroll.TabIndex = 0;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(78, 162);
            this.txtclass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(144, 20);
            this.txtclass.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 111);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(78, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(144, 20);
            this.txtId.TabIndex = 0;
            // 
            // marksgrit
            // 
            this.marksgrit.AutoGenerateColumns = false;
            this.marksgrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksgrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectNameDataGridViewTextBoxColumn,
            this.totalNumberDataGridViewTextBoxColumn,
            this.obtainedNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.marksgrit.DataSource = this.marksBindingSource;
            this.marksgrit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marksgrit.Location = new System.Drawing.Point(244, 0);
            this.marksgrit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marksgrit.Name = "marksgrit";
            this.marksgrit.RowHeadersWidth = 51;
            this.marksgrit.RowTemplate.Height = 24;
            this.marksgrit.Size = new System.Drawing.Size(356, 366);
            this.marksgrit.TabIndex = 1;
            this.marksgrit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marksgrit_CellContentClick);
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataSource = typeof(StudentMarks.App_data.Marks);
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            // 
            // totalNumberDataGridViewTextBoxColumn
            // 
            this.totalNumberDataGridViewTextBoxColumn.DataPropertyName = "TotalNumber";
            this.totalNumberDataGridViewTextBoxColumn.HeaderText = "TotalNumber";
            this.totalNumberDataGridViewTextBoxColumn.Name = "totalNumberDataGridViewTextBoxColumn";
            // 
            // obtainedNumberDataGridViewTextBoxColumn
            // 
            this.obtainedNumberDataGridViewTextBoxColumn.DataPropertyName = "ObtainedNumber";
            this.obtainedNumberDataGridViewTextBoxColumn.HeaderText = "ObtainedNumber";
            this.obtainedNumberDataGridViewTextBoxColumn.Name = "obtainedNumberDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StudentmarksEntryformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.marksgrit);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentmarksEntryformcs";
            this.Text = "StudentmarksEntryformcs";
            this.Load += new System.EventHandler(this.StudentmarksEntryformcs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksgrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtroll;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView marksgrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtainedNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource marksBindingSource;
    }
}