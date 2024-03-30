using StudentMarks.App_data;
using System;
using System.Windows.Forms;

namespace StudentMarks
{
    public partial class StudentmarksEntryformcs : Form
    {

        Repository repository = new Repository();
        public int StudentId { get; set; } = 0;
        public StudentmarksEntryformcs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudentmarksEntryformcs_Load(object sender, EventArgs e)
        {

            ResetForm();
            LoadInitData();
        }
        void LoadInitData()
        {
            if (StudentId > 0)
            {
                var student = repository.GetStudent(StudentId);

                txtId.Text = student.StudentId.ToString();

                txtclass.Text = student.Class;
                txtName.Text = student.StudentName;
                txtroll.Text = student.ClassRoll.ToString();


                marksBindingSource.DataSource = student.Markslist;



            }
        }
        void ResetForm()
        {
            txtId.Text = null;

            txtName.Text = null;
            txtclass.Text = null;
            txtroll.Text = null;
            marksgrit.Rows.Clear();

            marksBindingSource.DataSource = null;

            txtName.Focus();


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                Student student = new Student();

                if (txtId.Text.Length > 0)
                    student.StudentId = Convert.ToInt32(txtId.Text);


                student.Class = txtclass.Text;
                student.StudentName = txtName.Text;
                student.ClassRoll = Convert.ToInt32(txtroll.Text);





                foreach (DataGridViewRow mark in marksgrit.Rows)
                {

                    if (mark.IsNewRow) continue;

                    Marks marks = new Marks();

                    marks.SubjectName = mark.Cells[0].Value.ToString();
                    marks.TotalNumber = Convert.ToUInt32(mark.Cells[1].Value);
                    marks.ObtainedNumber = Convert.ToUInt32(mark.Cells[2].Value);
                    student.Markslist.Add(marks);
                }

                if (txtId.Text.Length > 0)
                {

                    int rw = repository.SaveStudents(student);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                    }
                }
                else
                {
                    int rw = repository.SaveStudents(student);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                    }
                }


                ResetForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {

                var dialog = MessageBox.Show("Delete record", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    int rw = repository.DeleteStudent(txtId.Text);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data deleted successfully");
                    }
                }




            }
        }

        private void gridItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            try
            {

                Student student = new Student();

                if (txtId.Text.Length > 0)
                    student.StudentId = Convert.ToInt32(txtId.Text);


                student.Class = txtclass.Text;
                student.StudentName = txtName.Text;
                student.ClassRoll = Convert.ToInt32(txtroll.Text);





                foreach (DataGridViewRow mark in marksgrit.Rows)
                {

                    if (mark.IsNewRow) continue;

                    Marks marks = new Marks();

                    marks.SubjectName = mark.Cells[0].Value.ToString();
                    marks.TotalNumber = Convert.ToUInt32(mark.Cells[1].Value);
                    marks.ObtainedNumber = Convert.ToUInt32(mark.Cells[2].Value);
                    student.Markslist.Add(marks);
                }

                if (txtId.Text.Length > 0)
                {

                    int rw = repository.SaveStudents(student);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data updated successfully");
                    }
                }
                else
                {
                    int rw = repository.SaveStudents(student);


                    if (rw > 0)
                    {
                        MessageBox.Show("Data saved successfully");
                    }
                }


                ResetForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void marksgrit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}























