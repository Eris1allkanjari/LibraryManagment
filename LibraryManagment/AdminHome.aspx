<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AdminHome.aspx.cs" Inherits="LibraryManagment.AdminHome" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
           <br />
            <br />
        <div>
            <asp:GridView ID="libratGridView" runat="server" 
                AutoGenerateColumns="false"
                OnRowDeleting="fshijLiber"
                datakeynames="id">
                <Columns>
                    <asp:BoundField DataField="titull" HeaderText="Titulli"  />
                    <asp:BoundField DataField="autori" HeaderText="Autori" />
                    <asp:BoundField DataField ="viti" HeaderText="Viti i botimit" />
                    <asp:BoundField DataField="cmimi" HeaderText="Cmimi" />
                    <asp:CommandField ShowDeleteButton =" true" />


                </Columns>

            </asp:GridView>
        </div>
    
    </asp:Content>
