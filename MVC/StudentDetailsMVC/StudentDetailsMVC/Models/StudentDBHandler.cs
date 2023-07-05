using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace StudentDetailsMVC.Models
{
    public class StudentDBHandler
    {
        SqlConnection con = null;

        public void connection()
        {
            con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=StudentDetails");
        }

        public List<StudentModel> GetStudentList()
        {
            connection();
            List<StudentModel> list = new List<StudentModel>();
            string query = "select * from Student_List";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new StudentModel
                {
                    id = Convert.ToInt32(dr["id"]),
                    Name = Convert.ToString(dr["Name"]),
                    Age = Convert.ToInt32(dr["Age"]),
                    Mobile = Convert.ToString(dr["Mobile"]),
                    Address = Convert.ToString(dr["Address"])
                });
            }
            return list;
        }

        public bool InsertStudentDetails(StudentModel ilist)
        {
            connection();
            string query = "insert into Student_List values('"+ilist.Name+"','"+ilist.Age+"','"+ilist.Mobile+"','"+ilist.Address+"')";

            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i=command.ExecuteNonQuery();
            con.Close();

            if(i >= 1)
            {
                return true;
            }
            else { return false; }
        }

        public bool UpdateStudentDetails(StudentModel ilist)
        {
            connection();
            string query = "update Student_List set Name = '"+ilist.Name+"',Age = '"+ilist.Age+"',Mobile = '"+ilist.Mobile+"',Address = '"+ilist.Address+"' where ID = '"+ilist.id+"'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i=command.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DeleteStudentDetails(StudentModel ilist)
        {
            connection();
            string query = "delete from Student_List where ID = '" + ilist.id + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i=command.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}