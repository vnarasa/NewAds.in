using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AzureDeploySample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            //SqlDataAdapter da = new SqlDataAdapter("select * from TestConnection", conn);
            //System.Data.DataTable dt = new System.Data.DataTable();
            //da.Fill(dt);

            //gvData.DataSource = dt;
            //gvData.DataBind();
        }
    }
}