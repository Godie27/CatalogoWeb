using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Negocios.Usuario i = new Negocios.Usuario();

            //i.MyPropLogged = true;

            if (IsPostBack)
            {



            }
            else {
                

                this.labelUSERNAME.Text = Request.QueryString["user"];
                


                if (Request.QueryString["user"] != null)
                {
                    this.labelUSERNAME.Visible = true;
                    this.label1.Visible = true;
                }
                else
                {
                    this.label1.Visible = false;
                }
            }


        }
    }
}