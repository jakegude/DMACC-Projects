<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch14ProductList.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch14: Product List</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
<div class="container">
    <header class="jumbotron"><%-- image set in site.css --%></header>
    <main class="row">
        <form id="form1" runat="server">
            <div class="col-xs-12 table-responsive">
                <asp:GridView ID="grdProducts" runat="server" 
                    AutoGenerateColumns="False" DataKeyNames="ProductID" 
                    DataSourceID="SqlDataSource1" AllowPaging="True" PageSize="8" 
                    AllowSorting="True" OnPreRender="grdProducts_PreRender"
                    CssClass="table table-bordered table-striped table-condensed">
                    <Columns>
                        <asp:BoundField DataField="ProductID" HeaderText="ID" 
                            ReadOnly="True" SortExpression="ProductID">
                            <ItemStyle CssClass="col-xs-1" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Name" HeaderText="Name" 
                            SortExpression="Name">
                            <ItemStyle CssClass="col-xs-4" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CategoryID" HeaderText="Category" 
                            SortExpression="CategoryID, Name">
                            <ItemStyle CssClass="col-xs-2" />
                        </asp:BoundField>
                        <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" 
                            DataFormatString="{0:c}">
                            <ItemStyle CssClass="col-xs-2 text-right" />
                            <HeaderStyle CssClass="text-right" />
                        </asp:BoundField>
                        <asp:BoundField DataField="OnHand" HeaderText="On Hand">
                            <ItemStyle CssClass="col-xs-2 text-right" />
                            <HeaderStyle CssClass="text-right" />
                        </asp:BoundField>
                    </Columns>
                    <HeaderStyle CssClass="bg-halloween" />
                    <PagerSettings Mode="NumericFirstLast" />
                    <PagerStyle CssClass="pagerStyle" BackColor="#8C8C8C" HorizontalAlign="Center" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:HalloweenConnection %>" 
                    SelectCommand="SELECT [ProductID], [Name], [CategoryID], 
                        [UnitPrice], [OnHand] FROM [Products]">
                </asp:SqlDataSource>    
            </div>  
        </form>
    </main>
</div>
</body>
</html>