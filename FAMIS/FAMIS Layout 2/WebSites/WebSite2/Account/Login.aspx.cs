using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {

        Model.User _mUser = new Model.User();
        FAMIS_BLL.User _user = new FAMIS_BLL.User();

        _mUser.Login = LoginUser.UserName;
        _mUser.Password = LoginUser.Password;

        Model.User _Mserb = new Model.User();

        _Mserb = _user.Validar(_mUser);
        HttpContext.Current.Session["labelUser"] = _mUser.Last_name.ToString() + _mUser.First_name.ToString(); 
        //LoginUser.UserNameLabelText 
        Response.Redirect("http://localhost:1583/WebSite2"); //"~/"
   }
}
