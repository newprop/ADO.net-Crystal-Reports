using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarks.App_data
{
    internal class Repository
    {

        string conString = $"server = (localdb)\\mssqllocaldb ; attachdbfilename = {Application.StartupPath}\\App_Data\\StudentDb.mdf; trusted_connection= true; ";

        public Repository()
        {
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection con = new SqlConnection(conString))
            {

                var cmd = con.CreateCommand();



                cmd.CommandText = "select * from StudentMastr";

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                con.Open();
                sda.Fill(ds);

                if (ds.Tables.Count > 0)
                {



                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Student student = new Student();
                        student.StudentId = Convert.ToInt32(dr["StudentId"]);
                        student.StudentName = Convert.ToString(dr["StudentName"]);
                        student.Class = dr["Class"].ToString();
                        student.ClassRoll = Convert.ToInt32(dr["ClassRoll"]);

                        students.Add(student);
                    }

                }



            }

            return students;
        }
        public Student GetStudent (int StudentId)
        {

            Student student = new Student();
            using (SqlConnection con = new SqlConnection(conString))
            {
                var cmd = con.CreateCommand();


               
                cmd.CommandText = $"select * from StudentMastr where studentId={StudentId} ; select * from studentsMarks where  studentId={StudentId} ";


                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                sda.Fill(ds);


                if (ds.Tables.Count > 0)
                {

                    var dr = ds.Tables[0].Rows[0];





                    student.StudentId = Convert.ToInt32(dr["StudentId"]);
                    
                    student.StudentName = dr["StudentName"].ToString();
                    student.Class= dr["Class"].ToString();
                    student.ClassRoll = Convert.ToInt32(dr["ClassRoll"]);

                    foreach (DataRow row in ds.Tables[1].Rows)
                    {

                        Marks mark = new Marks();


                        mark.SubjectName = row["SubjectName"].ToString();
                        mark.TotalNumber = Convert.ToDecimal(row["TotalNumber"]);
                        mark.ObtainedNumber = Convert.ToUInt32(row["ObtainedNumber"]);
                       
                        student.Markslist.Add(mark);
                    }



                }

            }
            return student;
        }




        public int SaveStudents(Student student)
        {
            int rowNo = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();

                cmd.Transaction = tran;



                try
                {


                    cmd.CommandText = "select isnull(max(studentId), 0) + 1 as StudentId from StudentMastr ";


                    string studentid = cmd.ExecuteScalar()?.ToString();



                    cmd.CommandText = $"INSERT INTO [dbo].[StudentMastr](StudentId,[StudentName],[Class],[ClassRoll]) VALUES (  {studentid}, '{student.StudentName}', '{student.Class}', '{student.ClassRoll}' )";


                    rowNo = cmd.ExecuteNonQuery();


                    if (rowNo > 0)
                    {

                        foreach (var mark in student.Markslist)
                        {
                            cmd.CommandText = $"INSERT INTO [dbo].[StudentsMarks] ([StudentId] ,[SubjectName] ,[TotalNumber] ,[ObtainedNumber])  VALUES ({studentid} ,'{mark.SubjectName}' , '{mark.TotalNumber}' , '{mark.ObtainedNumber}')";


                            int r1 = cmd.ExecuteNonQuery();
                        }

                    }

                    tran.Commit();
                }
                catch (SqlException e)
                {

                    tran.Rollback();
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            return rowNo;
        }
        public int UpdateStudens(Student student)
        {
            int rowNo = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();

                cmd.Transaction = tran;



                try
                {




                    cmd.CommandText = $"UPDATE [dbo].[StudentMastr]   SET [StudentId] =  '{student.StudentName}', [Class] = '{student.Class}',[ClassRoll] = '{student.ClassRoll}' where StudentId = {student.StudentId}";

                    rowNo = cmd.ExecuteNonQuery();


                    if (rowNo > 0)
                    {
                        cmd.CommandText = $"delete from [dbo].[StudentMarks] where StudentId= {student.StudentId}";


                        if (cmd.ExecuteNonQuery() >= 0)
                        {
                            foreach (var mark in student.Markslist)
                            {
                                cmd.CommandText = $"INSERT INTO [dbo].[StudentMarks] ([StudentId] ,[SubjectName] ,[TotalNumber] ,[ObtainedNumber]])  VALUES ({student.StudentId} ,'{mark.SubjectName}' , '{mark.TotalNumber}' , '{mark.ObtainedNumber}')";


                                cmd.ExecuteNonQuery();
                            }
                        }



                    }

                    tran.Commit();
                }
                catch (SqlException e)
                {

                    tran.Rollback();
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            return rowNo;

        }
        public int DeleteStudent(string StudentId)
        {
            int rowNo = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                var tran = con.BeginTransaction();
                var cmd = con.CreateCommand();

                cmd.Transaction = tran;




                try
                {


                    cmd.CommandText = $"delete from [dbo].[StudentMastr]   where StudentId ={StudentId}";


                    rowNo = cmd.ExecuteNonQuery();

                    tran.Commit();

                }
                catch (SqlException e)
                {
                    tran.Rollback();
                    MessageBox.Show(e.Message);
                    return 0;
                }
            }
            return rowNo;
        }
        internal List<StudentsMarks> GetReportData()
        {
            List<StudentsMarks> students = new List<StudentsMarks>();

            using (SqlConnection con = new SqlConnection(conString))
            {
                var cmd = con.CreateCommand();


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * FROM [vwStudentsMarks]";



                DataTable dt = new DataTable();
                con.Open();



                dt.Load(cmd.ExecuteReader());




                foreach (DataRow dr in dt.Rows)
                {
                    StudentsMarks student= new StudentsMarks();
                    student.StudentId = Convert.ToInt32(dr["StudentId"]);

                    student.StudentName = dr["StudentName"].ToString();
                    student.Class = dr["Class"].ToString();
                    student.ClassRoll = Convert.ToInt32(dr["ClassRoll"]);
                    student.SubjectName = dr["SubjectName"]?.ToString();
                    student.TotalNumber  = Convert.ToUInt32(dr["TotalNumber"]);
                    student.ObtainedNumber = Convert.ToUInt32(dr["ObtainedNumber"]);

                    




                    students.Add(student);
                }



            }

            return students;
        }
    }
}




