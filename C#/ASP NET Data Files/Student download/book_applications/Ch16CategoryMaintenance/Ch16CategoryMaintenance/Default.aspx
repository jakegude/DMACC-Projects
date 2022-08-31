<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ch16CategoryMaintenance.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ch16: Category Maintenance</title>
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

            <div>
                <h1>Category Maintenance</h1>
                <asp:ListView ID="ListView1" runat="server" 
                    DataSourceID="SqlDataSource1" DataKeyNames="CategoryID" 
                    InsertItemPosition="LastItem">
                    <EditItemTemplate>
                        <tr style="">
                            <td>
                                <asp:Label ID="CategoryIDLabel1" runat="server" 
                                    Text='<%# Eval("CategoryID") %>' />
                            </td>
                            <td>
                                <asp:TextBox ID="ShortNameTextBox" runat="server" 
                                    Text='<%# Bind("ShortName") %>' 
                                    CssClass="form-control" />
                            </td>
                            <td>
                                <asp:TextBox ID="LongNameTextBox" runat="server" 
                                    Text='<%# Bind("LongName") %>' 
                                    CssClass="form-control" />
                            </td>
                            <td>
                                <asp:LinkButton ID="UpdateButton" runat="server" 
                                    CommandName="Update" Text="Update" />
                                <asp:LinkButton ID="CancelButton" runat="server" 
                                    CommandName="Cancel" Text="Cancel" />
                            </td>
                        </tr>
                    </EditItemTemplate>
                    <EmptyDataTemplate>
                        <table runat="server" style="">
                            <tr>
                                <td>No data was returned.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <InsertItemTemplate>
                        <tr style="">
                            <td>
                                <asp:TextBox ID="CategoryIDTextBox" runat="server" 
                                    Text='<%# Bind("CategoryID") %>' 
                                    CssClass="form-control" />
                            </td>
                            <td>
                                <asp:TextBox ID="ShortNameTextBox" runat="server" 
                                    Text='<%# Bind("ShortName") %>' 
                                    CssClass="form-control" />
                            </td>
                            <td>
                                <asp:TextBox ID="LongNameTextBox" runat="server" 
                                    Text='<%# Bind("LongName") %>' 
                                    CssClass="form-control" />
                            </td>
                            <td>
                                <asp:LinkButton ID="InsertButton" runat="server" 
                                    CommandName="Insert" Text="Insert" />
                                <asp:LinkButton ID="CancelButton" runat="server" 
                                    CommandName="Cancel" Text="Clear" />
                            </td>
                        </tr>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <tr style="">
                            <td>
                                <asp:Label ID="CategoryIDLabel" runat="server" 
                                    Text='<%# Bind("CategoryID") %>' />
                            </td>
                            <td>
                                <asp:Label ID="ShortNameLabel" runat="server" 
                                    Text='<%# Bind("ShortName") %>' />
                            </td>
                            <td>
                                <asp:Label ID="LongNameLabel" runat="server" 
                                    Text='<%# Bind("LongName") %>' />
                            </td>
                            <td>
                                <asp:LinkButton ID="EditButton" runat="server" 
                                    CommandName="Edit" Text="Edit" />
                                <asp:LinkButton ID="DeleteButton" runat="server" 
                                    CommandName="Delete" Text="Delete" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table>
                            <tr>
                                <td>
                                    <table id="itemPlaceholderContainer" 
                                        class="table table-bordered table-striped table-condensed">
                                      <thead>
                                        <tr style="">
                                            <th>CategoryID</th>
                                            <th>ShortName</th>
                                            <th>LongName</th>
                                            <th></th>
                                        </tr>
                                      </thead>
                                      <tbody>
                                        <tr id="itemPlaceholder" runat="server">
                                        </tr>
                                      </tbody>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td style=""></td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:ListView>
                <asp:SqlDataSource runat="server" ID="SqlDataSource1" 
                    ConflictDetection="CompareAllValues" 
                    OldValuesParameterFormatString="original_{0}" 
                    ConnectionString='<%$ ConnectionStrings:HalloweenConnection %>' 
                    DeleteCommand="DELETE FROM [Categories] 
                        WHERE [CategoryID] = @original_CategoryID 
                        AND [ShortName] = @original_ShortName 
                        AND [LongName] = @original_LongName" 
                    InsertCommand="INSERT INTO [Categories] 
                        ([CategoryID], [ShortName], [LongName]) 
                        VALUES (@CategoryID, @ShortName, @LongName)" 
                    SelectCommand="SELECT [CategoryID], [ShortName], [LongName] 
                        FROM [Categories] ORDER BY [LongName]" 
                    UpdateCommand="UPDATE [Categories] 
                        SET [ShortName] = @ShortName, [LongName] = @LongName 
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

        </form>
    </main>
</div>
</body>
</html>