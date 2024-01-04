<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPago.aspx.cs" Inherits="CatalogoWeb.frmPago" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 19px;
        }
        .auto-style1 {
            height: 247px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">


        <asp:GridView ID="myGridView" runat="server" AutoGenerateColumns="False" Height="229px" Width="436px">
            <Columns>
                <asp:TemplateField HeaderText="Productos">
                    <HeaderStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cantidad">
                    <ControlStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Subtotal"></asp:TemplateField>
            </Columns>
        </asp:GridView>

        <asp:Label ID="label1" runat="server" Text="Label"></asp:Label>

        <asp:TextBox ID="txtMontoTotal" runat="server" ReadOnly="true" Font-Bold="True" Font-Size="X-Large" ForeColor="Black"></asp:TextBox>

        <asp:Button ID="btnPagar" runat="server" Text="PAGAR" CssClass="auto-style2" Font-Bold="True" ForeColor="Red" Height="41px" OnClick="btnPagar_Click" Width="181px" ToolTip="Generará una Factura" />


    </form>
</body>
</html>
