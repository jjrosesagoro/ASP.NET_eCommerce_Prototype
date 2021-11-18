<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminDirectory.aspx.cs" Inherits="WBL2_Project.AdminDirectory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Administrator Directory Page"></asp:Label>
    </p>
    <br />
    <p>

        Administrators are able to perform certain actions and this is the directory page that will allow them to perform those actions.</p>
    <br />
    <p style="text-align: center">

        <asp:Button ID="Button1" runat="server" Height="64px" Text="Edit Customer Details" Width="155px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="64px" OnClick="Button2_Click" Text="Edit Bulk Order Details" Width="155px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="64px" Text="Edit Stock Details" Width="155px" OnClick="Button3_Click" />

    </p>
    <br />
    </asp:Content>
