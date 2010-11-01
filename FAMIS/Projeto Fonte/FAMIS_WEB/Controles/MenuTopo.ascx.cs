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

public partial class Controles_MenuTopo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Model.User mUser = new Model.User();
        mUser = (Model.User)HttpContext.Current.Session["UsuarioLogado"];
        lblUsuario.Text = mUser.Last_name + ", " + mUser.First_name;
    }
}
