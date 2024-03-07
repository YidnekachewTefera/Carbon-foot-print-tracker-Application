using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carbon_footprint_application.DataPage
{
   
    public partial class Reports : System.Web.UI.Page
    {
        


        protected void Page_Load(object sender, EventArgs e)
        {
            string data = Request.QueryString["data"];

            // Display data on the page

            // Assuming you have a label control named lblData on DestinationPage.aspxtry{
            string filePath1 = "TransportEmission.txt";
            string filePath2 = "ElectricityConsumption.txt";
            string dataStoragePath1 = Server.MapPath("~/Files/" + filePath1);
            string dataStoragePath2 = Server.MapPath("~/Files/" + filePath2);
            string readd = File.ReadAllText(dataStoragePath1);
            
            TransportEmissionnn.DataSource = TransportEmission.Emission;

            TransportEmissionnn.DataBind();

            ElectricConsumptionnnnn.DataSource = ElectricConsumption.electricEmission;
            
            ElectricConsumptionnnnn.DataBind();
            /*if (File.Exists(dataStoragePath1))
            {
                
            }
            else
            {
                //Error handling
            }
            if (File.Exists(filePath2))
            {

            }
            else
            {

            }
            */

        }

    }
}