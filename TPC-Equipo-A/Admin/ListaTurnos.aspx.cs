using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Equipo_A.Admin
{
    public partial class ListaTurnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TurnoNegocio negocio = new TurnoNegocio();
                Session.Add("ListaTurnos", negocio.ListarTurnos());
                dgvTurnos.DataSource = Session["ListaTurnos"];
                dgvTurnos.DataBind();
            }
        }

        protected void dgvTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}