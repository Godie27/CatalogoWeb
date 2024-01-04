using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{
    public partial class RegisterPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //Negocios.Usuario user = new Negocios.Usuario();
                ReferenceWS.WSSoapClient user = new ReferenceWS.WSSoapClient(); 

                string valido = user.AgregarUsuario(txtEmail.Text, txtUserR.Text, txtDireccion.Text , txtTelefono.Text, txtPassR.Text);

                if(valido.Equals("valido"))
                {
                    Page.Response.Redirect("~/Default.aspx?user=" + txtUserR.Text);

                }
                else
                {
                    this.labelError.Visible = true;
                    this.labelError.Text = "El Usuario ya tiene una cuenta asociada al correo Electronico. Debe ir al Login";
                    this.txtEmail.Text = "";
                    this.txtUserR.Text = "";
                    this.txtPassR.Text = "";
                    this.txtDireccion.Text = "";
                    this.txtTelefono.Text = ""; 
                }


                         
            }
        }
    }
}