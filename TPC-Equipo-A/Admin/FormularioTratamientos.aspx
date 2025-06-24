<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioTratamientos.aspx.cs" Inherits="TPC_Equipo_A.Admin.FormularioTratamientos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .ocultar {
            display: none;
        }
    </style>
    <div class="row">
        <div class="col-md-6 offset-md-2">
            <asp:TextBox ID="txtId" CssClass="ocultar" runat="server"></asp:TextBox>
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox ID="txtDescripcion" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox ID="txtPrecio" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtEstimado" class="form-label">Duración Estimada</label>
                <asp:TextBox ID="txtEstimado" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="col-md-4 offset-md-2 mt-3">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="btnAceptar_Click" />
        <a href="ListaClientes.aspx" class="btn btn-dark">Volver</a>
    </div>

</asp:Content>
