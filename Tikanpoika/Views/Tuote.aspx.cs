using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Tikanpoika.Views
{
    public partial class Tuote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Int32 tuoteID;
            tuoteID = (Int32)this.Session["tuoteid"];
            String connStr = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            String cmdText = "SELECT TuoteID, Nimi, Hinta, Veroprosentti FROM Tuote WHERE TuoteID = @Tuoteid";
            SqlCommand cmd1 = new SqlCommand(cmdText, conn);
            cmd1.Parameters.AddWithValue("@Tuoteid", tuoteID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                FormView1.DataSource = reader;
                FormView1.DataBind();
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Yhteyttä tietokantaan ei saatu. Yritä hetken päästä uudelleen.");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}