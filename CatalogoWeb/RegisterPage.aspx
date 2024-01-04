<%@ Page Title="Registarse" Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="CatalogoWeb.RegisterPage" %>

<!DOCTYPE html>

<html lang="es">

    <head runat="server">
        <title>Registrarse</title>
         <link rel="stylesheet" href="LoginRegister.css">
        <link href="https://fonts.googleapis.com/css?family=Ubuntu" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="path/to/font-awesome/css/font-awesome.min.css">
        
    </head>
    <body>
         <asp:Label ID="labelError" Visible ="false" runat="server" ForeColor="Red" Font-Bold="true" />
            <form class="mainR" runat="server">
                <p class="sign" align="center">Registrarse</p>
                
                 <asp:TextBox runat="server" CssClass="mail" aling="center" placeholder="Correo" ID="txtEmail"></asp:TextBox>
                <a style="position:absolute"> 
                    <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio" ForeColor="Red" Display="Dynamic" ControlToValidate="txtEmail" runat="server" />
                </a>
                     <asp:TextBox runat="server" CssClass="un" aling="center" placeholder="Username" ID="txtUserR"></asp:TextBox>
                <a style="position:absolute"> 
                     <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio"  BorderStyle="None" ForeColor="Red" Display="Dynamic" ControlToValidate="txtUserR" runat="server" />
                </a>


                 <asp:TextBox runat="server" CssClass="un" aling="center" TextMode="MultiLine" placeholder="Direccion" ID="txtDireccion"></asp:TextBox>
                <a style="position:absolute"> 
                     <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio"  BorderStyle="None" ForeColor="Red" Display="Dynamic" ControlToValidate="txtUserR" runat="server" />
                </a>
                 <asp:TextBox runat="server" CssClass="un" aling="center" placeholder="Telefono" ID="txtTelefono"></asp:TextBox>
                <a style="position:absolute"> 
                     <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio"  BorderStyle="None" ForeColor="Red" Display="Dynamic" ControlToValidate="txtUserR" runat="server" />
                </a>



                     <asp:TextBox runat="server" CssClass="pass" TextMode="Password" aling="center" placeholder="Password" ID="txtPassR"></asp:TextBox> 
                <a style="position:absolute"> 
                     <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio" ForeColor="Red" Display="Dynamic" ControlToValidate="txtPassR" runat="server" />
                </a>

             <asp:Button Text="Entrar" ID="btnRegister" CssClass="submit" runat="server" OnClick="btnRegister_Click" />

                  <a href="Default.aspx">
                  <p class="forgot" align="center">Home</p>
                      <br />

                  </a>                
            </form>
                       
    </body>


</html>