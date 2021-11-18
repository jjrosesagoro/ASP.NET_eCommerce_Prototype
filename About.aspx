<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WBL2_Project.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Available Products</h2>
    <br />
    <p>All food items which are available for purchase can be viewed below.</p>
    <br />
    <h3>Number of products currently in cart:
        <asp:Label ID="Label5" runat="server" Text="Label" Font-Bold="True" ForeColor="#0066FF"></asp:Label>
    </h3>
    <p style="height: 30px">

        <asp:Label ID="Label3" runat="server" Text="Hello"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Login</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>

    </p>
    
    <p style="height: 57px">
        <asp:DataList ID="DataList1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyField="idProduct" DataSourceID="SqlDataSource1" GridLines="Both" RepeatColumns="3" RepeatDirection="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" OnItemCommand="DataList1_ItemCommand">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <ItemTemplate>
                <table border="1" class="nav-justified">
                    <tr>
                        <td style="height: 20px; text-align: center">Product ID:
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("idProduct") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("P_Name") %>'></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>Weight(kg):
                            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Weight") %>'></asp:Label>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl='<%# Eval("Image") %>' Width="300px" />
                            <br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td>Price(£):
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                            <br />
                            <br />
                            Quantity:
                            <asp:DropDownList ID="DropDownList1" runat="server">
                                <asp:ListItem>1</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                                <asp:ListItem>20</asp:ListItem>
                                <asp:ListItem>30</asp:ListItem>
                                <asp:ListItem>40</asp:ListItem>
                                <asp:ListItem>50</asp:ListItem>
                                <asp:ListItem></asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
                <table style="width: 100%" border="1">
                    <tr>
                        <td style="height: 66px">
                            <br />
                            <asp:ImageButton ID="ImageButton1" runat="server" Height="46px" ImageUrl="~/Images/cart2.0.jpg" Width="257px" CommandName="addtocart" CommandArgument='<%# Eval("idProduct") %>' />
                            <br />
                            <br />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
    </p>
    <p style="height: 29px">&nbsp;</p>
    <p style="height: 29px">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WBL2ConnectionString %>" SelectCommand="SELECT [idProduct], [P_Name], [Weight], [Price], [Image] FROM [Product]"></asp:SqlDataSource>
    </p>
</asp:Content>
