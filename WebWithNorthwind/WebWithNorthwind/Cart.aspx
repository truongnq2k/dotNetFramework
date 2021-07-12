<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebWithNorthwind.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart NorthWind</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" integrity="sha512-iBBXm8fW90+nuLcSKlbmrPcLa0OT92xO1BIsZ+ywDWZCvqsWgccV3gFoRBv0z+8dLJgyAHIhR35VZc2oM/gI1w==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js" integrity="sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <style>
        @media screen and (min-width: 576px) {
            .pxc-5 {
                padding-right: 22rem !important;
                padding-left: 22rem !important;
            }
        }
    </style>
</head>
<body>
    <form id="FormCart" runat="server" class="container my-5 pxc-5">
        <a href="listproduct.aspx" class="btn btn-success mb-3">Go Shop</a>
        <div>
            <table class="table table-striped">
                <thead>
                    <tr>
                        <th scope="col">Product Name</th>
                        <th scope="col">Category</th>
                        <th scope="col">Qty</th>
                        <th scope="col">Price</th>
                        <th scope="col">Action</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rpProduct" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%# DataBinder.Eval(Container.DataItem, "ProductName") %></td>
                                <td><%# DataBinder.Eval(Container.DataItem, "CategoryName") %></td>
                                <td>
                                    <asp:Button ID="btnSub" runat="server" class="btn btn-outline-secondary" Text="-" OnClick="btnSub_Click" />
                                    <%# DataBinder.Eval(Container.DataItem, "Quantity") %>
                                    <asp:Button ID="btnAdd" runat="server" class="btn btn-outline-secondary" Text="+" OnClick="btnAdd_Click"/>
                                </td>
                                <td><%# DataBinder.Eval(Container.DataItem, "Price") %>$</td>
                                <td><a href="RemoveItem.aspx?pid=<%# DataBinder.Eval(Container.DataItem, "ProductID") %>" class="btn btn-success btn-sm">Remove</a></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>


            <a href="RemoveItem.aspx?action=removeall" class="btn btn-danger btn-sm mb-4">Remove All</a>
        </div>
        <button type="button" class="btn btn-lg btn-success" disabled="disabled">Total:  <%= Total %>$</button>
        <a href="Checkout.aspx" class="btn btn-secondary btn-lg">Checkout</a>
    </form>
    <div class="d-flex justify-content-center align-items-center my-5">
        <div id="loading" class="spinner-border text-success" style="width: 6rem; height: 6rem; margin-top: 15rem;" role="status">
            <span class="visually-hidden">Loading...</span>
        </div>
    </div>
    <script>
        setVisible('.container', false);

        function onReady(callback) {
            var intervalId = window.setInterval(function () {
                if (document.getElementsByTagName('body')[0] !== undefined) {
                    window.clearInterval(intervalId);
                    callback.call(this);
                }
            }, 500);
        }

        function setVisible(selector, visible) {
            document.querySelector(selector).style.display = visible ? 'block' : 'none';
        }

        onReady(function () {
            setVisible('.container', true);
            setVisible('#loading', false);
        });
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>
</html>
