<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaClientes.aspx.cs" Inherits="TPC_Equipo_A.ListaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="mb-3">Lista de Clientes</h2>
    <asp:GridView ID="dgvClientes" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table table-bordred table-striped" OnSelectedIndexChanged="dgvClientes_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
            <asp:CommandField ShowEditButton="True" HeaderText="Acciones" />
        </Columns>
    </asp:GridView>
    <a href="FormularioClientes.aspx" class="btn btn-dark">Agregar Cliente</a>
</asp:Content>
