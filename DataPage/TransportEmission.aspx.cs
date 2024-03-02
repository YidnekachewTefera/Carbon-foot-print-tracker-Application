using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using carbon_footprint_application;
namespace carbon_footprint_application.DataPage
{
    public partial class TransportEmission : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var calculator = new calculator();
            if (Request.HttpMethod == "POST")
            {
                string vType = vehicle.Value;
                string distanceTraveled = distance.Value;
                string fuelType = fuel.Value;
                string fuelConsumption = fuelEfficiency.Value;
                double result=0;
                if (fuelType == "diesel")
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
                /*Response.Redirect("Reports.aspx?data=" + Server.UrlEncode(vType)); %>
                Response.Redirect("Reports.aspx?data=" + Server.UrlEncode(fuelType));
                Response.Redirect("Reports.aspx?data=" + Server.UrlDecode(distanceTraveled));
                Response.Redirect("Reports.aspx?data=" + Server.UrlDecode(fuelConsumption));
                Response.Redirect("Reports.aspx?data=" + Server.UrlDecode(result.ToString()));
                */

                // Display the received data on the page
                lblUsername.Text = $"We have received your data of: {vType} Emission which had a distance traveled: {distanceTraveled}KM with fuel type: {fuelType} and fuel consumption of: {fuelConsumption}Literes";
            }
        }
    }
   
}