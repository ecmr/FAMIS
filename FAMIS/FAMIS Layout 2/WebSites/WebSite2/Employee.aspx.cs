using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

public partial class Employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            PreencheGrid();
            PreencheCombos();
            //Carrega foto padrão
            PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + "GREY.jpg";
            HttpContext.Current.Session.Add("CaminhoFotoEmployee", PicturePhoto.ImageUrl);
        }
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TxtEmployee_id.Text))
        {// new
            try
            {
                String xPhoto = HttpContext.Current.Session["CaminhoFotoEmployee"].ToString();
                Model.Employee _employee = new Model.Employee();
                _employee.First_name = TxtFirstName.Text;
                _employee.Last_name = txtLast_name.Text;
                _employee.Code = TxtCode.Text;
                _employee.Date_hired = Convert.ToDateTime(txtDateHired.Text);
                _employee.Last_version = DateTime.Now;
                _employee.Salary = Convert.ToDecimal(TxtSalary.Text);
                _employee.Agency_id = Convert.ToInt32(DropDownAgencies.SelectedValue.ToString());
                _employee.Position_id = Convert.ToInt32(DropDownPosition.SelectedValue.ToString());
                _employee.Picture = HttpContext.Current.Session["EmployeePhoto"].ToString();

                FAMIS_BLL.Employee _employeeAdd = new FAMIS_BLL.Employee();

                _employeeAdd.Add(_employee);

                TxtEmployee_id.Text = "";
                TxtFirstName.Text = "";
                txtLast_name.Text = "";
                TxtCode.Text = "";
                txtDateHired.Text = "";
                PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + "GREY.jpg";
                TxtSalary.Text = "";
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
                String xPhoto = HttpContext.Current.Session["CaminhoFotoEmployee"].ToString();
                Model.Employee _employee = new Model.Employee();
                _employee.First_name = TxtFirstName.Text;
                _employee.Last_name = txtLast_name.Text;
                _employee.Code = TxtCode.Text;
                _employee.Date_hired = Convert.ToDateTime(txtDateHired.Text);
                _employee.Last_version = DateTime.Now;
                _employee.Salary = Convert.ToDecimal(TxtSalary.Text);
                _employee.Agency_id = Convert.ToInt32(DropDownAgencies.SelectedValue.ToString());
                _employee.Position_id = Convert.ToInt32(DropDownPosition.SelectedValue.ToString());
                _employee.Picture = HttpContext.Current.Session["EmployeePhoto"].ToString();

                FAMIS_BLL.Employee _employeeAdd = new FAMIS_BLL.Employee();

                _employeeAdd.Update(_employee);

                TxtEmployee_id.Text = "";
                TxtFirstName.Text = "";
                txtLast_name.Text = "";
                TxtCode.Text = "";
                txtDateHired.Text = "";
                PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + "GREY.jpg";
                TxtSalary.Text = "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        PreencheGrid();
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Employee _employee = new FAMIS_BLL.Employee();
        List<Model.Employee> ListEmployee =
            _employee.Select(" Where Employee_id=" + grvEmployee.DataKeys[grid.RowIndex].Values[0].ToString());

        TxtEmployee_id.Text = ListEmployee.ElementAt(0).Employee_id.ToString();
        TxtFirstName.Text = ListEmployee.ElementAt(0).First_name.ToString();
        txtLast_name.Text = ListEmployee.ElementAt(0).Last_name.ToString();
        DropDownPosition.SelectedValue = ListEmployee.ElementAt(0).Position_id.ToString();
        DropDownAgencies.SelectedValue = ListEmployee.ElementAt(0).Agency_id.ToString();
        TxtSalary.Text = ListEmployee.ElementAt(0).Salary.ToString();
        txtDateHired.Text = ListEmployee.ElementAt(0).Date_hired.ToString();
        TxtCode.Text = ListEmployee.ElementAt(0).Code.ToString();
        HttpContext.Current.Session["EmployeePhoto"] = ListEmployee.ElementAt(0).Picture.ToString();
        PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + HttpContext.Current.Session["EmployeePhoto"].ToString() + ".jpg";
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        try
        {
            ImageButton btnEdit = sender as ImageButton;
            GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

            FAMIS_BLL.Employee _employee = new FAMIS_BLL.Employee();
            FAMIS_BLL.Employee _employeeDel = new FAMIS_BLL.Employee();

            List<Model.Employee> ListEmployee =
                _employee.Select(" Where Employee_id=" + grvEmployee.DataKeys[grid.RowIndex].Values[0].ToString());

            _employeeDel.Remove(ListEmployee.ElementAt(0));

            PreencheGrid();
        }
        catch (Exception ex)
        {
            throw new Exception("Error: " + ex.Message.ToString());
        }

    }

    protected void grvEmployee_PageIndexChanging(Object sender, GridViewPageEventArgs e)
    {
        FAMIS_BLL.Employee _employee = new FAMIS_BLL.Employee();
        grvEmployee.DataSource = _employee.Select(""); //lista;
        grvEmployee.PageIndex = e.NewPageIndex;
        grvEmployee.DataBind();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void grvEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void UploadPhoto_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(TxtFirstName.Text) || string.IsNullOrEmpty(txtLast_name.Text))
        {
            lblMsgFn.Text = "*";
            lblMsgLn.Text = "*";  
        }
        else
        {
            //String arquivo = MapPath(".");
            if (FileUploadPhoto.HasFile)
            {
                //Salvar na pasta de imagens do projeto
                string arquivo = MapPath("." + "/imagens/UsersPhoto/" + FileUploadPhoto.FileName.Replace(FileUploadPhoto.FileName, txtLast_name.Text.ToString() + TxtFirstName.Text.ToString() + ".jpg"));
                FileUploadPhoto.SaveAs(arquivo);
                HttpContext.Current.Session.Add("EmployeePhotoPath", arquivo.Replace(".jpg", ""));
                //Carregar o PicturePhoto do diretorio do projeto
                PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + FileUploadPhoto.FileName.Replace(FileUploadPhoto.FileName, txtLast_name.Text.ToString() + TxtFirstName.Text.ToString() + ".jpg");
                //Criar uma Session para armazenar o path da foto...
                HttpContext.Current.Session.Add("CaminhoFotoEmployee", PicturePhoto.ImageUrl);
                HttpContext.Current.Session.Add("EmployeePhoto", txtLast_name.Text.ToString() + TxtFirstName.Text.ToString());
                //Session["CaminhoFotoEmployee"]
            }
            else
            {
                //Mensagem caso não tiver foto
            }
        }
    }

    public void PreencheGrid()
    {
        FAMIS_BLL.Employee _Employee = new FAMIS_BLL.Employee();
        grvEmployee.DataSource = _Employee.Select("");
        grvEmployee.DataBind();
        grvEmployee.AllowPaging = true;
        grvEmployee.PageSize = 5;
    }

    public void PreencheCombos()
    {
        FAMIS_BLL.Position _position = new FAMIS_BLL.Position();

        DropDownPosition.DataSource = _position.GetSelect("Select distinct position_id, name From dbo.[position]");
        DropDownPosition.DataValueField = "position_id";
        DropDownPosition.DataTextField = "name";
        DropDownPosition.DataBind();
        DropDownPosition.SelectedIndex = 0;

        FAMIS_BLL.Agency _agency = new FAMIS_BLL.Agency();

        DropDownAgencies.DataSource = _agency.GetSelect("Select distinct agency_id, name From dbo.[agency]");
        DropDownAgencies.DataValueField = "agency_id";
        DropDownAgencies.DataTextField = "name";
        DropDownAgencies.DataBind();
        DropDownAgencies.SelectedIndex = 0;

    }


}