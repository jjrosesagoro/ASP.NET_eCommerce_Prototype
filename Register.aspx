<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WBL2_Project.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <br />
        Please register a new account below.</h2>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;
                <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server" Height="29px" Width="167px"></asp:TextBox>
            </p>
    <p>
        &nbsp;
                <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="167px"></asp:TextBox>
            </p>
    <p>
        &nbsp;
                <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="167px" TextMode="Password"></asp:TextBox>
            </p>
    <p>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Please check this box if you would like to join our mailing list" />
            </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Height="32px" Text="Register" Width="161px" OnClick="Button1_Click" />

            </p>
    <p>
        &nbsp;<asp:Label ID="Label4" runat="server" Font-Size="Medium" ForeColor="#33CC33"></asp:Label>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Once registered, click here to be redirected to the login page!</asp:HyperLink>
    </p>

     

    <br />
</asp:Content>
