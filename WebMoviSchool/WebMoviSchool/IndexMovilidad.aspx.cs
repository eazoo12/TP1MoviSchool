using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMoviSchool
{
    public partial class IndexMovilidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["ID_TIPOUSU"] == null)
            {
                Response.Redirect("Index.aspx");
            }

        }
    }
}