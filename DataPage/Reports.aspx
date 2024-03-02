<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="carbon_footprint_application.DataPage.Reports" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="reportStyle.css">
</head>
<body>
    <div id="mySidenav" class="sidenav">
        <a href="javascript:void(0)" class="closebtn" onclick="closeNav()">&times;</a>
        <a runat="server" href="~/">Home</a>
        <a runat="server" href="./ElectricConsumption">Electric Consumption</a>
        <a runat="server" href="./TransportEmission">Transport Emission</a>
        <a runat="server" href="./Reports">Reports</a>
        <a href="../About">about</a>
        <a href="../Contact">Contact</a>
      </div>
      
      <!-- Use any element to open the sidenav -->
      
      
      <!-- Add all page content inside this div if you want the side nav to push page content to the right (not used if you only want the sidenav to sit on top of the page -->
      
    <div class="main-headerr">
        <div class="iconnn-container" onclick="openNav()">
            <div class="bar1"></div>
            <div class="bar2"></div>
            <div class="bar3"></div>
        </div>
        <h1 style="margin-left: 50px;">
            Carbon Footprint Calculator
        </h1>
        
    </div>
    
    </div>
    <div class="main-containerrrrr">
        
        <div class="image-container">
                <img src="report.jpg" alt="My Image">
        </div>
        <div class="report-container">
            <div class="form-container">
                    <h1 style="color: rgb(81, 74, 73);">Transport Emission report:</h1>
                    <form class="form-inputs" action="#" method="post">
                        <h2>Vehicle Type: </h2>
                        
                        <h2>Distance:</h2>
                        <h2>Fuel Type: </h2>
                        <h2>Fuel Efficiency: </h2>
                        <h2>Entry Date: </h2>
                    </form>
                <asp:Label ID="lblData" runat="server" Text=""></asp:Label>
                    
            </div>
            <div style="margin-top: -45px;" class="form-container">
                <h1 style="color: rgb(81, 74, 73);">Electricity Consumption Report</h1>
                <form class="form-inputs" action="#" method="post">
                    <h2>Energy Source:</h2>
                    <h2>Electricity Usage: </h2>
                    <h2>Entry Date:</h2>
                    <h2></h2>
                </form>
            </div>
    </div>
    <script>
        function myFunction(x) {
            x.classList.toggle("change");
        }
        function openNav() {
            document.getElementById("mySidenav").style.width = "250px";
            document.getElementById("main").style.marginLeft = "250px";
            x.classList.toggle("change");
            document.getElementById("mySidenav").style.width = "250px";
            document.body.style.backgroundColor = "rgba(0,0,0,0.4)";
            }

            /* Set the width of the side navigation to 0 and the left margin of the page content to 0 */
            function closeNav() {
            document.getElementById("mySidenav").style.width = "0";
            document.getElementsByClassName("main-containerrrrr").style.marginLeft = "0";
            document.getElementById("mySidenav").style.width = "0";
            document.getElementsByClassName("main-containerrrrr").style.marginLeft = "0";
            document.body.style.backgroundColor = "white";
            x.classList.toggle("change");
            }
    </script>
</div> 
</body>
</html>
