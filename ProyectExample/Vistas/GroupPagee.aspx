<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupPagee.aspx.cs" Inherits="ProyectExample.Vistas.WebForm2" %>

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
                        <a class="nav-link second-text fw-bold" href="StudentPagee.aspx">Student</a>
                    </li>
                    <li class="nav-item ">
                        <a class="nav-link  second-text fw-bold" href="StudentGroupPage.aspx">Group/Student</a>
                    </li>
                    
                </ul>
            </nav>
        </div>
        <div>
            <h1>Group Page</h1>
            <asp:TextBox ID="setGroup" runat="server" placeholder="Ingrese el nombre del grupo:"></asp:TextBox>
               
                <br />
                <br />
            <asp:TextBox ID="comprobar" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Enviar Datos" OnClick="Button1_Click" />
        </p>
        <asp:GridView ID="Gs" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Name" HeaderText="GroupName" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
