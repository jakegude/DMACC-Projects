<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch17ProductList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch17: Product List</title>
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
        <form id="form1" runat="server" class="form-horizontal">
            <div class="form-group">
                <label id="lblCategory" for="ddlCategory" 
                    class="col-xs-4 col-sm-offset-1 col-sm-3 control-label">
                    Choose a category:</label>
                <div class="col-xs-8 col-sm-5">
                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" 
                        DataSourceID="ObjectDataSource1" DataTextField="LongName" 
                        DataValueField="CategoryID" AutoPostBack="true">
                    </asp:DropDownList>
                    <asp:ObjectDataSource runat="server" ID="ObjectDataSource1" 
                        SelectMethod="GetAllCategories" TypeName="ProductDB">
                    </asp:ObjectDataSource>
                </div>
            </div>

            <div class="form-group">
                <div class="col-xs-12 col-sm-offset-1 col-sm-9">
                    <asp:DataList ID="dlProducts" runat="server"
                        DataKeyField="ProductID" DataSourceID="ObjectDataSource2"
                        UseAccessibleHeader="true"
                        CssClass="table table-bordered table-striped table-condensed">
                        <HeaderTemplate>
                            <span class="col-xs-3">ID</span>
                            <span class="col-xs-3">Product</span>
                            <span class="col-xs-3 text-right">Unit Price</span>
                            <span class="col-xs-3 text-right">On Hand</span>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblID" runat="server"
                                Text='<%# Eval("ProductID") %>' CssClass="col-xs-3" />
                            <asp:Label ID="lblName" runat="server"
                                Text='<%# Eval("Name") %>' CssClass="col-xs-3" />
                            <asp:Label ID="lblUnitPrice" runat="server"
                                Text='<%# Eval("UnitPrice", "{0:C}") %>' CssClass="col-xs-3 text-right" />
                            <asp:Label ID="lblOnHand" runat="server"
                                Text='<%# Eval("OnHand") %>' CssClass="col-xs-3 text-right" />
                        </ItemTemplate>
                        <HeaderStyle CssClass="bg-halloween" />
                    </asp:DataList>
                    <asp:ObjectDataSource runat="server" ID="ObjectDataSource2" 
                        SelectMethod="GetProductsByCategory" TypeName="ProductDB">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddlCategory" Name="CategoryID" 
                                PropertyName="SelectedValue" Type="String"></asp:ControlParameter>
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>  
            </div>

        </form>
    </main>
</div>
</body>
</html>