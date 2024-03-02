using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carbon_footprint_application.DataPage
{
    public partial class Reports : System.Web.UI.Page
    {
        private object lblData;

        protected void Page_Load(object sender, EventArgs e)
        {
            string data = Request.QueryString["data"];

            // Display data on the page
            
                // Assuming you have a label control named lblData on DestinationPage.aspx
                
            
        }

    }
}