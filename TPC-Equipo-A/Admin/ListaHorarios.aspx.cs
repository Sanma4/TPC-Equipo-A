using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Equipo_A.Admin
{
    public partial class ListaHorarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HorarioNegocio negocio = new HorarioNegocio();
                Session.Add("ListaHorarios", negocio.ListarHorarios());
                dgvHorarios.DataSource = Session["ListaHorarios"];
                dgvHorarios.DataBind();
            }
        }

        protected void dgvHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvHorarios.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioHorarios.aspx?id=" + id, false);
        }
    }
}