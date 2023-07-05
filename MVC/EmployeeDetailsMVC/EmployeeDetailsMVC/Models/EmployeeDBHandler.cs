using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeDetailsMVC.Models
{
    public class EmployeeDBHandler
    {
        SqlConnection con;

        public void connection()
        {
            con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=EmployeeDetails");
        }

        public List<EmployeeModel> GetListItem()
        {
            connection();

            List<EmployeeModel> list = new List<EmployeeModel>();
            string query = "select * from Employee_List";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new EmployeeModel
                {
                    Id = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Age = Convert.ToInt32(dr["Age"]),
                    Department = Convert.ToString(dr["Department"]),
                    Salary = Convert.ToDecimal(dr["Salary"])
                }) ;
            }
            return list;
        }

        public bool InsertEmployee(EmployeeModel ilist)
        {
            connection();
            string query = "insert into Employee_List values('"+ ilist.Name + "','" + ilist.Age + "','" + ilist.Department + "','" + ilist.Salary + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmployee(EmployeeModel ilist)
        {
            connection();
            string query = "update Employee_List set Name = '" + ilist.Name + "',Age = '" + ilist.Age + "',Department = '" + ilist.Department + "',Salary = '" + ilist.Salary + "' where ID = '"+ilist.Id+"'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;
            }
            else { return false; }
        }

        public bool DeleteEmployee(EmployeeModel ilist)
        {
            connection();
            string query = "delete from Employee_List where ID = '" + ilist.Id + "'";
            SqlCommand command = new SqlCommand(query,con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
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