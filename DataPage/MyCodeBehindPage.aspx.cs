using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace carbon_footprint_application.DataPage
{
    public partial class MyCodeBehindPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.HttpMethod == "POST")
            {
                string username = Request.Form["username"];
                string email = Request.Form["email"];
                string message = Request.Form["message"];

                // Display the received data on the page
                lblUsername.Text = $"Username: {username}";
                lblEmail.Text = $"Email: {email}";
                lblMessage.Text = $"Message: {message}";
            }
        }
    }
}