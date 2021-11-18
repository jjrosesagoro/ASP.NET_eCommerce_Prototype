<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WBL2_Project.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Administrator Login"></asp:Label>
    </p>
    <br />
    <br />
    <br />
    <p class="text-center">
                <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="167px"></asp:TextBox>
            </p>
    <p class="text-center">
                <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="167px" TextMode="Password"></asp:TextBox>
            </p>
    <p class="text-center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="37px" Text="Login" Width="142px" OnClick="Button2_Click" />
    </p>
    <p class="text-center">
        <asp:Label ID="Label4" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>

    </p>
</asp:Content>
