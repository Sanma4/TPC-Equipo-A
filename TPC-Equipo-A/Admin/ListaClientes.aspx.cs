using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Equipo_A
{
    public partial class ListaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteNegocio negocio = new ClienteNegocio();
                Session.Add("ListaClientes", negocio.ListarClientes());
                dgvClientes.DataSource = Session["ListaClientes"];
                dgvClientes.DataBind();
            }
        }

        protected void dgvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvClientes.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioClientes.aspx?id=" + id);
        }
    }
}