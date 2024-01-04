<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb._Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        document.addEventListener("DOMContentLoaded", function () {
            var closeButton = document.querySelector(".con-hover");

            closeButton.addEventListener("click", function () {
                var lblFinalizarCompra = document.getElementById('<%= lblFinalizarCompra.ClientID %>');
                lblFinalizarCompra.style.display = "none";
            });
        });
    </script>
                   
    <div runat="server" id="divESPACIO" visible="false">
        <br />
        <br />
        <br />
    </div>
    <asp:Button Text="Finalizar Pago >>" ID="btnFinalizarPago" Visible="false" BorderColor="WhiteSmoke" BorderWidth="1px" Font-Bold="true" Font-Size="Large" ForeColor="Black" BackColor="LimeGreen" runat="server" Height="47px" OnClick="btnFinalizarPago_Click" style="margin-left: 761px" />
   
     <div runat="server" visible="false" id="DIV_TABLA">


    <asp:GridView ID="myGridView" runat="server" AutoGenerateColumns="False" Height="229px" Width="436px" HeaderStyle-HorizontalAlign="Center" HeaderStyle-VerticalAlign="Middle" HeaderStyle-ForeColor="Black" Font-Bold="True">
        <Columns>
            <asp:BoundField DataField="Producto" ConvertEmptyStringToNull="true" HeaderText="Productos" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Cantidad" ConvertEmptyStringToNull="true" HeaderText="Cantidad" ItemStyle-HorizontalAlign="Center" />
            <asp:BoundField DataField="Precio" ConvertEmptyStringToNull="true" HeaderText="Subtotal" ItemStyle-HorizontalAlign="Center" />
        </Columns>
    </asp:GridView>


         <asp:Label ID="label1" runat="server" Visible="false" Font-Bold="true" Text=""></asp:Label>

        <asp:TextBox ID="txtMontoTotal" runat="server" ReadOnly="true" Visible="false" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" style="margin-left: 45px"></asp:TextBox>

        <asp:Button ID="btnPagar" runat="server" Visible="false" Text="PAGAR" CssClass="auto-style2" Font-Bold="True" ForeColor="#009900" Height="41px" Width="181px" ToolTip="Generará una Factura" style="margin-left: 158px" OnClick="btnPagar_Click" />


    </div>
        
        <%--LABEL MENSAJE DE QUE DEBE REGISTRARSE--%>
         <div runat="server" id="divMENSAJE" style="position:initial; width:90%; display:flex; align-items:center; height:fit-content; background-color:#FF6347;" visible="false" >
            <asp:Label ID="labelMENSAJE" runat="server" Visible="true" ForeColor="White" Font-Size="Large" Font-Bold="true" Text=""></asp:Label>
             
         </div>


         <%--LABEL COMPRA FINALIZADA--%> 
             <asp:Label runat="server" Visible="false" ID="lblFinalizarCompra" Font-Bold="True" BackColor="#33cc33" BorderWidth="2px" BorderStyle="Solid" BorderColor="#cccccc"  ForeColor="Black" Font-Size="X-Large" Font-Names="Arial" Height="44px" Width="1000px" style="margin-top: 20px"> Compra Finalizada. Muchas Gracias!
                 &nbsp&nbsp&nbsp
                 <span class="con-hover" style="height:20px ; width:20px" >&times;</span>
             </asp:Label>



    <%-- PPRIMERA LINEA DE PRODUCTOS --%>
    <div class="row" runat="server" style="height: auto">
        <div class="col-md-4">
            <h2>IPHONE 14 PRO MAX</h2>
            
                
            <a class="col-md-3" style="width:fit-content; height: auto;">
                <img src="Images/Iphone.jpg" alt="" width="100" height="100" />
                <asp:Label Text="$990,00 US" runat="server" Font-Size="Larger" ForeColor="Red" Font-Bold="True" Width="164px" Height="30px" style="margin-left: 40px"/>

            </a>        
             <p style="margin-top:150px; width: 343px;">
                Pantalla: 6.1", 1170 x 2532 pixels,Procesador: Apple A15 Bionic,RAM: 6GB,Almacenamiento:256GB,Cámara: Dual, 12MP+12MP,OS: iOS 16,
            </p>


            <p style="width: 360px">          
                    <asp:TextBox runat="server" Visible="true" TextMode="Number" ID="txtCantIphone" BackColor="#ffff99" Font-Bold="true" Font-Size="X-Large" ForeColor="Red" Text="0" Height="38px" Width="50px" style="margin-left: 0px" />  
                    <asp:Button Text="Añadir al Carrito" runat="server" ID="btnIphone" Height="37px" BackColor="Yellow" BorderStyle="None" BorderWidth="0" Font-Size="Large" Font-Bold="true" Width="173px" OnClick="btnIphone_Click" style="margin-left: 0px" />
                                                    
                    <asp:Label Text ="   AGREGADO!" runat="server" Visible="false" ID="Agregado" Font-Bold="true"  ForeColor="LimeGreen" Font-Names="Arial">   Agregado!
                            <span class="closebtn">&radic;</span>
                    </asp:Label>
            </p>

        </div>
        
        <div class="col-md-4"">
            <h2>PC GAMING</h2>

            <a class="col-md-3" style="width:fit-content; height: auto;">
                <img src="Images/PCGAMING.jpg" alt="" width="100" height="100" />
                <asp:Label Text="$2000,00 US" runat="server" Font-Size="Larger" ForeColor="Red" Font-Bold="True" Width="164px" Height="30px" style="margin-left: 40px" />

            </a>
            <p style="margin-top:150px; width: 373px;">
                CPU: Intel Core i9 de 10ª generaciónGráfica: NVDIA GeForce RTX 3090RAM: 16GBAlmacenamiento: 1TB HDD + 2TB SSD
            </p>
            <p style="width: 331px" >

                    <asp:TextBox runat="server" Visible="true" TextMode="Number"  ID="txtCantPc" BackColor="#ffff99" Font-Bold="true" Font-Size="X-Large" ForeColor="Red" Text="0" Height="38px" Width="50px" style="margin-left: 0px" />  
                    <asp:Button Text="Añadir al Carrito" runat="server" ID="btnPC" Height="37px" BackColor="Yellow" BorderStyle="None" BorderWidth="0" Font-Bold="true" Width="155px" OnClick="btnPC_Click" style="margin-left: 0px"  />

                
                    <asp:Label Text ="   AGREGADO!" Visible="false" runat="server" ID="Agregado1" Font-Bold="true"  ForeColor="LimeGreen" Font-Names="Arial">   Agregado!
                            <span class="closebtn" >&radic;</span>
                    </asp:Label>                
            </p>
        </div>

        <div class="col-md-4"">
            <h2>TIMETEC RAM</h2>
              <a class="col-md-3" style="width:fit-content ; height: auto;">
                <img src="Images/RAM.jpg" alt="" width="140" height="70" />
                <asp:Label Text="$39,00 US" runat="server" Font-Size="Larger" ForeColor="Red" Font-Bold="True" Width="138px" Height="30px" style="margin-left: 30px" /></a>

            <p style="margin-top:150px; width: 329px;">
               Timetec 16 GB DDR4 2400 MHz PC4-19200 no ECC sin búfer 1.2 V CL17 2Rx8 de doble rango 260 pines SODIMM portátil, portátil, computadora, memoria RAM módulo actualización (16 GB)
            </p>

                    <asp:TextBox runat="server" TextMode="Number" Visible="true" ID="txtCantRam" BackColor="#ffff99" Font-Bold="true" Font-Size="X-Large" ForeColor="Red" Text="0" Height="38px" Width="50px" style="margin-left: 0px" />  
                    <asp:Button Text="Añadir al Carrito" runat="server" ID="btnRAM" Height="38px" BackColor="Yellow" BorderStyle="None" BorderWidth="0" Font-Bold="true" Width="142px" OnClick="btnRAM_Click" style="margin-left: 0px"  />
                    
                    <asp:Label Text ="   AGREGADO!" Visible="false" runat="server" ID="Agregado2" Font-Bold="true"  ForeColor="LimeGreen" Font-Names="Arial">   Agregado!
                            <span class="closebtn">&radic;</span>
                    </asp:Label>

        </div>  <%--termina ultimo producto de fila 1--%>


    </div>

