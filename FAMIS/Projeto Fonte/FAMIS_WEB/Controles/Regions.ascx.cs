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
  
public partial class Controles_Regions : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PreencheGrid();
        txtName.Focus();
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtRegion_id.Text))
        {// new
            try
            {
                Model.Region _region = new Model.Region();
                _region.Name = txtName.Text;

                FAMIS_BLL.Region _regionAdd = new FAMIS_BLL.Region(); 
                _regionAdd.Add(_region);
                txtName.Text = "";
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
                Model.Region _region = new Model.Region();
                _region.Region_id = Convert.ToInt32(txtRegion_id.Text);
                _region.Name = txtName.Text;
  
                FAMIS_BLL.Region _regionAdd = new FAMIS_BLL.Region();
                _regionAdd.Update(_region);
                txtName.Text = "";
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
        FAMIS_BLL.Region _region = new FAMIS_BLL.Region(); 

        grvRegion.DataSource = _region.Select(""); //lista;
        grvRegion.DataBind();
        grvRegion.AllowPaging = true;
        grvRegion.PageSize = 5;
    }

    public void LimpaCampos()
    {
        txtRegion_id.Text = "";
        txtName.Text = ""; 
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Region _region = new FAMIS_BLL.Region();
        FAMIS_BLL.Region _regionDel = new FAMIS_BLL.Region();

        List<Model.Region> ListRegion =
            _region.Select(" Where region_id=" + grvRegion.DataKeys[grid.RowIndex].Values[0].ToString());

        txtRegion_id.Text = (ListRegion.ElementAt(0).Region_id.ToString());
        txtName.Text  = (ListRegion.ElementAt(0).Name.ToString());
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Region _region = new FAMIS_BLL.Region();
            FAMIS_BLL.Region _regionDel = new FAMIS_BLL.Region();

            List<Model.Region> ListRegion =
                _region.Select(" Where region_id=" + grvRegion.DataKeys[grid.RowIndex].Values[0].ToString());

            _regionDel.Remove(ListRegion.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvRegion_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Region _region = new FAMIS_BLL.Region(); 
        grvRegion.DataSource = _region.Select(""); //lista;
        grvRegion.PageIndex = e.NewPageIndex;
        grvRegion.DataBind();
    }
}
