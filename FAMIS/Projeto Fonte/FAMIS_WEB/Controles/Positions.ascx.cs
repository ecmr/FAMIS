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
 
public partial class Controles_Positions : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PreencheGrid();
        PreencheCombo();
        TxtName.Focus();
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtPosition_id.Text))
        {// new
            try
            {
                Model.Position _position = new Model.Position();
                _position.Name = TxtName.Text;
                _position.Code = TxtCode.Text;
                _position.Department_id = Convert.ToInt32(DropDownDepartment.SelectedValue.ToString());
                _position.Salary_research = Convert.ToDecimal(TxtSalaray.Text);

                FAMIS_BLL.Position _positionAdd = new FAMIS_BLL.Position();
                _positionAdd.Add(_position);
                TxtCode.Text = "";
                TxtName.Text = "";
                TxtSalaray.Text = ""; 
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
                Model.Position _position = new Model.Position();
                _position.Position_id = Convert.ToInt32(txtPosition_id.Text);     
                _position.Name = TxtName.Text;
                _position.Code = TxtCode.Text;
                _position.Department_id = Convert.ToInt32(DropDownDepartment.SelectedValue.ToString());
                _position.Salary_research = Convert.ToDecimal(TxtSalaray.Text);

                FAMIS_BLL.Position _positionAdd = new FAMIS_BLL.Position();
                _positionAdd.Update(_position);
                txtPosition_id.Text = ""; 
                TxtCode.Text = "";
                TxtName.Text = "";
                TxtSalaray.Text = "";
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
        FAMIS_BLL.Position _position = new FAMIS_BLL.Position(); 

        grvPosition.DataSource = _position.Select(""); //lista;
        grvPosition.DataBind();
        grvPosition.AllowPaging = true;
        grvPosition.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Position _position = new FAMIS_BLL.Position(); 
        List<Model.Position> ListPosition =
            _position.Select(" Where position_id=" + grvPosition.DataKeys[grid.RowIndex].Values[0].ToString());

        txtPosition_id.Text = (ListPosition.ElementAt(0).Position_id.ToString());
        TxtCode.Text = (ListPosition.ElementAt(0).Code.ToString());
        DropDownDepartment.SelectedValue = (ListPosition.ElementAt(0).Department_id.ToString());  
        TxtName.Text = (ListPosition.ElementAt(0).Name.ToString()); 
        TxtSalaray.Text = (ListPosition.ElementAt(0).Salary_research.ToString());  
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Position _position = new FAMIS_BLL.Position();
            FAMIS_BLL.Position _positionDel = new FAMIS_BLL.Position(); 

            List<Model.Position> ListPosition =
                _position.Select(" Where position_id=" + grvPosition.DataKeys[grid.RowIndex].Values[0].ToString());

            _positionDel.Remove(ListPosition.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvPosition_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Position _position = new FAMIS_BLL.Position(); 
        grvPosition.DataSource = _position.Select(""); //lista;
        grvPosition.PageIndex = e.NewPageIndex;
        grvPosition.DataBind();
    }

    public void PreencheCombo()
    {
        FAMIS_BLL.Position _positions = new FAMIS_BLL.Position();

        DropDownDepartment.DataSource = _positions.GetSelect("Select Distinct department_id, name From dbo.[Department]");
        DropDownDepartment.DataValueField = "department_id";
        DropDownDepartment.DataTextField = "name";
        DropDownDepartment.DataBind();
        DropDownDepartment.SelectedIndex = 0; //  .Items.FindByValue(   //.FindByValue("1").Selected = true;  
    }

}
