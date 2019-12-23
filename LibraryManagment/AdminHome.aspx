<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="LibraryManagment.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="libratGridView" runat="server" AutoGenerateColumns="false" OnRowDeleting="fshijLiber" >
                <Columns>
                    <asp:TemplateField >
                        <ItemTemplate>
                            <asp:HiddenField ID="liberID" runat="server" Value='<%#DataBinder.Eval(Container.DataItem, "id") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="titull" HeaderText="Titulli"  />
                    <asp:BoundField DataField="autori" HeaderText="Autori" />
                    <asp:BoundField DataField ="viti" HeaderText="Viti i botimit" />
                    <asp:BoundField DataField="cmimi" HeaderText="Cmimi" />



                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
