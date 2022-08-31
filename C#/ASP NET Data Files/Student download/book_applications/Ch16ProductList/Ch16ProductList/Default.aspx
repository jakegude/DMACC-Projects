<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch16ProductList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch16: Product List</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
    <header class="jumbotron"><%-- image set in site.css --%></header>
    <main>

        <form id="form1" runat="server">

            <asp:ListView ID="ListView1" runat="server" 
                DataSourceID="SqlDataSource1" DataKeyNames="ProductID">
                <LayoutTemplate>
                    <p id="product" class="col-xs-12">Product</p>
                    <div runat="server" id="itemPlaceholderContainer">
                        <span runat="server" id="itemPlaceholder" />
                    </div>
                    <div id="pager" class="text-center">
                        <asp:DataPager runat="server" ID="DataPager1" 
                            PageSize="4">
                            <Fields>
                                <asp:NextPreviousPagerField 
                                    ButtonType="Button" 
                                    ButtonCssClass="btn btn-default"
                                    ShowFirstPageButton="True" 
                                    ShowLastPageButton="True" 
                                    FirstPageText="&lt;&lt;" 
                                    PreviousPageText="&lt;" 
                                    NextPageText="&gt;" 
                                    LastPageText="&gt;&gt;">
                                </asp:NextPreviousPagerField>
                            </Fields>
                        </asp:DataPager>
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="row itemRow">
                        <div class="col-sm-3 font-bold">
                            <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" />
                        </div>
                        <div class="col-sm-9">
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Category:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("Category") %>' runat="server" ID="CategoryLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Short Description:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("ShortDescription") %>' runat="server" ID="ShortDescriptionLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Long Description:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("LongDescription") %>' runat="server" ID="LongDescriptionLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Unit Price:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("UnitPrice") %>' runat="server" ID="UnitPriceLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">On Hand:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("OnHand") %>' runat="server" ID="OnHandLabel" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <div class="row altRow">
                        <div class="col-sm-3 font-bold">
                            <asp:Label Text='<%# Eval("Name") %>' runat="server" ID="NameLabel" />
                        </div>
                        <div class="col-sm-9">
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Category:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("Category") %>' runat="server" ID="CategoryLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Short Description:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("ShortDescription") %>' runat="server" ID="ShortDescriptionLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Long Description:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("LongDescription") %>' runat="server" ID="LongDescriptionLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">Unit Price:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("UnitPrice") %>' runat="server" ID="UnitPriceLabel" />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-xs-5 col-sm-4">On Hand:</div>
                                <div class="col-xs-7 col-sm-8">
                                    <asp:Label Text='<%# Eval("OnHand") %>' runat="server" ID="OnHandLabel" />
                                </div>
                            </div>
                        </div>
                    </div>
                </AlternatingItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString='<%$ ConnectionStrings:HalloweenConnection %>' 
                SelectCommand="SELECT Products.ProductID, Products.Name, 
                    Categories.LongName AS Category, Products.ShortDescription, 
                    Products.LongDescription, Products.UnitPrice, Products.OnHand 
                    FROM Products INNER JOIN Categories
                    ON Products.CategoryID = Categories.CategoryID
                    ORDER BY Products.Name">
            </asp:SqlDataSource>

        </form>
    </main>
</div>
</body>
</html>