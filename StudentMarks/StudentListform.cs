using CrystalDecisions.CrystalReports.Engine;
using StudentMarks.App_data;
using System;
using System.Windows.Forms;

namespace StudentMarks
{
    public partial class StudentListform : Form
    {
        Repository repository = new Repository();
        public StudentListform()
        {
            InitializeComponent();
        }

        void DataLoad()
        {


            this.studentBindingSource.DataSource = repository.GetStudents();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            var id = studentgrit.SelectedRows[0].Cells[0].Value.ToString();


            if (int.Parse(id) > 0)
            {
                StudentmarksEntryformcs form = new StudentmarksEntryformcs();

                form.StudentId = int.Parse(id);


                form.ShowDialog(this);
            }
        }

        private void btnstudentlist_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();


            report.Load($"{Application.StartupPath}\\MyReport\\StudentsReports.rpt");

            if (report.IsLoaded)
            {


                report.SetDataSource(repository.GetReportData());

            }



            ReportviewForm form = new ReportviewForm();

            form.crystalReportViewer.ReportSource = report;



            form.ShowDialog(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
