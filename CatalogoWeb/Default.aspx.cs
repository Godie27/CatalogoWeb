using CatalogoWeb.ReferenceWS;
using Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CatalogoWeb
{


    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.labelMENSAJE.Text = " DEBES TENER UNA CUENTA O INICIA SESION PARA COMPRAR!";
                this.divMENSAJE.Visible = true;
                this.divESPACIO.Visible = true;
                this.lblFinalizarCompra.Visible = false; 

            }
            else 
            {

                if (Request.QueryString["user"] != null)
                {
                    this.divESPACIO.Visible = true;

                    //this.label1.Text = Request.QueryString["user"];

                    this.labelMENSAJE.Visible = false;
                    this.divMENSAJE.Visible = false; 
                }
                else
                {
                    //if (myGridView.Rows.Count > 0)
                    //{
                    //    // Eliminar todas las filas existentes en el DataGridView
                    //    myGridView.DataSource = null;
                    //    myGridView.DataBind();
                    //}

                    this.divESPACIO.Visible = false;
                }
                //this.labelPRUEBA.Visible = true; 
                ////this.labelPRUEBA.Text = Request.QueryString["user"];
                //this.label1.Visible = true; ; 
            }




        }

        int cantIphone = 0;
        int cantPc = 0;
        int cantram = 0;
        int cantMonitor = 0;
        int cantteclado = 0;
        int cantwebcam = 0;


        protected void btnIphone_Click(object sender, EventArgs e)
        {

            if (Request.QueryString["user"] == null)
            {
                //no realiza ninguna accion y envia al postback 
            }
            else
            {
                //quiere decir que el usuario ya esta logueado 

                if (this.txtCantIphone.Text.Substring(0, 1) == "-")
                {
                    cantIphone = 0;
                    this.txtCantIphone.Text = "0";

                }
                else
                {
                    //Negocios.Propiedades obj = new Negocios.Propiedades();
                    
                    if(this.txtCantIphone.Text != "0")
                    {
                        cantIphone = int.Parse(this.txtCantIphone.Text);

                        ViewState["Iphone"] = cantIphone;

                        Agregado.Visible = true;
                        this.btnFinalizarPago.Visible = true;
                        this.btnIphone.Visible = false;
                        this.txtCantIphone.Visible = false;


                    }else
                    {


                    }

                }
            }

        }

        protected void btnPC_Click(object sender, EventArgs e)
        {

            if (Request.QueryString["user"] == null)
            {
                //no realiza ninguna accion y envia al postback 
            }
            else
            {
                //quiere decir que el usuario ya esta logueado 

                if (this.txtCantPc.Text.Substring(0, 1) == "-")
                {
                    cantPc = 0;
                    this.txtCantPc.Text = "0";
                }
                else
                {

                    if (this.txtCantPc.Text != "0")
                    {
                        cantPc = int.Parse(this.txtCantPc.Text);

                        ViewState["PC"] = cantPc;
                        //Agregado.Visible = true;

                        Agregado1.Visible = true;
                        this.btnFinalizarPago.Visible = true;
                        this.btnPC.Visible = false;
                        this.txtCantPc.Visible = false;


                    }
                    else
                    { }

                }
            }
        }//end pc

        protected void btnRAM_Click(object sender, EventArgs e)
        {

            if (Request.QueryString["user"] == null)
            {
                //no realiza ninguna accion y envia al postback 
            }
            else
            {
                //quiere decir que el usuario ya esta logueado 

                if (this.txtCantRam.Text.Substring(0, 1) == "-")
                {
                    cantram = 0;
                    this.txtCantRam.Text = "0";
                }
                else
                {
                    if (txtCantRam.Text != "0")
                    { 
                        cantram = int.Parse(this.txtCantRam.Text);
                        ViewState["Ram"] = cantram;

                        Agregado2.Visible = true;
                        this.btnFinalizarPago.Visible = true;

                        btnRAM.Visible = false;
                        this.txtCantRam.Visible = false;
                    }
                    else { }

                }
            }
        }//end ram

        protected void btnMonitor_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["user"] == null)
            {
                //no realiza ninguna accion y envia al postback 
            }
            else
            {
                //quiere decir que el usuario ya esta logueado 

                if (this.txtCantMonitor.Text.Substring(0, 1) == "-")
                {
                    cantMonitor = 0;
                }
                else
                {
                    if(txtCantMonitor.Text != "0")
                    {
                        cantMonitor = int.Parse(this.txtCantMonitor.Text);

                        ViewState["Monitor"] = cantMonitor;
                        //Agregado.Visible = true;

                        Agregado3.Visible = true;
                        this.btnFinalizarPago.Visible = true;
                        btnMonitor.Visible = false;
                        this.txtCantMonitor.Visible = false;
                    }
                    else { }
                }
            }
        }

        protected void btnTeclado_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["user"] == null)
            {
                //no realiza ninguna accion y envia al postback 
            }
            else
            {
                //quiere decir que el usuario ya esta logueado 

                if (this.txtCantTeclado.Text.Substring(0, 1) == "-")
                {
                    cantteclado = 0;
                }
                else
                {
                    if(txtCantTeclado.Text != "0")
                    {
                        cantteclado = int.Parse(txtCantTeclado.Text);
                        ViewState["Teclado"] = cantteclado;

                        Agregado4.Visible = true;
                        this.btnFinalizarPago.Visible = true;
                        btnTeclado.Visible = false;
                        this.txtCantTeclado.Visible = false;
                    }
                    else { }

                }
            }
        }

        protected void btnWebcam_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["user"] == null)
            {
                //no realiza ninguna accion y envia al postback 
            }
            else
            {
                //quiere decir que el usuario ya esta logueado 

                if (this.txtCantWebcam.Text.Substring(0, 1) == "-")
                {
                    cantwebcam = 0;
                }
                else
                {
                    if(txtCantWebcam.Text != "0")
                    {
                        cantwebcam = int.Parse(txtCantWebcam.Text);
                        ViewState["Webcam"] = cantwebcam;

                        Agregado5.Visible = true;
                        this.btnFinalizarPago.Visible = true;
                        btnWebcam.Visible = false;
                        this.txtCantMonitor.Visible = false;
                    }
                    else { }

                }
            }
        }

        protected void btnFinalizarPago_Click(object sender, EventArgs e)
        {

            if (ViewState["Iphone"] == null)
            {
                ViewState["Iphone"] = 0;
                this.btnIphone.Visible = false;
                this.txtCantIphone.Visible = false;

            }


            if (ViewState["PC"] == null)
            {
                ViewState["PC"] = 0;

                this.btnPC.Visible = false;
                this.txtCantPc.Visible = false;

            }

            if (ViewState["Ram"] == null)
            {
                ViewState["Ram"] = 0;

                btnRAM.Visible = false;
                this.txtCantRam.Visible = false;

            }

            if (ViewState["Monitor"] == null)
            {
                ViewState["Monitor"] = 0;
                btnMonitor.Visible = false;
                this.txtCantMonitor.Visible = false;

            }

            if (ViewState["Teclado"] == null)
            {
                ViewState["Teclado"] = 0;
                btnTeclado.Visible = false;
                this.txtCantTeclado.Visible = false;


            }
            if (ViewState["Webcam"] == null)
            {
                ViewState["Webcam"] = 0;
                btnWebcam.Visible = false;
                this.txtCantWebcam.Visible = false;

            }

            Negocios.Productos obj = new Negocios.Productos();

            myGridView.DataSource = obj.CrearDT((int)ViewState["Iphone"], (int)ViewState["PC"],
                                    (int)ViewState["Ram"], (int)ViewState["Monitor"],
                                    (int)ViewState["Teclado"], (int)ViewState["Webcam"]);

            myGridView.DataBind();


            this.DIV_TABLA.Visible = true;


            label1.Visible = true;
            txtMontoTotal.Visible = true;
            btnPagar.Visible = true;

            this.divMENSAJE.Visible = false; 


            label1.Text = "Total a Pagar: ";

            txtMontoTotal.Text = "$ " + obj.ObtenerMontoTotal((int)ViewState["Iphone"], (int)ViewState["PC"],
                                    (int)ViewState["Ram"], (int)ViewState["Monitor"],
                                    (int)ViewState["Teclado"], (int)ViewState["Webcam"]);




            this.btnFinalizarPago.Visible = false;

        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {
            //Negocios.Usuario i = new Usuario();
            Negocios.Productos obj = new Productos(); 
            Negocios.Factura o = new Factura();

            ReferenceWS.WSSoapClient i = new ReferenceWS.WSSoapClient();

            string ID = "";
            string total = this.txtMontoTotal.Text;

            List<Articulo> listaArticulos = new List<Articulo>();


            //obtiene el valor del correo que esta arriba a la derecha de la pagina
            Label lblMessageInMaster = Master.FindControl("labelUSERNAME") as Label;

            //3 LISTAS PARA ENVIAR LOS DATOS A JAVA
            ArrayList productos = new ArrayList();
            ArrayList cantidades = new ArrayList();
            ArrayList subtotales = new ArrayList();

            

            try
            {

                foreach (GridViewRow row in myGridView.Rows)
                {
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        string producto = row.Cells[0].Text;
                        string cantidad = row.Cells[1].Text;
                        string subtotal = row.Cells[2].Text;

                        Articulo articulo = new Articulo
                        {
                            nombre_articulo = producto,
                            cantidad = cantidad,
                            subtotal = subtotal
                        };

                        //llena las listas con los datos de la tabla
                        //todas las listas tienen el mismo tamanio entonces los index serian los mismos
                        //no hay un produto sin cantidad o subtotal

                        productos.Add(producto);
                        cantidades.Add(cantidad);
                        subtotales.Add(subtotal); 



                        listaArticulos.Add(articulo);
                    }
                }

                if (this.label1.Text != "")
                {

                    //Obtengo el id del usuario para el foreign key de la base de datos


                    ID = i.ObtenerID_User(lblMessageInMaster.Text);

                }


                total =  obj.ObtenerMontoTotal((int)ViewState["Iphone"], (int)ViewState["PC"],
                                    (int)ViewState["Ram"], (int)ViewState["Monitor"],
                                    (int)ViewState["Teclado"], (int)ViewState["Webcam"]);


                if (total == "0")
                {
                    this.label1.Visible = false;
                    this.txtMontoTotal.Visible = false;
                    this.btnPagar.Visible = false;
                    this.DIV_TABLA.Visible = false;

                    //this.divMENSAJE.Visible = fasle;

                    this.lblFinalizarCompra.Visible = true;

                }
                else { 
                
                
                    Negocios.Compra compra = new Compra
                    {
                        userID = ID,
                        total = total,
                        articulos = listaArticulos.ToArray()
                    };


                    //INGRESA A LA BASE DE DATOS LA INFORMACION DE LA COMPRA
                    //////////////////////////////////////////////////////////
                    bool CompraIngresada = o.AgregarCompra(compra);///////////
                    ///////////////////////////////////////////////////////// 
                
                    if(CompraIngresada)
                    {
                        //FINALMENTE ENVIA UN CORREO AL CLIENTE


                        //convierte los array para usarlos en el web service
                        ArrayOfAnyType arrayOfProductos = new ArrayOfAnyType();
                        arrayOfProductos.AddRange(productos.Cast<object>().ToArray());

                        ArrayOfAnyType arrayOfCantidades = new ArrayOfAnyType();
                        arrayOfCantidades.AddRange(cantidades.Cast<object>().ToArray());


                        ArrayOfAnyType arrayOfSubtotales = new ArrayOfAnyType();
                        arrayOfSubtotales.AddRange(subtotales.Cast<object>().ToArray());



                        bool valido = i.EnviarCorreo(lblMessageInMaster.Text,
                                                    arrayOfProductos, arrayOfCantidades, arrayOfSubtotales, total); 












                            /////////////////////////////////////////////////
                            //DEVUELVE LA PAGINA A COMO ESTABA INICIALMENTE
                            /////////////////////////////////////////////////
                            this.label1.Visible = false; 
                            this.txtMontoTotal.Visible = false;
                            this.btnPagar.Visible = false;
                            this.DIV_TABLA.Visible = false;

                            //this.divMENSAJE.Visible = fasle;
                    
                            this.lblFinalizarCompra.Visible = true;


                            /////////////Mensaje de Agreado//////////
                            this.Agregado.Visible = false;
                            this.Agregado1.Visible = false;
                            this.Agregado2.Visible = false;
                            this.Agregado3.Visible = false;
                            this.Agregado4.Visible = false;
                            this.Agregado5.Visible = false;
                            /////////////////////////////////////////


                            ///////////TEXTBOX CANTIDAD/////////////
                            this.btnIphone.Visible = true;
                            this.txtCantIphone.Visible = true;
                            this.txtCantIphone.Text = "0";


                            this.txtCantPc.Visible = true;
                            this.btnPC.Visible = true;
                            this.txtCantPc.Text = "0";

                            this.btnRAM.Visible = true;
                            this.txtCantRam.Visible = true; 
                            this.txtCantRam.Text = "0";


                            this.btnMonitor.Visible = true;
                            this.txtCantMonitor.Visible = true;
                            this.txtCantMonitor.Text = "0";

                            this.btnTeclado.Visible = true;
                            this.txtCantTeclado.Visible = true;
                            this.txtCantTeclado.Text = "0";

                            this.btnWebcam.Visible = true;
                            this.txtCantWebcam.Visible = true;
                            this.txtCantWebcam.Text = "0";

                        /////////////////////////////////////////
                        //LIMPIA LOS DATOS PARA NO AGREGARLOS A LA TABLA
                            ViewState["Iphone"] = 0;
                            ViewState["PC"] = 0;
                            ViewState["Ram"] = 0;
                            ViewState["Monitor"] = 0;
                            ViewState["Teclado"] = 0;
                            ViewState["Webcam"] = 0;

                    }
                }//end else
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}