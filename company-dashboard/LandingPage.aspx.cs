﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class company_dashboard_LandingPage : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        loggedInUser.Text = Session["username"].ToString();
        //helloEmpName.Text = Session["EmpName"].ToString();

        if(IsPostBack == true || IsPostBack == false)
        {
            loggedInUser.Text = Session["username"].ToString();
            //helloEmpName.Text = Session["EmpName"].ToString();
        }
        recentApplicationsGV.UseAccessibleHeader = true;
        recentApplicationsGV.HeaderRow.TableSection = TableRowSection.TableHeader;
        
    }
}