using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using FAMIS_BLL;
using Model;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, ImageClickEventArgs e)
    {
        string strScript = "";
        Model.User user = new Model.User();
        user.Login = this.txtUsuario.Text;
        user.Password = this.txtSenha.Text;

        FAMIS_BLL.User UserBll = new FAMIS_BLL.User();

        user = UserBll.Validar(user);

        if (user.User_id == 0)
        {
            strScript = "javascript:alert('Incorect user or password');";
        }
        else
        {
            HttpContext.Current.Session["UsuarioLogado"] = user;
            strScript = "start('" + user.Login.ToString() + "');";
        }

        ClientScript.RegisterClientScriptBlock(this.GetType(), Guid.NewGuid().ToString(), strScript, true);
    }

}
