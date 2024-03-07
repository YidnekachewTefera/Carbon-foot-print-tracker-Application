<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ElectricConsumption.aspx.cs" Inherits="carbon_footprint_application.DataPage.ElectricConsumption" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="ElectricConsumption.css">
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
    <div class="report-container">
        <div class="image-container">
                <img src="carboon.png" alt="My Image">
        </div>
        <div class="form-container">
                <h1 style="color: rgb(81, 74, 73);">Electricity Consumption</h1>
                <form class="form-inputs" action="" method="post" runat="server">
                    <label for="energySource"> Energy Source:</label>
                    <select id="energySource" aria-placeholder="Select Carbon Footprint Type" runat="server">
                        <option value="solar">Solar</option>
                        <option value="naturalGas">Natural Gas</option>
                        <option value="wind">Wind</option>
                        <option value="coal">Coal</option> 
                        <option value="hydroPower">HydroPower</option>
                    </select>
                    <br />
                    <label for="vehicle">Energy Consumption: </label>
                    <input type="text" name="distance" id="distance" runat="server" placeholder="Distance Traveled" required>
                    <br>
                    <input type="submit" value="Submit" class="submit-button" onclick="resetForm()">
                    <script>
                        function resetForm() {
                            document.getElementById("myForm").reset();
                        }
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
                </form>
        </div> 
</body>
</html>
