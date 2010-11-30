using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
    }

    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        #region ["Method FormsAutentication"]
            //FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

            //string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            //if (String.IsNullOrEmpty(continueUrl))
            //{
            //    continueUrl = "~/";
            //}
            //Response.Redirect(continueUrl);
        #endregion
        string continueUrl = "";
        Model.User _userM = new Model.User();
        FAMIS_BLL.User _userB = new FAMIS_BLL.User();

        _userM.Login = RegisterUser.UserName;
        _userM.Password = RegisterUser.Password;
        string sRet = _userB.Add(_userM);
        if (sRet == "")
        {
            continueUrl = "~/";
        }
        Response.Redirect(continueUrl);
    }

}
