using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Equipo_A.Admin
{
    public partial class FormularioPeluqueros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";

                if (id != "")
                {
                    PeluqueroNegocio negocio = new PeluqueroNegocio();
                    Peluquero seleccionado = (negocio.ListarPeluqueros(id))[0];
                    txtId.Text = seleccionado.Id.ToString();
                    txtNombre.Text = seleccionado.Nombre;
                    txtApellido.Text = seleccionado.Apellido;
                    txtTlf.Text = seleccionado.Telefono;
                    txtEmail.Text = seleccionado.Email;
                    txtSexo.Text = seleccionado.Sexo;
                    ddlActivo.SelectedValue = seleccionado.Activo ? "Si" : "No";
                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            PeluqueroNegocio negocio = new PeluqueroNegocio();
            Peluquero nuevo = new Peluquero();

            try
            {
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Telefono = txtTlf.Text;
                nuevo.Email = txtEmail.Text;
                nuevo.Sexo = txtSexo.Text;
                if (ddlActivo.SelectedValue == "Si")
                    nuevo.Activo = true;
                else
                    nuevo.Activo = false;


                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(txtId.Text);
                    negocio.Editar(nuevo);
                }
                else
                {
                    negocio.Agregar(nuevo);
                }

                Response.Redirect("ListaPeluqueros.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}