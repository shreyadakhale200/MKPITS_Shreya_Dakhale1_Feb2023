using Storelibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace StoreDLL
{
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayDepartmentid();
            }

        }
        //Department department = new Department();
        
        string res = null;
        protected void Button1_Click(object sender, EventArgs e)
        {
            displayDepartmentid();
            Storelibrary.Department department = new Storelibrary.Department();
            res = Storelibrary.Department.InsertDepartment(DropDownList1.SelectedValue);
            Label3.Text = res;
         
        }

        public void getDepartmentID()
        {
            int res = Convert.ToInt32(Storelibrary.Department.getDepartmentID());
            if (Convert.ToInt32(TextBox1.Text) > res)
            {
                Label3.Text = "value does not exist";
            }
        }

        public void displayDepartmentid()
        {
            int res = Convert.ToInt32(Storelibrary.Department.getDepartmentID());
            res = res + 1;
            TextBox1.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button3.Enabled = true;
            Button4.Enabled = true;
            TextBox1.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text == "")
            {
                Label3.Text = "department id is empty";
            }
            else
            {
                res = Storelibrary.Department.updateDepartment(DropDownList1.SelectedValue, Convert.ToInt32(TextBox1.Text));
                Label3.Text = res.ToString();
                //getDepartmentID();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label3.Text = "department id is empty";
            }
            else
            {
                res = Storelibrary.Department.deleteDepartment(Convert.ToInt32(TextBox1.Text));
                Label3.Text = res;
                //getDepartmentID();
            }
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = Storelibrary.Department.SearchDepartment(Convert.ToInt32(TextBox1.Text));
            if (ds.Tables[0].Rows.Count > 0)
            {
                DropDownList1.SelectedValue = ds.Tables["Department_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label3.Text = "no record exist";
            }
        }
    }
}