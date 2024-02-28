<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="carbon_footprint_application._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Carbon Footprint Tracker</h1>
            <image src="https://www.siegwerk.com/fileadmin/_processed_/4/6/csm_SW_Carbon_footprint_9f8063814d.png"></image>
            <p class="lead">This application will take various inputs like energy consumption, transportation details, employee travel, material and waste etc., and calculate the carbon footprint. The application will also present this data in an easy-to-understand format</p>
            <p class="lead">
Carbon Footprint Tracker application is a tool that help you estimate and track your personal impact on the environment, specifically focusing on greenhouse gas emissions. These emissions are often measured in carbon dioxide equivalents (CO2e), which represent the global warming potential of different gases.</p>
            <p><a href="/Account/login" class="btn btn-primary bg-success">Log In </a></p>
        </section>

        <div class="row">
           
        </div>
    </main>

</asp:Content>
