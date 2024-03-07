using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using carbon_footprint_application;
using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing.Printing;
namespace carbon_footprint_application.DataPage
{
    public partial class TransportEmission : System.Web.UI.Page
    {
        public static List<DataClass> Emission = new List<DataClass>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            DataClass TransportEmissionData = new DataClass();
            

            if (Request.HttpMethod == "POST")
            {
                string vType = vehicle.Value;
                string distanceTraveled = distance.Value;
                string fuelType = fuel.Value;
                string fuelConsumption = fuelEfficiency.Value;
                TransportEmissionData.VehicleType = vType;
                TransportEmissionData.DistanceTravele = distanceTraveled+"kM";
                TransportEmissionData.FuelType = fuelType;
                distance.Value = "";
                fuelEfficiency.Value = "";
                if (fuelType == "electric")
                {
                    TransportEmissionData.FuelConsumption = fuelConsumption + " " + "KWH";
                }
                else
                {
                    TransportEmissionData.FuelConsumption = fuelConsumption + " " + "Literes";
                }
                TransportEmissionData.dateAndTime = DateTime.Today.ToString();
                if(fuelType=="gasoline" || fuelType == "petrol")
                {
                    TransportEmissionData.carbonFootPrint= calculator.gasolineOrPetrol(distanceTraveled, fuelConsumption).ToString();
                }
                
                else if (fuelType == "diesel")
                {
                    TransportEmissionData.carbonFootPrint = calculator.diesel(distanceTraveled, fuelConsumption).ToString();
                }
                else if(fuelType == "electric")
                {
                    TransportEmissionData.carbonFootPrint = calculator.electricCars(distanceTraveled).ToString();
                }

                Emission.Add(TransportEmissionData);
                string jsonString = JsonConvert.SerializeObject(Emission);
                //I will come back and play with you after Friday
                //string modifiedJson = jObject.ToString();
                //Console.WriteLine(jsonString);
                
                //*double result=0;
                /*if (fuelType == "diesel")
                {
                   result = calculator.diesel(distanceTraveled, fuelConsumption);
                }
                else if(fuelType=="petrol"|| fuelType == "gasoline")
                {
                   result = calculator.diesel(distanceTraveled, fuelConsumption);
                }
                else
                {
                   result = calculator.Electric(distanceTraveled,fuelConsumption);
                }
                */
                // Display the received data on the page
                //string filePath = "TransportEmission.txt";
                //lblUsername.Text = $"{modifiedJson}";
                //string dataStoragePath = Server.MapPath("~/Files/" + filePath);
                /*if (File.Exists(dataStoragePath))
                {
                    try
                    {
                  //      File.AppendAllText(dataStoragePath, modifiedJson);
                        File.AppendAllText(dataStoragePath, jsonString);
                        lblUsername.Text = $" Congrats the data has been updated {File.ReadAllText(dataStoragePath)}";
                        
                    }
                    catch
                    {
                        lblUsername.Text = "Some Error Happened";
                    }
                }
                else
                {
                    try
                    {
                        File.Create(Server.MapPath("~/Files/") + "TransportEmission.txt");
                    //    File.AppendAllText(dataStoragePath,modifiedJson);
                        lblUsername.Text = $"{File.ReadAllText(dataStoragePath)}";
                    }
                    catch
                    {
                        lblUsername.Text = "The file doesn't exist and also creating the file is facing a problem";
                    }
                }

                /*if (File.Exists(filePath)) { 
                    try {
                        File.WriteAllText(filePath, dataReceived);
                        lblUsername.Text = $"I have received your data of: {vType} Emission which had a distance traveled: {distanceTraveled}KM with fuel type: {fuelType} and fuel consumption of: {fuelConsumption}Literes";

                    }
                    catch {
                        lblUsername.Text = "Unfortunatelly unknown error happend";
                    }
                }
                else
                {
                    
                    try
                    {
                        string filePathh = Server.MapPath("~/Files/") + "ElectricityEmission.txt";
                        
                        File.WriteAllText(filePathh, dataReceived);
                        lblUsername.Text = "successfully created a file and add the result inside that file";
                    }
                    catch
                    {
                        lblUsername.Text = "unknown error has happend";
                    }
                }
                */

                //lblUsername.Text = $"We have received your data of: {vType} Emission which had a distance traveled: {distanceTraveled}KM with fuel type: {fuelType} and fuel consumption of: {fuelConsumption}Literes";
            }
            
        }
    }
    public class DataClass
    {
        public string VehicleType { get; set; }
        public string DistanceTravele { get; set; }
        public string FuelType { get; set; }
        public string FuelConsumption { get; set; }

        public string dateAndTime {  get; set; }
        public string carbonFootPrint {  get; set; }
    }

}