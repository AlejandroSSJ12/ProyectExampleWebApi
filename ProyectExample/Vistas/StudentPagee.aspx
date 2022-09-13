<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPagee.aspx.cs" Inherits="ProyectExample.Vistas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div id="page-content-wrapper">
            <nav class="navbar navbar-expand-lg navbar-light bg-transparent py-4 px-4">
                <ul class="nav nav-pills">
                    <li class="nav-item">
                        <a class="nav-link second-text fw-bold" href="StudentGroupPage.aspx">Group/Student</a>
                    </li>
                    <li class="nav-item ">
                        <a class="nav-link  second-text fw-bold" href="GroupPagee.aspx">Group</a>
                    </li>
                    
                </ul>
            </nav>
        </div>
        <div>
            <h1>Student Page</h1>
            <asp:TextBox runat="server" ID="setName" placeholder ="Inserte el nombre del estudiante"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox runat="server" ID="setAge" placeholder="Inserte su edad"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox runat="server" ID="comprobar"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Enviar Datos" ID="btnEnviar" OnClick="btnEnviar_Click" />
        </div>
        <asp:GridView ID="Gss" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Name" HeaderText="Student Name" />
                <asp:BoundField DataField="Age" HeaderText="Age" />
            </Columns>
        </asp:GridView>
    </form>
</body>


</html>
