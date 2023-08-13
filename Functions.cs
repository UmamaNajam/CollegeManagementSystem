using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace WebApplication2
{
    class Functions
    {
        private SqlConnection Con = new SqlCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //Student
        public int LoginStudent(Student s)
        {
            
            Con.Open();
            cmd.Connection=Con;
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "slogin";
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = s.username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = s.password;
            cmd.Parameters.Add("@status", SqlDbType.Int);
            cmd.Parameters["@status"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = (int)cmd.Parameters["@status"].Value;
            Con.Close();
            return count;
        }
        public int SignupStudent(Student s,StudentInfo s2)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ssignup";
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = s.username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = s.password;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = s2.FName;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = s2.LName;
            cmd.Parameters.Add("@CNIC", SqlDbType.Char).Value = s2.CNIC;
            cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = s2.DOB;
            cmd.Parameters.Add("@PhoneNo", SqlDbType.Char).Value = s2.PhoneNo;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = s2.Address;
            cmd.Parameters.Add("@batch", SqlDbType.Int).Value = s2.Batch;

            int count=Convert.ToInt32(cmd.ExecuteNonQuery());
            
            Con.Close();
            return count;
        }
        //Faculty
        public int LoginFaculty(facultyLogin f)
        {

            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "flogin";
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = f.username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = f.password;
            cmd.Parameters.Add("@status", SqlDbType.Int);
            cmd.Parameters["@status"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = (int)cmd.Parameters["@status"].Value;
            Con.Close();
            return count;
        }

        public int SignupFaculty(facultyLogin s, Faculty s2)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "fsignup";
            cmd.Parameters.Add("@username", SqlDbType.Char).Value = s.username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = s.password;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar).Value = s2.FName;
            cmd.Parameters.Add("@LName", SqlDbType.VarChar).Value = s2.LName;
            cmd.Parameters.Add("@CNIC", SqlDbType.Char).Value = s2.CNIC;
            cmd.Parameters.Add("@JoinDate", SqlDbType.Date).Value = s2.JoinDate;
            cmd.Parameters.Add("@PhoneNo", SqlDbType.Char).Value = s2.PhoneNo;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = s2.Address;
            
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());

            Con.Close();
            return count;
        }
        //Admin
        public int LoginAdmin(adminLogin a)
        {

            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "alogin";
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = a.username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = a.password;
            cmd.Parameters.Add("@status", SqlDbType.Int);
            cmd.Parameters["@status"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = (int)cmd.Parameters["@status"].Value;
            Con.Close();
            return count;
        }
        //Student Info Display for Student
        public DataSet StudentInfoForStudent(string A)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sinfos";
            cmd.Parameters.Add("@RN", SqlDbType.Char,8).Value = A;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            Con.Close();
            return ds;

        }
        public DataSet FacultyInfoForFaculty(string A)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "finfof";
            cmd.Parameters.Add("@id", SqlDbType.VarChar,12).Value = A;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
            Con.Close();
            return ds;

        }
        public DataSet  AdminInfoForAdmin(string A)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ainfoa";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 12).Value = A;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Con.Close();
            return ds;

        }
        public int feedback(string rn,string fname, string lname, string slot, string year, string course, string satis, string imp)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Feedback";
            cmd.Parameters.Add("@rn", SqlDbType.Char, 8).Value = rn;
            cmd.Parameters.Add("@fname", SqlDbType.VarChar, 50).Value = fname;
            cmd.Parameters.Add("@lname", SqlDbType.VarChar, 50).Value = lname;
            cmd.Parameters.Add("@slot", SqlDbType.VarChar, 10).Value = slot;
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 10).Value = year;
            cmd.Parameters.Add("@course", SqlDbType.VarChar, 30).Value = course;
            cmd.Parameters.Add("@sat", SqlDbType.VarChar, 3).Value = satis;
            cmd.Parameters.Add("@imp", SqlDbType.VarChar, 150).Value = imp;

            
            int count =  Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public DataSet facinfostu(string fname)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "finfos";
            cmd.Parameters.Add("@Fname", SqlDbType.VarChar, 50).Value = fname;
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            
            Con.Close();
            return ds;
        }
        public DataSet admininfoall()
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ainfo";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            Con.Close();
            return ds;
        }
        public int CalcFee(string uname, string a)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CalcFee";
            cmd.Parameters.Add("@roll", SqlDbType.Char,8).Value = uname;
            cmd.Parameters.Add("@yearid", SqlDbType.VarChar, 20).Value = a;
            cmd.Parameters.Add("@totalFee", SqlDbType.Int);
            cmd.Parameters["@totalFee"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int count = (int)cmd.Parameters["@totalFee"].Value;
            Con.Close();
            return count;
        }
        public DataSet CheckFee(string uname, string a)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "checkstat";
            cmd.Parameters.Add("@roll", SqlDbType.Char, 8).Value = uname;
            cmd.Parameters.Add("@yearid", SqlDbType.VarChar, 20).Value = a;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public int Enroll(string rn, string year, string course)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "enroll";
            cmd.Parameters.Add("@rollNo", SqlDbType.Char, 8).Value = rn;
            cmd.Parameters.Add("@course", SqlDbType.VarChar, 30).Value = course;
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 20).Value = year;
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int Grade(string rn, string course, string year, float gpa)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Grade";
            cmd.Parameters.Add("@RollNo", SqlDbType.Char, 8).Value = rn;
            cmd.Parameters.Add("@course", SqlDbType.VarChar, 30).Value = course;
            cmd.Parameters.Add("@yearname", SqlDbType.VarChar, 20).Value = year;
            cmd.Parameters.Add("@gpa", SqlDbType.Float).Value = gpa;

            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int updatePassS(string rn, string pass)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "updatePassS";
            cmd.Parameters.Add("@RollNo", SqlDbType.Char, 8).Value = rn;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 12).Value =pass;

            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int updatePassF(string rn, string pass)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "updatePassF";
            cmd.Parameters.Add("@RollNo", SqlDbType.VarChar, (20)).Value = rn;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 12).Value = pass;

            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int updatePassA(string rn, string pass)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "updatePassA";
            cmd.Parameters.Add("@RollNo", SqlDbType.VarChar, (20)).Value = rn;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar, 12).Value = pass;

            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int Dropcourse(string rn ,string slot, string year, string course)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dropCourse";
            cmd.Parameters.Add("@rn", SqlDbType.Char, 8).Value = rn;
            
            cmd.Parameters.Add("@y", SqlDbType.VarChar, 20).Value = year;
            cmd.Parameters.Add("@course", SqlDbType.VarChar, 20).Value = course;
            cmd.Parameters.Add("@slotName", SqlDbType.VarChar, 20).Value = slot;
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int InfoSection(string rn,string slot, string year, string course)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sectionInfor";
            
            cmd.Parameters.Add("@y", SqlDbType.Char, 20).Value = year;
            cmd.Parameters.Add("@course", SqlDbType.VarChar, 30).Value = course;
            cmd.Parameters.Add("@slotName", SqlDbType.VarChar, 20).Value = slot;
            cmd.Parameters.Add("@rn", SqlDbType.VarChar, 20).Value = rn;
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int Payment(string rn, string year)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "paid";
            cmd.Parameters.Add("@roll", SqlDbType.VarChar, 30).Value = rn;
            cmd.Parameters.Add("@y", SqlDbType.Char, 20).Value = year;
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int ASFee(string cid, int amount)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CFee";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = cid;
            cmd.Parameters.Add("@fee", SqlDbType.Int).Value = amount;
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int AsTeacherS(string rn, string course, string year, string slot)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InTeacher";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 12).Value = rn;
            cmd.Parameters.Add("@cid", SqlDbType.VarChar, 20).Value = course;
            cmd.Parameters.Add("@year", SqlDbType.VarChar, 10).Value = year;
           
            cmd.Parameters.Add("@slot", SqlDbType.VarChar,20).Value = slot;

            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
        public int ACourse(string id, string course)
        {
            Con.Open();
            cmd.Connection = Con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InCourse";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 10).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = course;
            int count = Convert.ToInt32(cmd.ExecuteNonQuery());
            Con.Close();
            return count;

        }
    }
}