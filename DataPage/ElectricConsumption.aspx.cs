using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carbon_footprint_application.DataPage
{
    public partial class ElectricConsumption : System.Web.UI.Page
    {
        public static List<ElectricData> electricEmission = new List<ElectricData>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ElectricData electricData= new ElectricData();
            if (Request.HttpMethod == "POST")
            {
                string energyType = energySource.Value;
                string Consumption = distance.Value;
                electricData.energyType = energyType;
                electricData.Consumption = Consumption+"KW";
                distance.Value = "";
                if (energyType == "solar")
                {
                    electricData.carbonFootPrint = calculator.hydroPower(energyType, Consumption).ToString();
                }
                else if(energyType == "coal")
                {
                    electricData.carbonFootPrint = calculator.coal(energyType, Consumption).ToString();
                }
                else if(energyType=="naturalGas")
                {
                    electricData.carbonFootPrint = calculator.naturalGas(energyType, Consumption).ToString();
                }
                else if(energyType == "hydroPower")
                {
                    electricData.carbonFootPrint = calculator.hydroPower(energyType,Consumption).ToString();
                }
                else if (energyType == "wind")
                {
                    electricData.carbonFootPrint = calculator.wind(energyType, Consumption).ToString();
                }
                electricData.dateAndTime = (DateTime.Today).ToString();
                electricEmission.Add(electricData);
                string jsonString = JsonConvert.SerializeObject(electricEmission);
            }
        }
    }
    public class ElectricData
    {
        public string energyType { get; set; }
        public string Consumption { get; set; }
        public string dateAndTime { get; set; }
        public string carbonFootPrint { get; set; }
    }
}