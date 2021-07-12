<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="WebWithNorthwind.Checkout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Checkout NorthWind</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <style>
        @media screen and (min-width: 576px) {
            .pxc-5 {
                padding-right: 10rem !important;
                padding-left: 10rem !important;
            }
            .pxc-6 {
                padding-right: 20rem !important;
                padding-left: 20rem !important;
            }
        }
    </style>
</head>
<body>
    <form id="CheckoutForm" runat="server" class="container py-5 pxc-5">

        <% if (Total > 0)
            { %>

        <div class="row g-5">
            <div class="col-md-5 col-lg-4 order-md-last">
                <h4 class="d-flex justify-content-between align-items-center mb-3">
                    <span class="text-success">Your cart</span>
                    <span class="badge bg-success rounded-pill"><%= Session["quantity"] %></span>
                </h4>
                <ul class="list-group mb-3">

                    <asp:Repeater ID="rpProduct" runat="server">
                        <ItemTemplate>
                            <li class="list-group-item d-flex justify-content-between lh-sm">
                                <div>
                                    <h6 class="my-0"><%# DataBinder.Eval(Container.DataItem, "ProductName") %> x <%# DataBinder.Eval(Container.DataItem, "Quantity") %></h6>
                                </div>
                                <span class="text-muted">$<%# DataBinder.Eval(Container.DataItem, "Price") %></span>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                    <li class="list-group-item d-flex justify-content-between">
                        <span>Total (USD)</span>
                        <strong>$<%= Total %></strong>
                    </li>
                </ul>

            </div>
            <div class="col-md-7 col-lg-8">
                <h4 class="mb-3">Billing address</h4>
                <div class="row g-3">
                    <div class="col-sm-6">
                        <label for="fullName" class="form-label">Contact name</label>
                        <asp:TextBox ID="fullName" runat="server" class="form-control" placeholder="Quang Truong"></asp:TextBox>
                        <div class="invalid-feedback">
                            Valid full name is required.
                        </div>
                    </div>

                    <div class="col-sm-6">
                        <label for="contactPhone" class="form-label">Phone</label>
                        <asp:TextBox ID="contactPhone" runat="server" class="form-control" placeholder="+8486.2020.654"></asp:TextBox>
                        <div class="invalid-feedback">
                            Valid phone is required.
                        </div>
                    </div>


                    <div class="col-12">
                        <label for="contactEmail" class="form-label">Email <span class="text-muted">(Optional)</span></label>
                        <asp:TextBox ID="contactEmail" runat="server" class="form-control" placeholder="truong@kotzava.com"></asp:TextBox>
                        <div class="invalid-feedback">
                            Please enter a valid email address for shipping updates.
                        </div>
                    </div>

                    <div class="col-12">
                        <label for="caddress" class="form-label">Address</label>
                        <asp:TextBox ID="caddress" runat="server" class="form-control" placeholder="1234 Main St"></asp:TextBox>
                        <div class="invalid-feedback">
                            Please enter your shipping address.
                        </div>
                    </div>

                    <div class="col-md-4">
                        <label for="ddlProvince" class="form-label">Province</label>
                        <asp:DropDownList ID="ddlProvince" runat="server" class="form-select" AutoPostBack="True" EnableViewState="true" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged">
                            <asp:ListItem Value="0">--Select City--</asp:ListItem>
                        </asp:DropDownList>
                    </div>

                    <div class="col-md-4">
                        <label for="ddlDistrict" class="form-label">District</label>
                        <asp:DropDownList ID="ddlDistrict" runat="server" class="form-select" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged"></asp:DropDownList>
                    </div>

                    <div class="col-md-4">
                        <label for="ddlWard" class="form-label">Ward</label>
                        <asp:DropDownList ID="ddlWard" runat="server" class="form-select"></asp:DropDownList>
                    </div>

                    <div class="col-sm-6">
                        <label for="contactCompany" class="form-label">Company</label>
                        <div class="input-group has-validation">
                            <span class="input-group-text">@</span>
                            <asp:TextBox ID="contactCompany" runat="server" class="form-control" placeholder="Ex: Kotzava"></asp:TextBox>
                            <div class="invalid-feedback">
                                Your company is required.
                            </div>
                        </div>
                    </div>
                    <div class="col-sm-6">
                        <label for="ddlShipping" class="form-label">Shipping</label>
                        <asp:DropDownList ID="ddlShipping" runat="server" class="form-select"></asp:DropDownList>
                    </div>

                </div>

                <hr class="my-4" />
                <asp:Button ID="btnCheckout" class="w-100 btn btn-success btn-lg" Text="Checkout" runat="server" OnClick="Checkout_Click" />
            </div>
        </div>
        <% } %>

        <% if (Total == 0)
            { %>
        <div class="pxc-6">
            <a href="listproduct.aspx" class="btn btn-success btn-sm mb-2">Go shop</a>
            <svg xmlns="http://www.w3.org/2000/svg" style="display: none;">
                <symbol id="check-circle-fill" fill="currentColor" viewBox="0 0 16 16">
                    <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z" />
                </symbol>
                <symbol id="info-fill" fill="currentColor" viewBox="0 0 16 16">
                    <path d="M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z" />
                </symbol>
                <symbol id="exclamation-triangle-fill" fill="currentColor" viewBox="0 0 16 16">
                    <path d="M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z" />
                </symbol>
            </svg>
            <div class="alert alert-danger d-flex align-items-center" role="alert">
                <svg class="bi flex-shrink-0 me-2" width="24" height="24" role="img" aria-label="Warning:">
                    <use xlink:href="#exclamation-triangle-fill" />
                </svg>
                <div>
                    Your cart is empty! 
                </div>
            </div>
        </div>
        <% } %>
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
