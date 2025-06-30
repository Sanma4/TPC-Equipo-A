<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaHorarios.aspx.cs" Inherits="TPC_Equipo_A.Admin.ListaHorarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="mb-3">Lista de Horarios</h2>
    <asp:GridView ID="dgvHorarios" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" CssClass="table table-bordred table-striped mb-3" OnSelectedIndexChanged="dgvHorarios_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Dia" HeaderText="Día" />
            <asp:BoundField DataField="HoraEntrada" HeaderText="Hora de Entrada" />
            <asp:BoundField DataField="HoraSalida" HeaderText="Hora de Salida" />
            <asp:CommandField ShowSelectButton="True" SelectText="Editar" HeaderText="Acciones" />
        </Columns>
    </asp:GridView>
    <a href="FormularioHorarios.aspx" class="btn btn-primary">Agregar Horario</a>

</asp:Content>
