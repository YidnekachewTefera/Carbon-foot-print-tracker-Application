<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransportEmission.aspx.cs" Inherits="carbon_footprint_application.DataPage.TransportEmission" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
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
    <div class="content-wrapperrrr">
           <div class="image-container">
                <img src="carboon.png" alt="My Image">
           </div>
           <div class="form-container">
                <h1>Enter The Data</h1>
                <form class="form-inputs" method="post" runat="server">
                    <label for="vehicle">Vehicle Type:</label>
                    <select id="vehicle" runat="server" aria-placeholder="Select Carbon Footprint Type">
                        <option value="car">Car</option>
                        <option value="truck">Truk</option>
                        <option value="bus">Bus</option>
                
                    </select>
                    <input type="text" name="distance" id="distance" placeholder="Distance Traveled" runat="server" required>
                    <br>
                    <label for="fuel" class="fuelLabel"> Fuel Type: </label>
                    <select id="fuel" aria-placeholder="Fuel Type" runat="server">
                        <option value="gasoline">Gasoline</option>
                        <option value="diesel">Diesel</option>
                        <option value="petrol">Petrol</option>
                        <option value="electric">Electric</option>
                    </select>
            
                    <input type="text" name="fuelEfficiency" id="fuelEfficiency" placeholder="Enter the number of gallons consumed" runat="server" required>
                    <input type="submit" value="Submit" class="submit-button" runat="server" onclick="resetForm()">
                    <div>
                
                        <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label><br />
                
                    </div>
                </form>
           </div> 
        </div>
    <script>
        function resetForm() {
            
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
</body>
</html>
