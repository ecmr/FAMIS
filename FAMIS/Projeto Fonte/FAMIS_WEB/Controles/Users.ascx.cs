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
using System.Collections.Generic;

public partial class Controles_Users : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PreencheGrid();
            txtFirstName.Focus();
        }
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtUser_id.Text))
        {// new
            try
            {
                Model.User _user = new Model.User();
                _user.Active = Convert.ToInt32(DropDownActive.SelectedValue.ToString());
                _user.Email = TxtEmail.Text;
                _user.First_name = txtFirstName.Text;
                _user.Last_name = TxtLastName.Text;
                _user.Login = txtUserName.Text;
                _user.Password = TxtPassword.Text;

                FAMIS_BLL.User _userAdd = new FAMIS_BLL.User();
                _userAdd.Add(_user);
                txtFirstName.Text = "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        else
        {// if update client
            try
            {
                Model.User _user = new Model.User();
                _user.Active = Convert.ToInt32(DropDownActive.SelectedValue.ToString());
                _user.Email = TxtEmail.Text;
                _user.First_name = txtFirstName.Text;
                _user.Last_name = TxtLastName.Text;
                _user.Login = txtUserName.Text;
                if (!string.IsNullOrEmpty(TxtPassword.Text))
                {
                    _user.Password = TxtPassword.Text;
                }
                _user.User_id = Convert.ToInt32(txtUser_id.Text);

                FAMIS_BLL.User _userAdd = new FAMIS_BLL.User();
                _userAdd.Update(_user);
                txtUserName.Text = "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        LimpaCampos();
        PreencheGrid();
    }

    public void PreencheGrid()
    {
        FAMIS_BLL.User _user = new FAMIS_BLL.User();

        grvUser.DataSource = _user.Select(""); //lista;
        grvUser.DataBind();
        grvUser.AllowPaging = true;
        grvUser.PageSize = 5;
    }

    private void LimpaCampos()
    {
        txtUser_id.Text = "";
        txtFirstName.Text = "";
        TxtLastName.Text = "";
        TxtEmail.Text = "";
        txtUserName.Text = "";
        TxtPassword.Text = "";
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.User _user = new FAMIS_BLL.User();
        FAMIS_BLL.User _userDel = new FAMIS_BLL.User();

        List<Model.User> ListUser =
            _user.Select(" Where user_id=" + grvUser.DataKeys[grid.RowIndex].Values[0].ToString());

        TxtEmail.Text = (ListUser.ElementAt(0).Email.ToString());
        txtFirstName.Text = (ListUser.ElementAt(0).First_name.ToString());
        TxtLastName.Text = (ListUser.ElementAt(0).Last_name.ToString());
        TxtPassword.Text = ListUser.ElementAt(0).Password.ToString(); //(_user.Descriptografar(ListUser.ElementAt(0).Password.ToString()));
        //TxtPassword.TextMode = TextBoxMode.Password;
        txtUser_id.Text = (ListUser.ElementAt(0).User_id.ToString());
        txtUserName.Text = (ListUser.ElementAt(0).Login.ToString());
        DropDownActive.SelectedValue = (ListUser.ElementAt(0).Active.ToString());
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.User _user = new FAMIS_BLL.User();
            FAMIS_BLL.User _userDel = new FAMIS_BLL.User();

            List<Model.User> ListUser =
                _user.Select(" Where user_id=" + grvUser.DataKeys[grid.RowIndex].Values[0].ToString());

            _userDel.Delete(ListUser.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvUser_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.User _user = new FAMIS_BLL.User();
        grvUser.DataSource = _user.Select(""); //lista;
        grvUser.PageIndex = e.NewPageIndex;
        grvUser.DataBind();
    }
}
