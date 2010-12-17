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

public partial class Departments : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PreencheGrid();
        txtDepartmentName.Focus();
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(txtDepartment_id.Text))
        {// new
            try
            {
                Model.Department _department = new Model.Department();
                _department.Name = txtDepartmentName.Text;

                FAMIS_BLL.Department _departmentAdd = new FAMIS_BLL.Department(); 
                _departmentAdd.Add(_department);
                txtDepartmentName.Text = "";
                txtDepartment_id.Text = ""; 
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
                Model.Department _department = new Model.Department();
                _department.Name = txtDepartmentName.Text;
                _department.Department_id = Convert.ToInt32(txtDepartment_id.Text);

                FAMIS_BLL.Department _departmentAdd = new FAMIS_BLL.Department();
                _departmentAdd.Update(_department);
                txtDepartmentName.Text = "";
                txtDepartment_id.Text = ""; 
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
        FAMIS_BLL.Department _department = new FAMIS_BLL.Department(); 

        grvDepartment.DataSource = _department.Select(""); //lista;
        grvDepartment.DataBind();
        grvDepartment.AllowPaging = true;
        grvDepartment.PageSize = 5;
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Department _department = new FAMIS_BLL.Department();
        List<Model.Department> ListDepartment =
            _department.Select(" Where Department_id=" + grvDepartment.DataKeys[grid.RowIndex].Values[0].ToString());

        txtDepartment_id.Text = ListDepartment.ElementAt(0).Department_id.ToString();
        txtDepartmentName.Text = ListDepartment.ElementAt(0).Name.ToString();
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Department _department = new FAMIS_BLL.Department();
            FAMIS_BLL.Department _departmentDel = new FAMIS_BLL.Department(); 

            List<Model.Department> ListDepartment =
                _department.Select(" Where department_id=" + grvDepartment.DataKeys[grid.RowIndex].Values[0].ToString());

            _departmentDel.Remove(ListDepartment.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvClient_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Department _department = new FAMIS_BLL.Department(); 
        grvDepartment.DataSource = _department.Select(""); //lista;
        grvDepartment.PageIndex = e.NewPageIndex;
        grvDepartment.DataBind();
    } 
}
