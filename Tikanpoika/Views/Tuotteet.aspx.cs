using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tikanpoika.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 tuoteID;
            tuoteID = (Int32) GridView1.SelectedValue;
            this.Session["tuoteid"] = tuoteID;
            Response.Redirect("Tuote.aspx");
        }
    }
}