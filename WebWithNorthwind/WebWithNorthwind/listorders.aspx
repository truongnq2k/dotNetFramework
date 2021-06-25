<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listorders.aspx.cs" Inherits="WebWithNorthwind.listorders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List Orders</title>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css" />
</head>
<body>
    <form id="ListOrderForm" runat="server">
        <div>
            <asp:Label ID="lbCustomer" runat="server" Text="Customer"></asp:Label>
            <asp:DropDownList EnableViewState="true" ID="ddlCustomer" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lbEmployee" runat="server" Text="Employee"></asp:Label>
            <asp:DropDownList EnableViewState="true" ID="ddlEmployee" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="lbDateFrom" runat="server" Text="Date From"></asp:Label>
            <asp:TextBox EnableViewState="false" ID="tbDateFrom" runat="server" class="dateFrom" OnTextChanged="DateFrom_TextChanged" AutoPostBack="True" />
            <asp:Label ID="lbDateTo" runat="server" Text="Date To"></asp:Label>
            <asp:TextBox EnableViewState="false" ID="tbDateTo" runat="server" class="dateTo" OnTextChanged="DateTo_TextChanged" AutoPostBack="True" ></asp:TextBox>
        </div>
            <asp:Label ID="lbLateOrder" runat="server" Text="Late Order"></asp:Label>
            <asp:CheckBox ID="cbLateOrder" runat="server" AutoPostBack="True" OnCheckedChanged="cbLateOrder_CheckedChanged" />
        <div>


        </div>

        <div>
            <asp:GridView EnableViewState="false" ID="gvProducts" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Order ID" DataField="OrderID" />
                    <asp:BoundField HeaderText="Customer" DataField="Customer" />
                    <asp:BoundField HeaderText="Employee" DataField="Employee" />
                    <asp:BoundField HeaderText="Order Date" DataField="OrderDate" />
                    <asp:BoundField HeaderText="Required Date" DataField="RequiredDate" />
                    <asp:BoundField HeaderText="Shipped Date" DataField="ShippedDate" />
                    <asp:BoundField HeaderText="Freight" DataField="Freight" />
                </Columns>
            </asp:GridView>
        </div>
    </form>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <script>
        $(function () {
            $(".dateTo").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true
            })

            $(".dateFrom").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true
            })
        })
    </script>

</body>
</html>
