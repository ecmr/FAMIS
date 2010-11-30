using System;
using System.IO;
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
using System.Drawing;
using System.Text.RegularExpressions;

using System.Data.SqlClient;


public partial class Controles_Employes : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //txtSalary.Attributes.Add("OnKeyDown", "this.value=limpa_string(this.value)");
            //txtSalary.Attributes.Add("OnKeyUp", "this.value=limpa_string(this.value)");

        }

        PreencheGrid();
        PreencheCombos();
        //txtFirst_name.Focus();
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        //if (String.IsNullOrEmpty(txtEmployee_Id.Text))
        //{// new
        //    try
        //    {
        //        String xPhoto = HttpContext.Current.Session["CaminhoFotoEmployee"].ToString();
        //        System.Drawing.Image _Image = System.Drawing.Image.FromFile(MapPath("../imagens/UsersPhoto/" + xPhoto));
                
        //        //= (System.Drawing.Image)Session["CaminhoFotoEmployee"];

        //        Model.Employee _employee = new Model.Employee();
        //        _employee.First_name = txtFirst_name.Text;
        //        _employee.Last_name = txtLast_name.Text;
        //        _employee.Code = txtCode0.Text;
        //        _employee.Date_hired = Convert.ToDateTime(txtDateHired.Text);
        //        _employee.Last_version = DateTime.Now;

        //        _employee.Picture = _Image;

        //        FAMIS_BLL.Employee _employeeAdd = new FAMIS_BLL.Employee();
        //        _employeeAdd.Add(_employee);
        //        txtEmployee_Id.Text = "";
        //        txtFirst_name.Text = "";
        //        txtLast_name.Text = "";
        //        txtCode0.Text = "";
        //        txtDateHired.Text = "";
        //        PicturePhoto.ImageUrl = "";
        //        txtSalary.Text = "";
        //    }
        //    catch (Exception ex)
        //    {
        //        //throw new Exception(ex.Message.ToString());
        //    }
        //}
        //else
        //{// if update client
        //    try
        //    {
        //        Model.Employee _employee = new Model.Employee();
        //        _employee.First_name = txtFirst_name.Text;
        //        _employee.Last_name = txtLast_name.Text;
        //        _employee.Code = txtCode0.Text;
        //        _employee.Date_hired = Convert.ToDateTime(txtDateHired.Text);
        //        //_employee.Picture = "";//(byte)PicturePhoto.ImageUrl;
        //        _employee.Position_id = Convert.ToInt32(DropDownPosition.SelectedValue.ToString());
        //        _employee.Salary = Convert.ToDecimal(txtSalary.Text);
        //        _employee.Agency_id = Convert.ToInt32(DropDownAgencies.SelectedValue.ToString());
        //        _employee.Last_version = DateTime.Now;


        //        FAMIS_BLL.Employee _employeeUpdate = new FAMIS_BLL.Employee();
        //        _employeeUpdate.Update(_employee);
        //        txtEmployee_Id.Text = "";
        //        txtFirst_name.Text = "";
        //        txtLast_name.Text = "";
        //        txtCode0.Text = "";
        //        txtDateHired.Text = "";
        //        PicturePhoto.ImageUrl = "";
        //        txtSalary.Text = "";
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
        ////PreencheGrid();
    }

    public void PreencheGrid()
    {

        //FAMIS_BLL.Employee _employee = new FAMIS_BLL.Employee();
        //grvEmployee.DataSource = _employee.Select("Select agency_id,name From Agency"); //lista;
        FAMIS_BLL.Agency _Agency = new FAMIS_BLL.Agency();
        grvEmployee.DataSource = _Agency.Select("Select agency_id,name From Agency");   
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

        #region "old"
        //FAMIS_BLL.Agency _agency = new FAMIS_BLL.Agency();

        //DropDownAgencies.DataSource = _agency.GetSelect("Select distinct agency_id, name From dbo.[agency]");
        //DropDownAgencies.DataValueField = "agency_id";
        //DropDownAgencies.DataTextField = "name";
        //DropDownAgencies.DataBind();
        //DropDownAgencies.SelectedIndex = 0; // .Items.FindByValue("1").Selected = true;  
        #endregion
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {
        ImageButton btnEdit = sender as ImageButton;
        GridViewRow grid = (GridViewRow)btnEdit.NamingContainer;

        FAMIS_BLL.Employee _employee = new FAMIS_BLL.Employee();
        List<Model.Employee> ListEmployee =
            _employee.Select(" Where Employee_id=" + grvEmployee.DataKeys[grid.RowIndex].Values[0].ToString());

        TxtEmployee_id.Text = ListEmployee.ElementAt(0).Agency_id.ToString();
        TxtFirstName.Text = ListEmployee.ElementAt(0).First_name.ToString();
        txtLast_name.Text = ListEmployee.ElementAt(0).Last_name.ToString();
        DropDownPosition.SelectedValue = ListEmployee.ElementAt(0).Position_id.ToString();
        //DropDownAgencies.SelectedValue = ListEmployee.ElementAt(0).Agency_id.ToString();
        TxtSalary.Text = ListEmployee.ElementAt(0).Salary.ToString();
        txtDateHired.Text = ListEmployee.ElementAt(0).Date_hired.ToString();
        TxtCode.Text = ListEmployee.ElementAt(0).Code.ToString();
        PicturePhoto.ImageUrl = "";
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

    protected void UploadPhoto_Click(object sender, EventArgs e)
    {
        if (FileUploadPhoto.HasFile)
        {
            //Salvar na pasta de imagens do projeto
            FileUploadPhoto.SaveAs(MapPath("../" + "imagens/UsersPhoto/" + FileUploadPhoto.FileName));
            //Carregar o PicturePhoto do diretorio do projeto
            PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + FileUploadPhoto.FileName;
            //Criar uma Session para armazenar o path da foto...
            HttpContext.Current.Session.Add("CaminhoFotoEmployee", PicturePhoto.ImageUrl);
            //Session["CaminhoFotoEmployee"]
        }
        else
        {
            //Mensagem caso não tiver foto
        }
    }

    //private bool GravarImagem(int codigoCliente)
    //{
    //    // Define variaveis para gravar a imagem
    //    bool SalvaImagem = false;
    //    string nomeArquivo = "";
    //    try
    //    {
    //        // buscamos a imagem a ser gravada
    //        OpenFileDialog openDlg = new OpenFileDialog();
    //        openDlg.Filter = "All Bitmap files|*.bmp";
    //        string filter = openDlg.Filter;
    //        openDlg.Title = "Abrir Arq. BitMap";
    //        if ((openDlg.ShowDialog() == Windows.Forms.DialogResult.OK))
    //        {
    //            nomeArquivo = openDlg.FileName;
    //            SalvaImagem = true;
    //        }
    //        else
    //        {
    //            return false;
    //            // TODO: Exit Function: Warning!!! Need to return the value
    //            return;
    //        }
    //        // se uma imagem foi selecionada ent�o inicia a grava��o
    //        if ((SalvaImagem == true))
    //        {
    //            // Carrega a foto
    //            FileStream fsFoto;
    //            fsFoto = new FileStream(nomeArquivo, FileMode.Open);
    //            FileInfo fiFoto = new FileInfo(nomeArquivo);
    //            long Temp = fiFoto.Length;
    //            long lung = Convert.ToInt32(Temp);
    //            byte[,] picture;
    //            // le a imagem
    //            fsFoto.Read(picture, 0, lung);
    //            fsFoto.Close();
    //            // cria um novo objeto command usando a stored procedure ja criada na base de dados
    //            SqlCommand cmdFoto = new SqlCommand("spCarregaFoto", conClientes);
    //            cmdFoto.CommandType = CommandType.StoredProcedure;
    //            // recebe os parametros para a stored procedure spCarregaFoto
    //            object sql_codigoCliente = new SqlParameter("@CODIGO", codigoCliente);
    //            SqlParameter sql_Foto = new SqlParameter("@IMAGEM", SqlDbType.Image);
    //            sql_Foto.Value = picture;
    //            // adicona os parametros informados
    //            cmdFoto.Parameters.Add(sql_codigoCliente);
    //            cmdFoto.Parameters.Add(sql_Foto);
    //            // executa a stored procedures usando os par�metros informados
    //            cmdFoto.ExecuteNonQuery();
    //            cmdFoto.Dispose();
    //            sql_FOTO = null;
    //            picture = null;
    //            return true;
    //            // TODO: Exit Function: Warning!!! Need to return the value
    //            return;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message);
    //        return false;
    //    }
    //}

    protected void grvEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