<%--   SEGUNDA LINEA DE PRODCUTOS --%>
     <div class="row" style="margin-top:auto">
        <div class="col-md-4">
            <h2>MONITOR LG</h2>
            
              <a class="col-md-3" style="width:fit-content; height: auto;">
                <img src="Images/MonitorLG.jpg" alt="" width="120" height="100" />
                <asp:Label Text="$170,00 US" runat="server" Font-Size="Larger" ForeColor="Red" Font-Bold="True" Width="164px" Height="30px" style="margin-left: 40px" />
            </a>
             <p style="margin-top:150px; width: 417px;">
                LG 27GP700-B Ultragear FHD (1920 x 1080) IPS Monitor para juegos con tiempo de respuesta de 1 ms y frecuencia de actualización de 240 Hz,
                NVIDIA G-SYNC compatible con AMD FreeSync Premium, bisel ultrafino, HDMI x2, negro
            </p>
           <p style="width: 327px">
               <asp:TextBox runat="server" TextMode="Number" Visible="true" ID="txtCantMonitor" BackColor="#ffff99" Font-Bold="true" Font-Size="X-Large" ForeColor="Red" Text="0" Height="38px" Width="50px" style="margin-left: 0px" />
                <asp:Button Text="Añadir al Carrito" runat="server" ID="btnMonitor" Height="43px" BackColor="Yellow" BorderStyle="None" BorderWidth="0" Font-Bold="true" Width="153px" OnClick="btnMonitor_Click" style="margin-left: 0px"  />
                    <asp:Label Text ="   AGREGADO!" runat="server" Visible="false" ID="Agregado3" Font-Bold="true"  ForeColor="LimeGreen" Font-Names="Arial">   Agregado!
                            <span class="closebtn">&radic;</span>
                    </asp:Label>           
               
           </p>
        </div>


        <div class="col-md-4" style="height:420px">
            <h2>TECLADO REDRAGON</h2>
             <a class="col-md-3" style="width:fit-content; height: auto;">
                <img src="Images/Teclado.jpg" alt="" width="120" height="100" />
                <asp:Label Text="$39,00 US" runat="server" Font-Size="Larger" ForeColor="Red" Font-Bold="True" Width="164px" Height="30px" style="margin-left: 40px" />
            </a>

            <p style="margin-top:150px; width: 355px; margin-bottom: 30px;">
                Teclas mecánicas con resistencia media, sonido de clic audible y retroalimentación táctil.
                87 teclas estándar libres de conflictos, 12 teclas multimedia y diseño a prueba de salpicaduras.
            </p>
               <asp:TextBox runat="server" Visible="true" TextMode="Number" ID="txtCantTeclado" BackColor="#ffff99" Font-Bold="true" Font-Size="X-Large" ForeColor="Red" Text="0" Height="38px" Width="50px" style="margin-left: 0px" />
                <asp:Button Text="Añadir al Carrito" runat="server" ID="btnTeclado" Height="39px" BackColor="Yellow" BorderStyle="None" BorderWidth="0" Font-Bold="true" Width="155px" OnClick="btnTeclado_Click" style="margin-left: 0px"  />
                     <asp:Label Text ="   AGREGADO!" runat="server" Visible="false" ID="Agregado4" Font-Bold="true"  ForeColor="LimeGreen" Font-Names="Arial">   Agregado!
                            <span class="closebtn">&radic;</span>
                    </asp:Label>           

        </div>
        <div class="col-md-4" style="height:420px">
            <h2>WEBCAM LOGITECH BRIO</h2>

             <a class="col-md-3" style="width:fit-content; height: auto;">
                <img src="Images/WEBCAM.jpg" alt="" width="120" height="100" />
                <asp:Label Text="$145,00 US" runat="server" Font-Size="Larger" ForeColor="Red" Font-Bold="True" Width="164px" Height="30px" style="margin-left: 40px" />
            </a>
             <p style="margin-top:150px; width: 415px;">
                Resolución Ultra 4K HD: 4 veces la resolución de una cámara web HD típica; luce mejor y disfruta de una experiencia de video profesional dondequiera que estés con zoom HD 5x.    
            </p>
           <p style="width: 306px; margin-top: 26px">
               <asp:TextBox runat="server" Visible="true" TextMode="Number" ID="txtCantWebcam" BackColor="#ffff99" Font-Bold="true" Font-Size="X-Large" ForeColor="Red" Text="0" Height="38px" Width="50px" style="margin-left: 0px" />
                <asp:Button Text="Añadir al Carrito" runat="server" ID="btnWebcam" Height="38px" BackColor="Yellow" BorderStyle="None" BorderWidth="0" Font-Bold="true" Width="150px" OnClick="btnWebcam_Click" style="margin-left: 0px"  />
                    <asp:Label Text ="   AGREGADO!" runat="server" Visible="false" ID="Agregado5" Font-Bold="true"  ForeColor="LimeGreen" Font-Names="Arial">   Agregado!
                            <span class="closebtn">&radic;</span>
                    </asp:Label>                                  
           </p>
        </div>
    </div>



</asp:Content>
