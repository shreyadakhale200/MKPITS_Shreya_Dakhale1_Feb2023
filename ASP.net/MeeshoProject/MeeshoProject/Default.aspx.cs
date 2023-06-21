using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MeeshoProject
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meeshodb");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                da = new SqlDataAdapter("select * from meeshoStore", con);
                ds = new DataSet();
                da.Fill(ds, "meeshoStore");
                DataList1.DataSource = ds.Tables["meeshoStore"].DefaultView;
                DataList1.DataBind();

            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}