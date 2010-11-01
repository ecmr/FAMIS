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

public partial class Countries : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PreencheGrid();
        PreencheCombo();
        txtCountryName.Focus();  
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtCountry_id.Text))
        {// new
            try
            {
                Model.Country country = new Model.Country();
                country.Name = txtCountryName.Text;
                country.Region_id = Convert.ToInt32(DropDowCountries.SelectedValue);

                FAMIS_BLL.Country _countryAdd = new FAMIS_BLL.Country(); 
                _countryAdd.Add(country);
                txtCountryName.Text = "";
                txtCountry_id.Text = "";
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
                Model.Country country = new Model.Country();
                country.Name = txtCountryName.Text;
                country.Region_id = Convert.ToInt32(DropDowCountries.SelectedValue );
                country.Country_id = Convert.ToInt32(txtCountry_id.Text);  

                FAMIS_BLL.Country _countryUpte = new FAMIS_BLL.Country();
                _countryUpte.Update(country);
                txtCountryName.Text = "";
                txtCountry_id.Text = "";
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
        FAMIS_BLL.Country countryb = new FAMIS_BLL.Country();

        grvCountry.DataSource = countryb.Select(""); //lista;
        grvCountry.DataBind();
        grvCountry.AllowPaging = true;
        grvCountry.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Country _country = new FAMIS_BLL.Country(); 
        List<Model.Country> ListCountry =
            _country.Select(" Where country_id=" + grvCountry.DataKeys[grid.RowIndex].Values[0].ToString());

        txtCountry_id.Text = ListCountry.ElementAt(0).Country_id.ToString();
        txtCountryName.Text = ListCountry.ElementAt(0).Name.ToString();
        DropDowCountries.SelectedValue = ListCountry.ElementAt(0).Region_id.ToString();   
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Country _country = new FAMIS_BLL.Country();
            FAMIS_BLL.Country _countryDel = new FAMIS_BLL.Country(); 

            List<Model.Country> ListCountry =
                _country.Select(" Where country_id=" + grvCountry.DataKeys[grid.RowIndex].Values[0].ToString());

            _countryDel.Remove(ListCountry.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvClient_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Country _country = new FAMIS_BLL.Country();
        grvCountry.DataSource = _country.Select(""); //lista;
        grvCountry.PageIndex = e.NewPageIndex;
        grvCountry.DataBind();
    }

    public void PreencheCombo()
    {
        FAMIS_BLL.Country _country = new FAMIS_BLL.Country();

        DropDowCountries.DataSource = _country.GetSelect("Select Distinct region_id, name From dbo.[Region]");
        DropDowCountries.DataValueField = "region_id";
        DropDowCountries.DataTextField = "name";
        DropDowCountries.DataBind();
        DropDowCountries.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  
    }


}
