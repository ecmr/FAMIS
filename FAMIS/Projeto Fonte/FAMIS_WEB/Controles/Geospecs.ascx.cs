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

public partial class Controles_Geospecs : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreencheGrid();
            PreencheCombo();
            txtCurrency.Focus();
        }
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtGeospec_id.Text))
        {// new
            try
            {
                Model.Geospec geospec = new Model.Geospec();
                geospec.Currency = txtCurrency.Text;
                geospec.Date_format = Convert.ToDateTime(txtDateFormat.Text);
                geospec.Decimal_symbol = txtDecimalSymbol.Text;
                geospec.Region_id = Convert.ToInt32(DropRegion.SelectedValue.ToString());
                geospec.Country_id = Convert.ToInt32(DropCountry.SelectedValue.ToString());

                FAMIS_BLL.Geospec _geospecAdd = new FAMIS_BLL.Geospec();
                _geospecAdd.Add(geospec);
                txtCurrency.Text="";
                txtDateFormat.Text = "";
                txtDecimalSymbol.Text = "";
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
                Model.Geospec geospec = new Model.Geospec();
                geospec.Geospec_id = Convert.ToInt32(txtGeospec_id.Text);    
                geospec.Currency = txtCurrency.Text;
                geospec.Date_format = Convert.ToDateTime(txtDateFormat.Text);
                geospec.Decimal_symbol = txtDecimalSymbol.Text;
                geospec.Region_id = Convert.ToInt32(DropRegion.SelectedValue.ToString());
                geospec.Country_id = Convert.ToInt32(DropCountry.SelectedValue.ToString());

                FAMIS_BLL.Geospec _geospecUpdate = new FAMIS_BLL.Geospec();
                _geospecUpdate.Update(geospec);
                txtCurrency.Text = "";
                txtDateFormat.Text = "";
                txtDecimalSymbol.Text = "";
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
        FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec(); 

        grvGeospec.DataSource = _geospec.Select(""); //lista;
        grvGeospec.DataBind();
        grvGeospec.AllowPaging = true;
        grvGeospec.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec(); 
        List<Model.Geospec> ListGeospec =
            _geospec.Select(" Where geospec_id=" + grvGeospec.DataKeys[grid.RowIndex].Values[0].ToString());

        txtGeospec_id.Text = ListGeospec.ElementAt(0).Geospec_id.ToString();
        txtCurrency.Text = ListGeospec.ElementAt(0).Currency.ToString();
        txtDecimalSymbol.Text = ListGeospec.ElementAt(0).Decimal_symbol.ToString();
        txtDateFormat.Text = ListGeospec.ElementAt(0).Date_format.ToString();
        DropRegion.SelectedValue = ListGeospec.ElementAt(0).Region_id.ToString();
        #region "Atualiza Drop Country"
            CarregaDropCountry(DropRegion.SelectedValue.ToString());
        #endregion
        DropCountry.SelectedValue = ListGeospec.ElementAt(0).Country_id.ToString();
  
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec();
            FAMIS_BLL.Geospec _geospecDel = new FAMIS_BLL.Geospec(); 

            List<Model.Geospec> ListGeospec =
                _geospec.Select(" Where geospec_id=" + grvGeospec.DataKeys[grid.RowIndex].Values[0].ToString());

            _geospecDel.Remove(ListGeospec.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvGeospec_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec();
        grvGeospec.DataSource = _geospec.Select(""); //lista;
        grvGeospec.PageIndex = e.NewPageIndex;
        grvGeospec.DataBind();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }

    public void PreencheCombo()
    {
        FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec();

        DropRegion.DataSource = _geospec.GetSelect("Select Distinct region_id, name From dbo.[Region]");
        DropRegion.DataValueField = "region_id";
        DropRegion.DataTextField = "name";
        DropRegion.DataBind();
        DropRegion.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  

        CarregaDropCountry(DropRegion.SelectedValue.ToString());

    }

    private void CarregaDropCountry(string pID)
    {
        FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec();
        DropCountry.DataSource = _geospec.GetSelect("Select Distinct country_id, name From dbo.[Country] Where region_id=" + Convert.ToInt32(pID));
        DropCountry.DataValueField = "country_id";
        DropCountry.DataTextField = "name";
        DropCountry.DataBind();
        DropCountry.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  
    }

    protected void DropRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        FAMIS_BLL.Geospec _geospec = new FAMIS_BLL.Geospec();
        DropCountry.DataSource = _geospec.GetSelect("Select Distinct country_id, name From dbo.[Country] Where region_id=" + DropRegion.SelectedValue);
        DropCountry.DataValueField = "country_id";
        DropCountry.DataTextField = "name";
        DropCountry.DataBind();
        DropCountry.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  
    }
}
