<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaceOrder.aspx.cs" Inherits="WBL2_Project.PlaceOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
        &nbsp;</p>
    <p style="height: 56px">
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Order Checkout"></asp:Label>
    </p>
    <p style="height: 56px">
        All items from the cart will now be presented here before completion of the checkout process.</p>
    <table style="width: 35%; height: 93px" border="1">
        <tr>
            <td class="modal-sm" style="width: 202px">Order ID</td>
            <td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 202px">Order Date</td>
            <td>
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 202px">Order Status</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Pending"></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <p style="height: 263px">

        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="False" Height="237px" ShowFooter="True" Width="823px">
            <Columns>
                <asp:BoundField DataField="idProduct" HeaderText="Product ID" />
                <asp:BoundField DataField="P_Name" HeaderText="Product Name" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="totalprice" HeaderText="Grand Total" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" Height="50px" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>

    </p>
    <p class="text-center">

        <asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" Text="Place Order" Width="158px" />
    </p>
    
</asp:Content>
