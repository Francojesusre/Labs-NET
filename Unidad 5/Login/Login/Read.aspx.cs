using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["inputText"] == null)
            {
                Session["inputText"] = "";
            }
            Label1.Text = string.Format("InputText en sesión: '{0}'", Session["inputText"].ToString());

        }
    }
}