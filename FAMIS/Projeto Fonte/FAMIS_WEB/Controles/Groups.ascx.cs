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

public partial class Controles_Groups : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PreencheGrid();
        PreencheCombo();
        txtName.Focus();  
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtGroup_id.Text))
        {// new
            try
            {
                Model.Group _group = new Model.Group();
                _group.Name = txtName.Text;
                _group.Agency_id = Convert.ToInt32(DropDownAgency.SelectedValue.ToString());

                FAMIS_BLL.Group _groupAdd = new FAMIS_BLL.Group();
                _groupAdd.Add(_group);
                txtName.Text = "";
                txtGroup_id.Text = ""; 
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
                Model.Group _group = new Model.Group();
                _group.Group_id = Convert.ToInt32(txtGroup_id.Text);  
                _group.Name = txtName.Text;
                _group.Agency_id = Convert.ToInt32(DropDownAgency.SelectedValue.ToString());

                FAMIS_BLL.Group _groupAdd = new FAMIS_BLL.Group();
                _groupAdd.Update(_group);
                txtName.Text = "";
                txtGroup_id.Text = ""; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        PreencheGrid();
    }

    public void PreencheGrid()
    {
        #region "List"
        //List<KeyValuePair<string, string>> lista = new List<KeyValuePair<string, string>>();
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        //lista.Add(new KeyValuePair<string, string>("", ""));
        #endregion
        FAMIS_BLL.Group _group = new FAMIS_BLL.Group();

        grvGroups.DataSource = _group.Select(""); //lista;
        grvGroups.DataBind();
        grvGroups.AllowPaging = true;
        grvGroups.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Group _group = new FAMIS_BLL.Group();
        List<Model.Group> ListGroup =
            _group.Select(" Where group_id=" + grvGroups.DataKeys[grid.RowIndex].Values[0].ToString());

        txtGroup_id.Text = ListGroup.ElementAt(0).Group_id.ToString();
        txtName.Text = ListGroup.ElementAt(0).Name.ToString();
        DropDownAgency.SelectedValue = ListGroup.ElementAt(0).Agency_id.ToString();
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Group _group = new FAMIS_BLL.Group();
            FAMIS_BLL.Group _groupDel = new FAMIS_BLL.Group();

            List<Model.Group> ListGroup =
                _group.Select(" Where group_id=" + grvGroups.DataKeys[grid.RowIndex].Values[0].ToString());

            _groupDel.Remove(ListGroup.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvGroup_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Group _group = new FAMIS_BLL.Group();
        grvGroups.DataSource = _group.Select(""); //lista;
        grvGroups.PageIndex = e.NewPageIndex;
        grvGroups.DataBind();
    }

    public void PreencheCombo()
    {
        FAMIS_BLL.Group _group = new FAMIS_BLL.Group();

        DropDownAgency.DataSource = _group.GetSelect("Select Distinct agency_id, name From dbo.[Agency]");
        DropDownAgency.DataValueField = "agency_id";
        DropDownAgency.DataTextField = "name";
        DropDownAgency.DataBind();
        DropDownAgency.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  


    }

}
