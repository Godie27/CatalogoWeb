using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class frmPago : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            ViewState["Iphone"] = null;
            ViewState["PC"] = null;
            ViewState["Ram"] = null;
            ViewState["Monitor"] = null;
            ViewState["Teclado"] = null;
            ViewState["Webcam"] = null;


            Page.Response.RedirectPermanent("Default.aspx");


        }
    }
}