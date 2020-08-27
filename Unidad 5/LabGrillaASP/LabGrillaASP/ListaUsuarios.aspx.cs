using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabGrillaASP
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PaginaEnEstadoEdicion())
            {
                CargarDatosUsuario(int.Parse(Request.QueryString["ID"]));
                lblAccion.Text = "Editar Usuario: " + Request.QueryString["ID"];
            }
            else
            {
                lblAccion.Text = "Agregar Nuevo Usuario";
            }
            
        }

        private bool PaginaEnEstadoEdicion()
        {
            if (Request.QueryString["ID"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CargarDatosUsuario(int ID)
        {
            Usuario usuario = new ManagerUsuarios().GetOne(ID);
            txtNombre0.Text = usuario.Nombre;
            txtApellido0.Text = usuario.Apellido;
            txtEmail0.Text = usuario.Email;
            txtClave0.Text = usuario.Clave;
            txtNombreUsuario0.Text = usuario.NombreUsuario;
            ckbHabilitado.Checked = usuario.Habilitado;
            // 1 - Obtener los datos del usuario en cuestión
            // 2 - Cargar en los controles de la tabla los datos del usuario obtenido
        }


        protected void grdUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Verificarmos que se ejecute lo siguiente solamente cuando lo produce
            //a este evento el botón Insertar
            //if (e.CommandName.ToLower() == "insertar")
            //{
            //    TextBox cajaTexto;
            //    CheckBox check;
            //    string textoActual;
            //    bool checkActual;
            //    Negocio.Usuario usuarioNuevo = new Negocio.Usuario();

            //    //Busco el control y se lo asigno a la propiedad correspondiente 
            //    //del objeto Usuario
            //    cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombre");
            //    textoActual = cajaTexto.Text;
            //    usuarioNuevo.Nombre = textoActual;

            //    //Así hago sucesivamente con el resto de los parámetros
            //    cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtApellido");
            //    textoActual = cajaTexto.Text;
            //    usuarioNuevo.Apellido = textoActual;

            //    cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtEmail");
            //    textoActual = cajaTexto.Text;
            //    usuarioNuevo.Email = textoActual;

            //    cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtNombreUsuario");
            //    textoActual = cajaTexto.Text;
            //    usuarioNuevo.NombreUsuario = textoActual;

            //    cajaTexto = (TextBox)grdUsuarios.FooterRow.FindControl("txtClave");
            //    textoActual = cajaTexto.Text;
            //    usuarioNuevo.Clave = textoActual;

            //    check = (CheckBox)grdUsuarios.FooterRow.FindControl("chkHabilitado");
            //    checkActual = check.Checked;
            //    usuarioNuevo.Habilitado = checkActual;

            //    //Defino una variable del Manager para ejecutar el evento de Insertar
            //    Negocio.ManagerUsuarios manager = new Negocio.ManagerUsuarios();

            //    //Agrego el Nuevo Usuario
            //    manager.AgregarUsuario(usuarioNuevo);

            //    //Actualizo la Grilla
            //    grdUsuarios.DataBind();
            //}


        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre0.Text;
            usuario.Apellido = txtApellido0.Text;
            usuario.Email = txtEmail0.Text;
            usuario.NombreUsuario = txtNombreUsuario0.Text;
            usuario.Clave = txtClave0.Text;
            usuario.Habilitado = ckbHabilitado.Checked;
            if (PaginaEnEstadoEdicion())
            {
                new ManagerUsuarios().ActualizarUsuario(usuario);
            }
            else
            {
                new ManagerUsuarios().AgregarUsuario(usuario);
            }
            grdUsuarios.DataBind();
            Response.Redirect("ListaUsuarios.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaUsuarios.aspx");
        }
    }
}