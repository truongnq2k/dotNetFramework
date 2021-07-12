<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listproduct.aspx.cs" Inherits="WebWithNorthwind.listproduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shop NorthWind</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <style>
        @media screen and (min-width: 576px) {
            .pxc-4 {
                padding-right: 18rem !important;
                padding-left: 18rem !important;
            }
        }
    </style>
</head>
<body>
    <form id="ListProductForm" runat="server" class="container mt-5 pxc-4">
        <div>
            <button class="btn btn-success" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasRight" aria-controls="offcanvasRight">Show Cart</button>
            <a href="Cart.aspx" class="btn btn-success position-relative">View Cart
                    <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
                        <%= Session["quantity"] %>
                    </span>
            </a>
        </div>
        <nav class="mt-3">
            <ul class="pagination">
                <asp:Repeater ID="rpPages" runat="server">
                    <ItemTemplate>
                        <li class="page-item <%#DataBinder.Eval(Container.DataItem, "CssClass") %>">
                            <a href="listproduct.aspx?page=<%#DataBinder.Eval(Container.DataItem, "PageNumber") %>"
                                class="page-link <%#DataBinder.Eval(Container.DataItem, "TextColor") %> <%#DataBinder.Eval(Container.DataItem, "BGButton") %>">
                                <%#DataBinder.Eval(Container.DataItem, "PageNumber") %>
                            </a>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </nav>
        <div>
            <asp:GridView EnableViewState="false" ID="gvProducts" runat="server" class="table table-striped mt-3">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <a class="btn btn-success btn-sm" href="addtocart.aspx?pid=<%#DataBinder.Eval(Container.DataItem, "ProductID") %>&page=<%=PageIndex%>">Add to cart</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>

        <%--OFF CANVAS SHOW CART--%>
        <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasRight" aria-labelledby="offcanvasRightLabel">
            <div class="offcanvas-header">
                <h5 id="offcanvasRightLabel">Cart NorthWind</h5>
                <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
            </div>
            <div class="offcanvas-body">
                <div>

                    <asp:GridView ID="gvCart" runat="server" class="table table-striped" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField HeaderText="Name" DataField="ProductName" />
                            <asp:BoundField HeaderText="Price" DataField="Price" DataFormatString="{0}$" />
                            <asp:BoundField HeaderText="Qty" DataField="Quantity" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href="RemoveItem.aspx?pid=<%# DataBinder.Eval(Container.DataItem, "ProductID") %>" class="btn btn-success btn-sm">X</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <% if (Total > 0)
                        { %>
                    <a href="RemoveItem.aspx?action=removeall" class="btn btn-danger btn-sm mb-4">Remove All</a>
                    <% } %>
                </div>
                <button type="button" class="btn btn-lg btn-success" disabled="disabled">Total:  <%= Total %>$</button>
                <% if (Total > 0)
                    { %>
                <a href="Checkout.aspx" class="btn btn-secondary btn-lg">Checkout</a>
                <% } %>
            </div>
        </div>
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
