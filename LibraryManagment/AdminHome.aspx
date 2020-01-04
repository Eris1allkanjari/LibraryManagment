<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AdminHome.aspx.cs" Inherits="LibraryManagment.AdminHome" %>


<asp:Content ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet"  type="text/css" href="Content/CSS/adminHome.css" />
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
           <br />
            <br />
        <div>
            <asp:GridView ID="libratGridView" runat="server" 
                AutoGenerateColumns="false"
                OnRowDeleting="fshijLiber"
                OnRowEditing="libratGridView_RowEditing"
                OnRowCancelingEdit="libratGridView_RowCancelingEdit"
                OnRowUpdating="libratGridView_RowUpdate"
                datakeynames="id">
                <Columns>
                    <asp:ImageField DataImageUrlField="imageUrl" NullDisplayText="No Image available" HeaderText="Foto" ControlStyle-Height="120px" ControlStyle-Width="80px" ControlStyle-CssClass="bookImage"></asp:ImageField>
                    <asp:BoundField DataField="titull" HeaderText="Titulli"  />
                    <asp:BoundField DataField="autori" HeaderText="Autori" />
                    <asp:BoundField DataField ="viti" HeaderText="Viti i botimit" />
                    <asp:BoundField DataField="cmimi" HeaderText="Cmimi" />
                    <asp:CommandField ShowEditButton = "true" />
                    <asp:CommandField ShowDeleteButton = "true" />


                </Columns>

            </asp:GridView>
            <asp:Label ID="message" runat="server" Text="Nuk u gjend asnje rezultat" Visible="false"></asp:Label>
        </div>
    
    </asp:Content>
