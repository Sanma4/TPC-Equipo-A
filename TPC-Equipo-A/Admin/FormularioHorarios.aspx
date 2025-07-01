<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioHorarios.aspx.cs" Inherits="TPC_Equipo_A.Admin.FormularioHorarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .ocultar {
            display: none;
        }
    </style>
    <div class="row">
        <h2 class="text-center">Crear un nuevo horario</h2>
        <div class="col-md-4 offset-md-3">
            <asp:TextBox ID="txtId" CssClass="ocultar" runat="server"></asp:TextBox>
            <div class="mb-3">
                <label for="txtDia" class="form-label">Día</label>
                <asp:TextBox ID="txtDia" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtEntrada" class="form-label">Hora de Entrada</label>
                <asp:TextBox ID="txtEntrada" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="txtSalida" class="form-label">Hora de Salida</label>
                <asp:TextBox ID="txtSalida" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="col-md-4 offset-md-3 mt-3">
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="btnAceptar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
        <a href="ListaHorarios.aspx" class="btn btn-primary">Volver</a>
    </div>


</asp:Content>
