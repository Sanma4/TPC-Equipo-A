<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaTratamientos.aspx.cs" Inherits="TPC_Equipo_A.Admin.ListaTratamientos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="mb-3">Lista de Tratamientos</h2>
    <asp:GridView ID="dgvTratamientos" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table table-bordred table-striped mb-3" OnSelectedIndexChanged="dgvTratamientos_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
            <asp:BoundField DataField="Precio" HeaderText="Precio" />
            <asp:BoundField DataField="DuracionEstimada" HeaderText="Duracion estimada" />
            <asp:CommandField ShowSelectButton="True" SelectText="Editar" HeaderText="Acciones" />
        </Columns>
    </asp:GridView>
    <a href="FormularioTratamientos.aspx" class="btn btn-dark">Agregar Tratamiento</a>
</asp:Content>
