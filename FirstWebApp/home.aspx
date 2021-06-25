<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="FirstWebApp.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList EnableViewState="true" AutoPostBack="true" ID="ddlCategory" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">            
            </asp:DropDownList>
            <asp:GridView EnableViewState="false" ID="gvProducts" runat="server"  AutoGenerateColumns="false" 
                OnRowCommand="gvProducts_RowCommand">
                <Columns>
                    <asp:BoundField HeaderText="Product Name" DataField="ProductName" />
                    <asp:BoundField HeaderText="Product Price" DataField="Price" DataFormatString="{0} vnd" />
                    <asp:BoundField HeaderText="Category Name" DataField="CategoryName" />
                    
                    <asp:HyperLinkField HeaderText="Action" Text="Delete" DataNavigateUrlFields="ProductID,CategoryID" DataNavigateUrlFormatString="delete.aspx?pid={0}&cid={1}" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div style="color:red;border:1px solid gray; border-radius:2px;width:100px;">
                                <div>
                                    <asp:Button ID="btDelete" CommandArgument="ProductID" CommandName="Delete"  runat="server"/>
                                    <%# DataBinder.Eval(Container.DataItem, "ProductName") %>
                                </div>
                                <div>
                                    <%# DataBinder.Eval(Container.DataItem, "Price") %>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
