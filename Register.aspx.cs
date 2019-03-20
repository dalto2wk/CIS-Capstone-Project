﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void RegisterBtnClick(object sender, EventArgs e)
    {
        //try
        //{


            System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["Project"].ConnectionString);
            sc.Open();

            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand
            {
                Connection = sc,
                CommandText = "Insert into Employer values (@businessName, @size, @industry, @description, @cpTitle, @cpName, @cpUserName, @cpPassword, @LastUpdatedBy, GETDATE())"
            };

            String businessName = CompanyName.Value;
            String industryName = industry.Value;
            String businessSize = size.Value;
            String desc = description.Value;
            String cpName = ContactName.Value;
            String cpTitle = title.Value;
            String cpUsername = username.Value;
            String cpPassword = password.Value;
            String cpPhone = Phone.Value;
            String cpEmail = email.Value;
        Employer emp = new Employer(businessName, Convert.ToInt32(businessSize), industryName, desc, cpName, cpUsername, cpPassword, cpEmail, cpPhone, 1);

        insert.Parameters.AddWithValue("@businessName", businessName);
            insert.Parameters.AddWithValue("@size", businessSize);
            insert.Parameters.AddWithValue("@industry", industryName);
            insert.Parameters.AddWithValue("@description", desc);
            insert.Parameters.AddWithValue("@cpTitle", cpTitle);   
            insert.Parameters.AddWithValue("@cpName", cpName);
            insert.Parameters.AddWithValue("@cpUsername", cpUsername );
            insert.Parameters.AddWithValue("@cpPassword", cpPassword);
            insert.Parameters.AddWithValue("@LastUpdatedBy", "484Team");
            insert.ExecuteNonQuery();

            //double check that this works and add some emp id is getting retrieved from db
            

        //}
        //catch(Exception ex)
        //{

        //}
    }
}

