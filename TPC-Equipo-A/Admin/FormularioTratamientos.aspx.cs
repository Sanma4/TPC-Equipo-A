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
    public partial class FormularioTratamientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";

                if (id != "")
                {
                    TratamientoNegocio negocio = new TratamientoNegocio();
                    Tratamiento seleccionado = (negocio.ListarTratamientos(id))[0];
                    txtId.Text = seleccionado.Id.ToString();
                    txtDescripcion.Text = seleccionado.Descripcion;
                    txtPrecio.Text = seleccionado.Precio.ToString("F2");
                    txtEstimado.Text = seleccionado.DuracionEstimada;

                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientoNegocio negocio = new TratamientoNegocio();
            Tratamiento nuevo = new Tratamiento();

            try
            {
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.DuracionEstimada = txtEstimado.Text;
                if (Request.QueryString["id"] != null   )
                {
                    nuevo.Id = int.Parse(txtId.Text);
                    negocio.Editar(nuevo);
                }
                else
                {
                    negocio.Agregar(nuevo);
                }
                Response.Redirect("ListaTratamientos.aspx",false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}