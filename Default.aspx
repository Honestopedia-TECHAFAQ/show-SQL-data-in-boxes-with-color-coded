<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" MasterPageFile="~/Site.Master" %>
<%@ MasterType VirtualPath="~/Site.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <input type="text" id="search-box" placeholder="Search..." onkeyup="filterData()" />
    </div>
    <div id="data-container" runat="server"></div>
</asp:Content>
