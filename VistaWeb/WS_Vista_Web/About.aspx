<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WS_Vista_Web.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <h1 style="text-align:center">Usuarios</h1>
    <br />
    <div class="container">

        <table>
            <tr>
                 <td class="modal-sm" style="width: 298px"></td>
                <th style="width: 118px">  <label>ID</label></th>
                 <td style="width: 345px"> <asp:TextBox ID="ID" runat="server" Width="320px"></asp:TextBox></td>
                <td> <asp:Button ID="BTBuscar" runat="server" Text="Buscar" OnClick="BTBuscar_Click" /></td>
            </tr>
             <tr>
                  <td class="modal-sm" style="width: 298px"></td>
                <th style="width: 118px"> <label>ID Usuario</label></th>
                 <td style="width: 345px"> <asp:TextBox ID="ID_Usuario" runat="server" Width="319px"></asp:TextBox></td>
                 <td></td>
            </tr>
             <tr> <td class="modal-sm" style="width: 298px"></td>
                <th style="width: 118px">   <label>Nombre</label></th>
                 <td style="width: 345px">    <asp:TextBox ID="Nombre" runat="server" Width="318px"></asp:TextBox></td>
                 <td></td>
            </tr>

             <tr>
                  <td class="modal-sm" style="width: 298px"></td>
                <th style="width: 118px"><label>Apellidos</label></th>
                 <td style="width: 345px"><asp:TextBox ID="Apellidos" runat="server" Width="319px"></asp:TextBox></td>
                 <td></td>
            </tr>
               <tr>
                  <td class="modal-sm" style="width: 298px">   </td>
                <th style="width: 118px"><label>Correo</label></th>
                 <td style="width: 345px"> <asp:TextBox ID="Correo" runat="server" Width="319px"></asp:TextBox></td>
                  <td></td>
            </tr>
              <tr>
                  <td class="modal-sm" style="width: 298px">   </td>
                <th style="width: 118px"><label>Teléfono</label></th>
                 <td style="width: 345px"> <asp:TextBox ID="Telefono" runat="server" Width="319px"></asp:TextBox></td>
                  <td></td>
            </tr>
            <tr>
                <th class="modal-sm" style="width: 298px"></th>
                <th style="width: 118px">  </th>
                <th style="width: 345px"> <asp:Button ID="BtGuardar" runat="server" Text="Guardar" OnClick="BtGuardar_Click" />
                    <asp:Button ID="BtModificar" runat="server" Text="Modificar" OnClick="BtModificar_Click" />
                    <asp:Button ID="BTEliminar" runat="server" Text="Eliminar" OnClick="BTEliminar_Click" />
                </th>
                 <th> <asp:Button ID="BTLimpiar" runat="server" Text="Limpiar" OnClick="BTLimpiar_Click" /></th>
               
            </tr>
            <tr>
                <th></th>
                <th></th>
                <td style="width: 345px"> <asp:TextBox ID="TXInfo" runat="server" Width="319px" Enabled="false"></asp:TextBox></td>
                <th></th>

            </tr>
        </table>
 
    </div>
    <br />
    <div>

        <asp:GridView ID="GridView1" runat="server" Width="1013px">
        </asp:GridView>

    </div>

</asp:Content>
