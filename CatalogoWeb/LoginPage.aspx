<%@ Page Title="Inicio de sesión" Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="CatalogoWeb.Login" %>

<!DOCTYPE html>

<html lang="es">
    <head runat="server">
        <title>Inicio de sesión</title>
         <link rel="stylesheet" href="LoginRegister.css">
        <link href="https://fonts.googleapis.com/css?family=Ubuntu" rel="stylesheet">
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" href="path/to/font-awesome/css/font-awesome.min.css">
        
    </head>
    <body>
         <form class="main" runat="server" >
            <p class="sign" align="center">Login</p>

             <asp:TextBox runat="server" CssClass="un" aling="center" placeholder="Email" ID="txtEmail"></asp:TextBox> 
             <a style="position:absolute"> 
                 <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio" ForeColor="Red" ControlToValidate="txtEmail" runat="server" />
             </a>    

             <asp:TextBox runat="server" CssClass="pass" TextMode="Password" aling="center" placeholder="Password" ID="txtPass"></asp:TextBox> 
            
             <a style="position:absolute"> 
                <asp:RequiredFieldValidator ErrorMessage="*Campo Obligatorio" ForeColor="Red" ControlToValidate="txtPass" runat="server" />
                <asp:Label Text="Usuario o Contraseña Incorrectos!" ID="lblError" Visible ="false" runat="server" ForeColor="Red" Font-Bold="true" />
             </a>

             <asp:Button Text="Entrar" ID="btnEntrar" CssClass="submit" runat="server" OnClick="btnEntrar_Click" />

                  <a href="Default.aspx">
                  <p class="forgot" align="center" >Home</p>

              </a>                
        </form>
    


    </body>


</html>

