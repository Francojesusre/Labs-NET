<%@ Page Language="C#" MasterPageFile="~/LabLoginMasterPage.master" AutoEventWireup="true"  CodeFile="Login.aspx.cs" Inherits="Login" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" Runat="Server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
        <asp:Label ID="lblBienvenido" runat="server" Text="¡Bienvenido al Sistema!"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
        <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
        <asp:LinkButton ID="lnkRecordarClave" runat="server"  Text="Olvidé mi Contraseña"></asp:LinkButton>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
</asp:Content>