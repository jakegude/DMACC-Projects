<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch14CategoryMaintenance.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch14: Category Maintenance</title>
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

        <form id="form1" runat="server" class="form-horizontal">

            <div class="col-xs-12 table-responsive">
                <h1>Category Maintenance</h1>
                <asp:GridView ID="grdCategories" runat="server"
                    AutoGenerateColumns="False" DataKeyNames="CategoryID"
                    DataSourceID="SqlDataSource1"
                    CssClass="table table-bordered table-condensed table-hover"
                    OnPreRender="grdCategories_PreRender" 
                    OnRowDeleted="grdCategories_RowDeleted" 
                    OnRowUpdated="grdCategories_RowUpdated">
                    <Columns>
                        <asp:BoundField DataField="CategoryID" HeaderText="ID" 
                            ReadOnly="True">
                            <ItemStyle CssClass="col-xs-1" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ShortName" HeaderText="Short Name" 
                            SortExpression="ShortName">
                            <ItemStyle CssClass="col-xs-3" />
                        </asp:BoundField>
                        <asp:BoundField DataField="LongName" HeaderText="Long Name" 
                            SortExpression="LongName">
                            <ItemStyle CssClass="col-xs-5" />
                        </asp:BoundField>
                        <asp:CommandField CausesValidation="False" ShowEditButton="True">
                            <ItemStyle CssClass="col-xs-1 text-danger" />
                        </asp:CommandField>
                        <asp:CommandField CausesValidation="False" ShowDeleteButton="True">
                            <ItemStyle CssClass="col-xs-1" /> 
                        </asp:CommandField>
                    </Columns>
                    <HeaderStyle CssClass="bg-halloween" />
                    <AlternatingRowStyle CssClass="altRow" />
                    <EditRowStyle CssClass="warning" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                    ConnectionString="<%$ ConnectionStrings:HalloweenConnection %>"
                    ConflictDetection="CompareAllValues" 
                    OldValuesParameterFormatString="original_{0}"
                    SelectCommand="SELECT [CategoryID], [ShortName], [LongName] 
                        FROM [Categories]"
                    DeleteCommand="DELETE FROM [Categories] 
                        WHERE [CategoryID] = @original_CategoryID 
                          AND [ShortName] = @original_ShortName 
                          AND [LongName] = @original_LongName" 
                    InsertCommand="INSERT INTO [Categories] 
                        ([CategoryID], [ShortName], [LongName]) 
                        VALUES (@CategoryID, @ShortName, @LongName)" 
                    UpdateCommand="UPDATE [Categories] 
                          SET [ShortName] = @ShortName, 
                              [LongName] = @LongName 
                        WHERE [CategoryID] = @original_CategoryID 
                          AND [ShortName] = @original_ShortName 
                          AND [LongName] = @original_LongName">
                    <DeleteParameters>
                        <asp:Parameter Name="original_CategoryID" Type="String"></asp:Parameter>
                        <asp:Parameter Name="original_ShortName" Type="String"></asp:Parameter>
                        <asp:Parameter Name="original_LongName" Type="String"></asp:Parameter>
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="CategoryID" Type="String"></asp:Parameter>
                        <asp:Parameter Name="ShortName" Type="String"></asp:Parameter>
                        <asp:Parameter Name="LongName" Type="String"></asp:Parameter>
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="ShortName" Type="String"></asp:Parameter>
                        <asp:Parameter Name="LongName" Type="String"></asp:Parameter>
                        <asp:Parameter Name="original_CategoryID" Type="String"></asp:Parameter>
                        <asp:Parameter Name="original_ShortName" Type="String"></asp:Parameter>
                        <asp:Parameter Name="original_LongName" Type="String"></asp:Parameter>
                    </UpdateParameters>
                </asp:SqlDataSource>    
            </div>

            <div class="col-xs-12">
                <p>To create a new category, enter the category information 
                    and click Add New Category</p>
                <p><asp:Label ID="lblError" runat="server" EnableViewState="false" 
                        CssClass="text-danger"></asp:Label></p>

                <div class="form-group">
                    <label for="txtID" class="col-sm-2">ID</label>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtID" runat="server" MaxLength="10" 
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-offset-3 col-sm-4">
                        <asp:RequiredFieldValidator ID="rfvID" runat="server" 
                            ControlToValidate="txtID" CssClass="text-danger" 
                            ErrorMessage="ID is a required field">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <label for="txtShortName" class="col-sm-2">Short Name</label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="txtShortName" runat="server" MaxLength="15" 
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-offset-2 col-sm-4">
                        <asp:RequiredFieldValidator ID="rfvShortName" runat="server" 
                        ControlToValidate="txtShortName" CssClass="text-danger" 
                        ErrorMessage="Short Name is a required field">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>              
                <div class="form-group">
                    <label for="txtLongName" class="col-sm-2">Long Name</label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="txtLongName" runat="server" MaxLength="50" 
                            CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="col-sm-4">
                        <asp:RequiredFieldValidator ID="rfvLongName" runat="server" 
                        ControlToValidate="txtLongName" CssClass="text-danger" 
                        ErrorMessage="Long Name is a required field">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>

                <asp:Button ID="btnAdd" runat="server" Text="Add New Category" 
                    CssClass="btn" OnClick="btnAdd_Click" />
            </div>  

        </form>
    </main>
</div>
</body>
</html>