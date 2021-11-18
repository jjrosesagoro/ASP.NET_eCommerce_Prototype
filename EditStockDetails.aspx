<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditStockDetails.aspx.cs" Inherits="WBL2_Project.EditStockDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Stock Details Management"></asp:Label>
    </p>
    <br />
    <p>

        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

            <ItemTemplate>
             <div class="rptr">
                <table>
                    <tr>
                        <th colspan="2">Stock: <%#Eval("idStock") %></th>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("idStock") %>' Visible="False"></asp:Label>
                    </tr>
                    <tr>
                        <td>Product ID:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "idProduct")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="False"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Amount in Shop (KG):</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "InShop")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="True"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Amount in Warehouse (KG):</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "Warehouse")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="True"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete">Delete</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton Visible="true" ID="LinkButton3" runat="server" CommandName="update" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "idStock")%>'>Update</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>

        </asp:Repeater>

    </p>
    <p style="height: 367px">
    </p>
</asp:Content>
