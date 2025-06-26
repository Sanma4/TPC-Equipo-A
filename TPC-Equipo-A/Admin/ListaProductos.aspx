<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="TPC_Equipo_A.Admin.ListaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:BoundField DataField="Id" HeaderText="Id" />
    <asp:BoundField DataField="Descripcion" HeaderText="Descripción" />
    <asp:BoundField DataField="Precio" HeaderText="Precio" />
    <asp:BoundField DataField="DuracionEstimada" HeaderText="Duracion estimada" />
    <asp:CommandField ShowSelectButton="True" SelectText="Editar" HeaderText="Acciones" />
</asp:Content>
