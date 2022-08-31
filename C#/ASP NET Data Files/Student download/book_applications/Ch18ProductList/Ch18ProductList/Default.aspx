<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch18ProductList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch18: Product List</title>
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

            <div class="row">
                <div class="col-xs-12">
                    <h1>Product List</h1>
                    <div class="form-group">
                        <label class="col-sm-3 text-left">Choose a category:</label>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="ddlCategory" runat="server"
                                ItemType="Ch18ProductList.Models.Category"
                                SelectMethod="ddlCategory_GetData" AutoPostBack="true" 
                                DataValueField="CategoryID" DataTextField="LongName"
                                CssClass="form-control"></asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-xs-12 table-responsive">
                    <asp:GridView ID="grdProducts" runat="server" 
                        AutoGenerateColumns="false" DataKeyNames="ProductID"
                        CssClass="table table-bordered table-striped table-condensed" 
                        OnPreRender="grdProducts_PreRender" 
                        AllowSorting="true" AllowPaging="true" PageSize="4" 
                        ItemType="Ch18ProductList.Models.Product" 
                        SelectMethod="grdProducts_GetData">
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="ID">
                                <ItemStyle CssClass="col-xs-2" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Name" DataField="Name" 
                                SortExpression="Name">
                                <ItemStyle CssClass="col-xs-3" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Unit Price" DataField="UnitPrice" 
                                SortExpression="UnitPrice" DataFormatString="{0:C}">
                                <ItemStyle CssClass="col-xs-2 text-right" />
                                <HeaderStyle CssClass="text-right" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="On Hand" DataField="OnHand" 
                                SortExpression="OnHand">
                                <ItemStyle CssClass=" col-xs-2 text-right" />
                                <HeaderStyle CssClass="text-right" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="Total Inventory"> 
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" 
                                        Text='<%# (Item.UnitPrice * Item.OnHand)
                                                   .ToString("c") %>'>
                                    </asp:Label>
                                </ItemTemplate>
                                <ItemStyle CssClass="col-xs-3 text-right" />
                                <HeaderStyle CssClass="text-right" />
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle CssClass="bg-halloween" />
                        <PagerStyle CssClass="pagerStyle" BackColor="#8c8c8c" HorizontalAlign="Center" />
                    </asp:GridView>
                </div></div>

        </form>
    </main>
</div>
</body>
</html>