using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Authentication : System.Web.UI.Page
{
    string strUserName;
    string strPassword;

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["User"] = null;
    }
    protected void Enter_Click(object sender, EventArgs e) {
        //normally we would want to hash a password then store/check in a database
        //but this is just to show basic functionality
        strUserName = tbUserName.Text.ToString().ToUpper();
        strPassword = tbPassword.Text.ToString().ToUpper();

        if (strUserName != "ABCD" || strPassword != "1234") {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage",
                "alert('Please enter the correct credientials')", true);
        }
        else {
            //depending on the application, there can be more than one type of user
            //store this information in a session variable to determine what a certain
            //      kind of information a certain kind of user can see
            Session["User"] = "User01";
            Response.Redirect("CodingChallengeMain.aspx");
        }
    }
}