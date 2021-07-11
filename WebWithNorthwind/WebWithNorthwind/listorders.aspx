<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listorders.aspx.cs" Inherits="WebWithNorthwind.listorders" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List Orders</title>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body>
    <form id="ListOrderForm" runat="server" class="container">
        <div class="row mt-5">
            <div class="col-sm-4">
                <div class="my-2">
                    <asp:Label ID="lbCustomer" runat="server" Text="Customer" class="form-label"></asp:Label>
                    <asp:DropDownList EnableViewState="true" ID="ddlCustomer" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged" runat="server" AutoPostBack="True" class="form-control">
                    </asp:DropDownList>
                </div>
                <div class="my-2">
                    <asp:Label ID="lbEmployee" runat="server" Text="Employee" class="form-label"></asp:Label>
                    <asp:DropDownList EnableViewState="true" ID="ddlEmployee" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged" runat="server" AutoPostBack="True" class="form-control">
                    </asp:DropDownList>
                </div>
                <div class="my-2">
                    <asp:Label ID="lbDateFrom" runat="server" Text="Date From" class="form-label"></asp:Label>
                    <asp:TextBox EnableViewState="false" ID="tbDateFrom" runat="server" class="dateFrom form-control" OnTextChanged="DateFrom_TextChanged" AutoPostBack="True" />
                </div>
                <div class="my-2">
                    <asp:Label ID="lbDateTo" runat="server" Text="Date To" class="form-label"></asp:Label>
                    <asp:TextBox EnableViewState="false" ID="tbDateTo" runat="server" class="dateTo form-control" OnTextChanged="DateTo_TextChanged" AutoPostBack="True" />
                </div>
                <div class="my-2">
                    <asp:Label ID="lbLateOrder" runat="server" Text="Late Order" class="form-label"></asp:Label>
                    <asp:CheckBox ID="cbLateOrder" runat="server" AutoPostBack="True" OnCheckedChanged="cbLateOrder_CheckedChanged" class="form-control" />
                </div>
            </div>
            <div class="col-sm-8">
                <div class="my-4">
                    <asp:GridView EnableViewState="false" ID="gvProducts" runat="server" AutoGenerateColumns="false" class="table table-striped" AllowPaging="True" PageSize="2" OnPageIndexChanging="gvProducts_PageIndexChanging">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <input type="checkbox" />
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField HeaderText="Order ID" DataField="OrderID" />
                            <asp:BoundField HeaderText="Customer" DataField="Customer" />
                            <asp:BoundField HeaderText="Employee" DataField="Employee" />
                            <asp:BoundField HeaderText="Order Date" DataField="OrderDate" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField HeaderText="Required Date" DataField="RequiredDate" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField HeaderText="Shipped Date" DataField="ShippedDate" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField HeaderText="Freight" DataField="Freight" />
                        </Columns>
                        <PagerSettings Mode="Numeric" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
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
