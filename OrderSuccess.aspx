<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderSuccess.aspx.cs" Inherits="WBL2_Project.OrderSuccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Thank you!"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p class="text-center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Your order has been placed successfully!"></asp:Label>
    </p>
    <p class="text-left">
        <asp:Button ID="Button1" runat="server" Height="47px" OnClick="Button1_Click" Text="Download Invoice" Width="159px" />
    </p>
    <asp:Panel ID="Panel1" runat="server" BorderStyle="Solid" Height="648px" Width="1280px">
        <table style="width: 100%; height: 528px;" border="1">
            <tr>
                <td style="height: 55px">
                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="Order Invoice"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="text-left" style="height: 99px"><strong>
                    <br />
                    Customer Email: </strong>
                    <asp:Label ID="Label7" runat="server"></asp:Label>
                    <strong>
                    <br />
                    <br />
                    Order ID</strong>:
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                    <br />
                    <br />
                    <strong>Order Date</strong>:
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="height: 296px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="293px" ShowFooter="True" Width="1272px">
                        <Columns>
                            <asp:BoundField DataField="idProduct" HeaderText="Product ID" />
                            <asp:BoundField DataField="P_Name" HeaderText="Product Name" />
                            <asp:BoundField DataField="Price" HeaderText="Price (£)" />
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
                </td>
            </tr>
            <tr>
                <td class="text-center" style="height: 58px">
                    <asp:Label ID="Label6" runat="server" Text="Greenwich Butchers™"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="text-left" style="height: 92px"><strong>Disclaimer:</strong> The grand total price is inclusive of VAT and the details of the delivery need to be followed up with the supplier.</td>
            </tr>
        </table>
    </asp:Panel>
    <p>
    </p>
    <br />
    <p class="text-center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click here to be redirected to the home page!</asp:LinkButton>
    </p>
</asp:Content>
