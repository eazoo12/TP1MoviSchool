using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMoviSchool
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["ID_TIPOUSU"] == null)
            {
                Response.Redirect("Logueo.aspx");
                
            }
            
        }

        protected void btnCerrar2_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");
        }
    }
}