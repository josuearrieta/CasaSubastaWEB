﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Subastas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            DataBaseConnection con = DataBaseConnection.getDatabaseConnection();
            String username = this.txt_Username.Text;
            String password = this.txt_Password.Text;
            con._UserName = username;
            Page.Response.Redirect("ParticipantsMenu.aspx");//cambia la pagina
            
        }
    }
}