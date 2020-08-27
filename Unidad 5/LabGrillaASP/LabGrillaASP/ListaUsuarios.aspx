<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="LabGrillaASP.ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="odsUsuarios" OnRowCommand="grdUsuarios_RowCommand" ShowFooter="True">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" />
                <asp:TemplateField HeaderText="ID" SortExpression="ID">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="btnInsertar" runat="server" CommandName="Insertar" Text="Insertar" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre" SortExpression="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Nombre") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Apellido" SortExpression="Apellido">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Apellido") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Apellido") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email" SortExpression="Email">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="NombreUsuario" SortExpression="NombreUsuario">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("NombreUsuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Clave" SortExpression="Clave">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Clave") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("Clave") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Habilitado" SortExpression="Habilitado">
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Habilitado") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:CheckBox ID="chkHabilitado" runat="server" Text="Habilitado" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("Habilitado") %>' Enabled="false" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="ListaUsuarios.aspx?ID={0}" Text="Editar" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsUsuarios" runat="server" DataObjectTypeName="Negocio.Usuario" DeleteMethod="BorrarUsuario" InsertMethod="AgregarUsuario" SelectMethod="GetAll" TypeName="Negocio.ManagerUsuarios" UpdateMethod="ActualizarUsuario"></asp:ObjectDataSource>
    <table border="1" id="Tabla">
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="lblAccion" runat="server" Text="Usuario"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Apellido:</td>
                <td>
                    <asp:TextBox ID="txtApellido0" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Nombre:</td>
                
                <td>
                    &nbsp;<asp:TextBox ID="txtNombre0" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail0" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Habilitado:</td>
                <td>
                    <asp:CheckBox ID="ckbHabilitado" runat="server" Text=" " />
                </td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Nombre de Usuario:</td>
                <td>
                    <asp:TextBox ID="txtNombreUsuario0" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Clave:</td>
                <td>
                    <asp:TextBox ID="txtClave0" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="right">
                    Confirmar Clave:</td>
                <td>
                    <asp:TextBox ID="txtConfirmarClave" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 150px" align="center">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" /></td>
                <td align="center">
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" /></td>
            </tr>
        </table>

    </form>
</body>
</html>
