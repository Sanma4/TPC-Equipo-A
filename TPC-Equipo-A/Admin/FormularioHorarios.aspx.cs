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
    public partial class FormularioHorarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
            if (id != "")
            {
                HorarioNegocio negocio = new HorarioNegocio();
                Horario seleccionado = (negocio.ListarHorarios(id))[0];
                txtId.Text = seleccionado.Id.ToString();
                txtDia.Text = seleccionado.Dia;
                txtEntrada.Text = seleccionado.HoraEntrada;
                txtSalida.Text = seleccionado.HoraSalida;


            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            HorarioNegocio negocio = new HorarioNegocio();
            Horario nuevo = new Horario();
            try
            {
                nuevo.Dia = txtDia.Text;
                nuevo.HoraEntrada = txtEntrada.Text;
                nuevo.HoraSalida = txtSalida.Text;

                if (Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(txtId.Text);
                    negocio.Modificar(nuevo);
                }
                else
                {
                    negocio.Agregar(nuevo);
                }

                Response.Redirect("ListaHorarios.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            HorarioNegocio negocio = new HorarioNegocio();
            try
            {

                int id = int.Parse(Request.QueryString["id"]);
                negocio.Eliminar(id);

                Response.Redirect("ListaHorarios.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}