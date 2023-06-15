using Storelibrary;
using System;
using System.Collections.Generic;
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

        }
        //Department department = new Department();
        
        string res = null;
        protected void Button1_Click(object sender, EventArgs e)
        {
            Storelibrary.Department department = new Storelibrary.Department();
            res = Storelibrary.Department.InsertDepartment(DropDownList1.SelectedValue);
            Label3.Text = res;
        }

        public void getDepartmentID()
        {

        }
    }
}