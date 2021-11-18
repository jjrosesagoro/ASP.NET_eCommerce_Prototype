<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="WBL2_Project.AdminPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Bulk Order Management"></asp:Label>
    </p>
    <p>
        The status of bulk orders can be updated by an administrator below.
    </p>
    <br />
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
            <ItemTemplate>
             <div class="rptr">
                <table>
                    <tr>
                        <th colspan="3">Bulk Order: <%#Eval("idBulkOrder") %></th>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("idBulkOrder") %>' Visible="False"></asp:Label>
                    </tr>
                    <tr>
                        <td>Order ID:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "OrderID")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Date Created:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "DateCreated")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Order Status:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "OrderStatus")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="True"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete">Delete</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton Visible="true" ID="LinkButton3" runat="server" CommandName="update" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "idBulkOrder")%>'>Update</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>
        </asp:Repeater>
    
    <p style="height: 314px">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:WBL2ConnectionString %>"
            SelectCommand="SELECT [idBulkOrder], [OrderID], [DateCreated], [OrderStatus] FROM [BulkOrder]">
        </asp:SqlDataSource>
    </p>
    <p style="height: 1055px">

    </p>
    <br />
</asp:Content>
