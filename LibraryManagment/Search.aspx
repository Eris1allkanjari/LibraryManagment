<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Search.aspx.cs" Inherits="LibraryManagment.Search" %>



<asp:Content ID="SearchContent" runat="server" ContentPlaceHolderID="MainContent">
     <div>
            <asp:GridView ID="searchGridView" runat="server" 
                AutoGenerateColumns="false"
                OnRowDeleting="fshijLiber"
                datakeynames="id"
                OnRowUpdated="libratGridView_RowUpdated">
                <Columns>
                    <asp:ImageField DataImageUrlField="imageUrl" NullDisplayText="No Image available" HeaderText="Foto" ControlStyle-Height="120px" ControlStyle-Width="80px"></asp:ImageField>
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
