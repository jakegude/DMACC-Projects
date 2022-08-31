<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch24CategoryMaint_WCF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch24: Category Maintenance</title>
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
        <h1>Edit Categories</h1>
        <form id="form1" runat="server" class="form-horizontal">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

            <div class="row">
                <div class="col-xs-6">

                    <asp:DropDownList ID="ddlCategories" runat="server" AutoPostBack="True"
                        DataSourceID="ddlDataSource" DataTextField="LongName"
                        DataValueField="CategoryID" CssClass="form-control">
                    </asp:DropDownList>
                    <asp:ObjectDataSource runat="server" ID="ddlDataSource" 
                        SelectMethod="GetCategories" 
                        TypeName="Ch24CategoryMaint_WCF.CategoryService.CategoryServiceClient">
                    </asp:ObjectDataSource>
                    <br />

                    <asp:DetailsView ID="dvCategory" runat="server" DataKeyNames="CategoryID"
                        CssClass="table table-bordered table-condensed"
                        AutoGenerateRows="False" DataSourceID="detailsDataSource" 
                        OnItemDeleted="dvCategory_ItemDeleted"
                        OnItemInserted="dvCategory_ItemInserted" 
                        OnItemUpdated="dvCategory_ItemUpdated">
                        <Fields>
                            <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" 
                                ReadOnly="true" />
                            <asp:BoundField DataField="ShortName" HeaderText="ShortName" />
                            <asp:BoundField DataField="LongName" HeaderText="LongName" />
                            <asp:CommandField ShowInsertButton="True" ShowEditButton="True"
                                ShowDeleteButton="True" />
                        </Fields>
                    </asp:DetailsView>
                    <asp:ObjectDataSource runat="server" ID="detailsDataSource" 
                        TypeName="Ch24CategoryMaint_WCF.CategoryService.CategoryServiceClient" 
                        DataObjectTypeName="Ch24CategoryMaint_WCF.CategoryService.Category" 
                        SelectMethod="GetCategoryById" UpdateMethod="UpdateCategory" 
                        InsertMethod="InsertCategory" DeleteMethod="DeleteCategory">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="ddlCategories" 
                                PropertyName="SelectedValue" Name="id" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>

                </div>
            </div><%--end row--%>

        </form>
    </main>
</div>
</body>
</html>
