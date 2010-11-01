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

public partial class Clients : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PreencheGrid();
        }

    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        
        if (String.IsNullOrEmpty(txtClient_id.Text))
        {// if new client
            try
            {
                bool _bactive;
                bool _bmulti;
                Model.Client cliente = new Model.Client();
                cliente.Local_name = txtLocalName.Text;
                cliente.Intl_name = txtIntlName.Text;
                //_bactive = (RadioActiveTrue.Enabled.ToString() == "yes" ? true : false);
                _bactive = RadioActiveTrue.Checked;
                cliente.Active = Convert.ToInt32(_bactive);
                //_bmulti = (RadioMultiTrue.Enabled.ToString() == "yes" ? true : false);
                _bmulti = RadioMultiTrue.Checked;
                cliente.Multinational = Convert.ToInt32(_bmulti);
                cliente.Code = TxtCode.Text;

                FAMIS_BLL.Client cli = new FAMIS_BLL.Client();
                cli.Add(cliente);
                txtLocalName.Text = "";
                txtIntlName.Text = "";
                TxtCode.Text = "";
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
                bool _bactive;
                bool _bmulti;
                Model.Client cliente = new Model.Client();
                cliente.Client_id = Convert.ToInt32(txtClient_id.Text);   
                cliente.Local_name = txtLocalName.Text;
                cliente.Intl_name = txtIntlName.Text;
                //_bactive = (RadioActiveTrue.Enabled.ToString() == "yes" ? true : false);
                _bactive = RadioActiveTrue.Checked; // .Enabled;
                cliente.Active = Convert.ToInt32(_bactive);
                //_bmulti = (RadioMultiTrue.Enabled.ToString() == "yes" ? true : false);
                _bmulti = RadioMultiTrue.Checked;  //.Enabled;
                cliente.Multinational = Convert.ToInt32(_bmulti);
                cliente.Code = TxtCode.Text;   

                FAMIS_BLL.Client cli = new FAMIS_BLL.Client();
                cli.Update(cliente);
                txtLocalName.Text = "";
                txtIntlName.Text = "";
                TxtCode.Text = "";
                txtClient_id.Text = ""; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        PreencheGrid();
    }

    protected void lkbDelete_Click(object sender, EventArgs e)
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
        FAMIS_BLL.Client clientb = new FAMIS_BLL.Client();

        grvClient.DataSource = clientb.Select(""); //lista;
        grvClient.DataBind();
        grvClient.AllowPaging = true;
        grvClient.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Client _client = new FAMIS_BLL.Client(); 
        List<Model.Client> ListClient =
            _client.Select(" Where client_id=" + grvClient.DataKeys[grid.RowIndex].Values[0].ToString());

        txtClient_id.Text = ListClient.ElementAt(0).Client_id.ToString();
        txtLocalName.Text = ListClient.ElementAt(0).Local_name.ToString();
        txtIntlName.Text = ListClient.ElementAt(0).Intl_name.ToString();
        TxtCode.Text = ListClient.ElementAt(0).Code.ToString();
        if (ListClient.ElementAt(0).Active == 1)
        {
            RadioActiveTrue.Checked = true;
        }
        else
        {
            RadioActiveFalse.Checked = true; 
        }
        if (ListClient.ElementAt(0).Multinational == 1)
        {
            RadioMultiTrue.Checked = true;
        }
        else
        {
            RadioMultiTrue.Checked = true;
        }
        //DropActive.SelectedValue = ListClient.ElementAt(0).Active.ToString();
        //DropMultinational.SelectedValue = ListClient.ElementAt(0).Multinational.ToString();   
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Client _client = new FAMIS_BLL.Client();
            FAMIS_BLL.Client _clientDel = new FAMIS_BLL.Client();

            List<Model.Client> ListClient =
                _client.Select(" Where client_id=" + grvClient.DataKeys[grid.RowIndex].Values[0].ToString());
            
            _clientDel.Remove(ListClient.ElementAt(0));
            
            PreencheGrid(); 
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvClient_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Client _client = new FAMIS_BLL.Client();  
        grvClient.DataSource = _client.Select(""); //lista;
        grvClient.PageIndex = e.NewPageIndex;
        grvClient.DataBind();
    }

}
