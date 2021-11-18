<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCustDetails.aspx.cs" Inherits="WBL2_Project.EditCustDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Customer Details Management"></asp:Label>
    </p>
    <br />
    <p>

        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">

             <ItemTemplate>
             <div class="rptr">
                <table>
                    <tr>
                        <th colspan="3">Customer: <%#Eval("idLoginDetails") %></th>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("idLoginDetails") %>' Visible="False"></asp:Label>
                    </tr>
                    <tr>
                        <td>Username:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "Username")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="True"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Password:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" Style="border: none" Text='<%# DataBinder.Eval(Container.DataItem, "Password")%>'
                                EnableViewState="True" BackColor="#EBEBEB" Enabled="True"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete">Delete</asp:LinkButton>
                        </td>
                        <td>
                            <asp:LinkButton Visible="true" ID="LinkButton3" runat="server" CommandName="update" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "idLoginDetails")%>'>Update</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>

        </asp:Repeater>

    </p>
    <p style="height: 272px">
    </p>
    <p style="height: 272px">
    </p>
</asp:Content>
