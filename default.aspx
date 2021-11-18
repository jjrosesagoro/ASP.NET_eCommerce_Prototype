<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WBL2_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2 class="text-center">&nbsp;<asp:Image ID="Image1" runat="server" Height="233px" ImageUrl="~/Images/Logo.jpg" Width="535px" />
        </h2>
        <br />
        <p style="font-size: medium" class="text-center">Below customers can login to their user accounts or create an account if necessary.&nbsp;&nbsp;&nbsp;&nbsp; </p>
    </div>
    <p>

        <asp:Label ID="Label3" runat="server" Text="Hello"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>

    </p>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
        <div class="col-md-4">
            <p>
                <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="167px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="Password:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="167px" TextMode="Password"></asp:TextBox>
            </p>
            <p class="text-left">

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" Height="32px" Text="Login" Width="161px" OnClick="Button1_Click" />

            </p>
            <p class="text-left">

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label4" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>

            </p>
        </div>
       
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>
    <p>

        <asp:HyperLink ID="HyperLink2" runat="server" Font-Size="Small" NavigateUrl="~/Register.aspx">If you do not have an account, Please click here to register!</asp:HyperLink>

    </p>
    <br />
    <br />
    <br />
    <p class="text-center">

        Any enquiries can be made directly to Greenwich Butchers via:&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" ForeColor="#0066FF" Text="jr5976v@gre.ac.uk"></asp:Label>

    </p>

</asp:Content>
