<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaTurnos.aspx.cs" Inherits="TPC_Equipo_A.Admin.ListaTurnos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="mb-3">Lista de Turnos</h2>
    <asp:GridView ID="dgvTurnos" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table table-bordred table-striped mb-3" OnSelectedIndexChanged="dgvTurnos_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Cliente.Id" HeaderText="Cliente" />
            <asp:BoundField DataField="Tratamiento.Id" HeaderText="Tratamiento" />
            <asp:BoundField DataField="Peluquero.Id" HeaderText="Peluquero" />
            <asp:BoundField DataField="HoraInicio" HeaderText="Hora Inicio" />
            <asp:BoundField DataField="HoraFin" HeaderText="Hora Fin" />
            <asp:CommandField ShowSelectButton="True" SelectText="Editar" HeaderText="Acciones" />
        </Columns>
    </asp:GridView>
    <a href="FormularioTurnos.aspx" class="btn btn-dark">Agregar Turno</a>
</asp:Content>
