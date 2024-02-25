<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="carbon_footprint_application.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Carbon Footprint Tracker.</h3>
        <address>
            Ethiopia, Addis Abeba<br />
            Bole, AR 925321014<br />
            <abbr title="Phone">P:</abbr>
            New
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@TeamCarmineAndAuburn.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@TeamCarmineAndAuburn.com</a>
        </address>
    </main>
</asp:Content>
