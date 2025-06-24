using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Equipo_A.Admin
{
    public partial class ListaTratamientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TratamientoNegocio negocio = new TratamientoNegocio();
                Session.Add("ListaTratamientos", negocio.ListarTratamientos());
                dgvTratamientos.DataSource = Session["ListaTratamientos"];
                dgvTratamientos.DataBind();
            }
        }

        protected void dgvTratamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvTratamientos.SelectedDataKey.Value.ToString();
            Response.Redirect("ListaTratamientos.aspx?id=" + id, false);
        }
    }
}