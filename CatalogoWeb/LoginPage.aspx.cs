using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class Login : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //Negocios.Usuario obj = new Negocios.Usuario();

                ReferenceWS.WSSoapClient obj = new ReferenceWS.WSSoapClient();

                string email = this.txtEmail.Text;
                string pass = this.txtPass.Text;

                string resultado = obj.ValidacionUsuario(email,pass);

                if (resultado.Equals("usuario existe"))
                {
                    this.lblError.Visible = false;
                    Page.Response.RedirectPermanent("Default.aspx?user=" +email);
                }
                else
                {
                    this.txtEmail.Text = "";
                    this.txtPass.Text = "";
                    this.lblError.Visible = true;
                }



            }




        }
    }
}