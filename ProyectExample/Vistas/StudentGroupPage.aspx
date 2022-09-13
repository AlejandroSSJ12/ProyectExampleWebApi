<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentGroupPage.aspx.cs" Inherits="ProyectExample.Vistas.WebForm3" %>

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
                        <a class="nav-link  second-text fw-bold" href="GroupPagee.aspx">Group</a>
                    </li>
                    
                </ul>
            </nav>
        </div>
        <div>
            <h1>Groups/Students</h1>
            <asp:DropDownList ID="ddlGroup" runat="server" DataSourceID="NameG" DataTextField="Name" DataValueField="Name"></asp:DropDownList>
            <asp:SqlDataSource ID="NameG" runat="server" ConnectionString="<%$ ConnectionStrings:databaseExampleHETDConnectionString4 %>" SelectCommand="SELECT [Name] FROM [groups]"></asp:SqlDataSource>
            <%--<asp:TextBox ID="setAlumnoID" runat="server" placeholder="Inserte el ID del Estudiante"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="setGroupID" runat="server" placeholder ="Inserte el ID del Grupo"></asp:TextBox>--%>
            
            <br />
            <asp:GridView ID="GVGS" runat="server" AutoGenerateColumns="False" Width="708px">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Checkbox ID="chbStudent" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Id" HeaderText="ID" />
                    <asp:BoundField DataField="Name" HeaderText="StudentName" />
                    <asp:BoundField DataField="Age" HeaderText="StudentAge" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar Datos" OnClick="btnEnviar_Click" />
            <br />
            <asp:Label ID="comprobar" runat="server" Width="374px"></asp:Label>
 
        </div>
        
            

            
    </form>
</body>
</html>
