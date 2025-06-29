<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioPeluqueros.aspx.cs" Inherits="TPC_Equipo_A.Admin.FormularioPeluqueros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <style>
    .ocultar {
        display: none;
    }
</style>
<div class="row">
    <div class="col-md-4 offset-md-2">
        <asp:TextBox ID="txtId" CssClass="ocultar" runat="server"></asp:TextBox>
        <div class="mb-3">
            <label for="txtNombre" class="form-label">Nombre</label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtApellido" class="form-label">Apellido</label>
            <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtEmail" class="form-label">Email</label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="col-md-4 ">
        <div class="mb-3">
            <label for="txtTlf" class="form-label">Teléfono</label>
            <asp:TextBox ID="txtTlf" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtSexo" class="form-label">Sexo</label>
            <asp:TextBox ID="txtSexo" CssClass="form-control" placeholder="Ingresar M-F" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="txtActivo" class="form-label">Activo</label>
            <asp:DropDownList ID="ddlActivo" CssClass="form-control" runat="server">
                <asp:ListItem Text="Si" Value="Si"></asp:ListItem>
                <asp:ListItem Text="No" Value="No"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
</div>
<div class="col-md-4 offset-md-2 mt-3">
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-success" OnClick="btnAceptar_Click" />
    <a href="ListaPeluqueros.aspx" class="btn btn-dark">Volver</a>
</div>

</asp:Content>
