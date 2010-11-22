using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ControleModelo : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PreencheGrid();
            TxtAgencyName.Focus();
        }
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TxtAgencyId.Text))  
        {//New
            try
            {
                Model.Agency agencie = new Model.Agency();
                agencie.Name = this.TxtAgencyName.Text;
                FAMIS_BLL.Agency Ag = new FAMIS_BLL.Agency();
                Ag.Add(agencie);
                TxtAgencyName.Text = "";
                TxtAgencyId.Text = "";
                //Int32 i = 0;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        else
        {//Update
            try
            {
                Model.Agency agencie = new Model.Agency();
                agencie.Agency_id = Convert.ToInt32(TxtAgencyId.Text);
                agencie.Name = this.TxtAgencyName.Text;
                FAMIS_BLL.Agency Ag = new FAMIS_BLL.Agency();
                Ag.Update(agencie);
                TxtAgencyName.Text = "";
                TxtAgencyId.Text = "";
                //Int32 i = 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        PreencheGrid();
    }

    protected void btn_UpdtePane_Click(object sender, EventArgs e)
    {

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
        FAMIS_BLL.Agency Agencyb = new FAMIS_BLL.Agency();

        grvAgency.DataSource = Agencyb.Select(""); //lista;
        grvAgency.DataBind();
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Agency _agency = new FAMIS_BLL.Agency();
        List<Model.Agency> ListAgency =
            _agency.Select(" Where agency_id=" + grvAgency.DataKeys[grid.RowIndex].Values[0].ToString());

        TxtAgencyId.Text = ListAgency.ElementAt(0).Agency_id.ToString();
        TxtAgencyName.Text = ListAgency.ElementAt(0).Name.ToString();
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Agency _agency = new FAMIS_BLL.Agency();
            FAMIS_BLL.Agency _agencyDel = new FAMIS_BLL.Agency();

            List<Model.Agency> ListAgency =
                _agency.Select(" Where agency_id=" + grvAgency.DataKeys[grid.RowIndex].Values[0].ToString());

            _agencyDel.Remove(ListAgency.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvAgency_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Agency Agencyb = new FAMIS_BLL.Agency();
        grvAgency.DataSource = Agencyb.Select(""); //lista;
        grvAgency.PageIndex = e.NewPageIndex;
        grvAgency.DataBind();
    }
}
