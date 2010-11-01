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

public partial class Controles_Locations : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreencheGrid();
            PreencheCombo();
            TxtCity.Focus();
        }
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtLocation_id.Text))
        {// new
            try
            {
                Model.Location _location = new Model.Location();
                _location.Agency_id = Convert.ToInt32(DropDownAgency.SelectedValue);
                _location.City = TxtCity.Text;
                _location.Address = txtAddress.Text;  
                _location.Country_id = Convert.ToInt32(DropDownCountry.SelectedValue);
                _location.Number = Convert.ToInt32(TxtNumber.Text.Replace(".",""));
                _location.Region_id = Convert.ToInt32(DropDownRegion.SelectedValue);

                FAMIS_BLL.Location _locationAdd = new FAMIS_BLL.Location(); 
                _locationAdd.Add(_location);
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
                Model.Location _location = new Model.Location();
                _location.Location_id = Convert.ToInt32(txtLocation_id.Text); 
                _location.Agency_id = Convert.ToInt32(DropDownAgency.SelectedValue);
                _location.City = TxtCity.Text;
                _location.Address = txtAddress.Text;   
                _location.Country_id = Convert.ToInt32(DropDownCountry.SelectedValue);
                _location.Number = Convert.ToInt32(TxtNumber.Text);
                _location.Region_id = Convert.ToInt32(DropDownRegion.SelectedValue);

                FAMIS_BLL.Location _locationAdd = new FAMIS_BLL.Location();
                _locationAdd.Update(_location);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        TxtCity.Text = "";
        TxtNumber.Text = "";
        txtLocation_id.Text = "";
        txtAddress.Text = "";  
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
        FAMIS_BLL.Location _location = new FAMIS_BLL.Location(); 

        grvLocation.DataSource = _location.Select(""); //lista;
        grvLocation.DataBind();
        grvLocation.AllowPaging = true;
        grvLocation.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Location _location = new FAMIS_BLL.Location(); 
        List<Model.Location> ListLocation =
            _location.Select(" Where location_id=" + grvLocation.DataKeys[grid.RowIndex].Values[0].ToString());

        txtLocation_id.Text = (ListLocation.ElementAt(0).Location_id.ToString());
        txtAddress.Text = ListLocation.ElementAt(0).Address.ToString();
        TxtCity.Text = ListLocation.ElementAt(0).City.ToString();
        TxtNumber.Text = ListLocation.ElementAt(0).Number.ToString();  
        DropDownRegion.SelectedValue = ListLocation.ElementAt(0).Region_id.ToString();
        #region "Atualiza Drop Country"
        CarregaDropCountry(DropDownRegion.SelectedValue.ToString());
        #endregion
        DropDownCountry.SelectedValue = ListLocation.ElementAt(0).Country_id.ToString();
        DropDownAgency.SelectedValue = ListLocation.ElementAt(0).Agency_id.ToString();
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Location _location = new FAMIS_BLL.Location();
            FAMIS_BLL.Location _locationDel = new FAMIS_BLL.Location(); 

            List<Model.Location> Listlocation =
                _location.Select(" Where location_id=" + grvLocation.DataKeys[grid.RowIndex].Values[0].ToString());

            _locationDel.Remove(Listlocation.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvLocation_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Location _location = new FAMIS_BLL.Location(); 
        grvLocation.DataSource = _location.Select(""); //lista;
        grvLocation.PageIndex = e.NewPageIndex;
        grvLocation.DataBind();
    }

    public void PreencheCombo()
    {
        FAMIS_BLL.Location _location = new FAMIS_BLL.Location();

        DropDownRegion.DataSource = _location.GetSelect("Select Distinct region_id, name From dbo.[Region]");
        DropDownRegion.DataValueField = "region_id";
        DropDownRegion.DataTextField = "name";
        DropDownRegion.DataBind();
        DropDownRegion.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  
        
        #region "Atualiza Drop Country"
            CarregaDropCountry(DropDownRegion.SelectedValue.ToString());
        #endregion

        DropDownAgency.DataSource = _location.GetSelect("Select Distinct agency_id, name From dbo.[Agency]");
        DropDownAgency.DataValueField = "agency_id";
        DropDownAgency.DataTextField = "name";
        DropDownAgency.DataBind();
        DropDownAgency.SelectedIndex = 0;
    
    }

    protected void DropDownRegion_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregaDropCountry(DropDownRegion.SelectedValue);
    }

    protected void DropDownCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        CarregaDropAgency(DropDownCountry.SelectedValue);
    }
    
    private void CarregaDropCountry(string pID)
    {
        FAMIS_BLL.Location _location = new FAMIS_BLL.Location();
        DropDownCountry.DataSource = _location.GetSelect("Select Distinct country_id, name From dbo.[Country] Where region_id=" + Convert.ToInt32(pID));
        DropDownCountry.DataValueField = "country_id";
        DropDownCountry.DataTextField = "name";
        DropDownCountry.DataBind();
        DropDownCountry.SelectedIndex = 0;
    }

    private void CarregaDropAgency(string pID)
    {
        FAMIS_BLL.Location _location = new FAMIS_BLL.Location();
        DropDownAgency.DataSource = _location.GetSelect("Select Distinct agency_id, name From dbo.[Agency] Where country_id=" + Convert.ToInt32(pID));
        DropDownAgency.DataValueField = "agency_id";
        DropDownAgency.DataTextField = "name";
        DropDownAgency.DataBind();
        DropDownAgency.SelectedIndex = 0;
    }
 
}
