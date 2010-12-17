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
            pnlAmount.Height = 79;
            PnlBonus.Height = 30;
            //Bonus
            lblbonusAmt.Visible = false;
            lblbonusDt.Visible = false;
            txtBonusAmt.Visible = false;
            txtBonusDt.Visible = false;
            imgCalendarBonus.Visible = false;
            txtOldAmt1.Enabled = false;
            txtOldDt1.Enabled = false;
            txtOldAmt2.Enabled = false;
            txtOldDt2.Enabled = false;

            PreencheGrid();
            PreencheCombos();
            PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + "GREY.jpg";
        }
    }

    protected void ClearFields()
    {
        TxtEmployee_id.Text = "";
        TxtFirstName.Text = "";
        txtLast_name.Text = "";
        TxtCode.Text = "";
        txtDateHired.Text = "";
        TxtAmount.Text = "";
        txtOldAmt1.Text = "";
        txtOldDt1.Text = "";
        txtOldAmt2.Text = "";
        txtOldDt2.Text = "";
        txtDateHired.Text = ""; 
        PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + "GREY.jpg";
    }

    protected void lkbSalvar_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TxtEmployee_id.Text))
        {
            try
            {

                Model.Employee _employee = new Model.Employee();

                _employee.First_name = TxtFirstName.Text;
                _employee.Last_name = txtLast_name.Text;
                _employee.Code = TxtCode.Text;
                _employee.Position_id = Convert.ToInt32(DropDownPosition.SelectedValue.ToString());
                _employee.Department_id = Convert.ToInt32(DropDownDepartment.SelectedValue.ToString());
                _employee.Agency_id = Convert.ToInt32(DropDownAgency.SelectedValue.ToString());
                _employee.Date_hired = Convert.ToDateTime(txtDateHired.Text);
                _employee.Picture = HttpContext.Current.Session["EmployeePhoto"].ToString();
                _employee.Amount = Convert.ToDecimal(TxtAmount.Text);    
                _employee.Last_version = DateTime.Now;
                _employee.Cv = Convert.ToString(Session["EmployeeCVPath"].ToString());  
                FAMIS_BLL.Employee _employeeAdd = new FAMIS_BLL.Employee();
                _employee.Employee_id = _employeeAdd.Add(_employee);

                ClearFields(); 
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message.ToString());
            }
        }
        else
        {
            try
            {
                Model.Employee _employee = new Model.Employee();

                _employee.First_name = TxtFirstName.Text;
                _employee.Last_name = txtLast_name.Text;
                _employee.Code = TxtCode.Text;
                _employee.Position_id = Convert.ToInt32(DropDownPosition.SelectedValue.ToString());
                _employee.Department_id = Convert.ToInt32(DropDownDepartment.SelectedValue.ToString());
                _employee.Agency_id = Convert.ToInt32(DropDownAgency.SelectedValue.ToString());
                _employee.Date_hired = Convert.ToDateTime(txtDateHired.Text);
                _employee.Picture = HttpContext.Current.Session["EmployeePhoto"].ToString();
                _employee.Amount = Convert.ToDecimal(TxtAmount.Text);
                _employee.Last_version = DateTime.Now;
                _employee.Cv = Convert.ToString(Session["EmployeeCVPath"].ToString());
                FAMIS_BLL.Employee _employeeUpdate = new FAMIS_BLL.Employee();
                _employeeUpdate.Update(_employee);

                ClearFields();
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

        FAMIS_BLL.Employee _employee = new FAMIS_BLL.Employee();
        grvEmployee.DataSource = _employee.GetSelect("Select employee_id, first_name, last_name From Employee");
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

        DropDownDepartment.DataSource = _position.GetSelect("Select distinct department_id, name From dbo.[Department]");
        DropDownDepartment.DataValueField = "department_id";
        DropDownDepartment.DataTextField = "name";
        DropDownDepartment.DataBind();
        DropDownDepartment.SelectedIndex = 0;

        DropDownAgency.DataSource = _position.GetSelect("Select distinct agency_id, name From dbo.[Agency]");
        DropDownAgency.DataValueField = "agency_id";
        DropDownAgency.DataTextField = "name";
        DropDownAgency.DataBind();
        DropDownAgency.SelectedIndex = 0;

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
        DropDownAgency.SelectedValue = ListEmployee.ElementAt(0).Agency_id.ToString();     
        DropDownPosition.SelectedValue = ListEmployee.ElementAt(0).Position_id.ToString();
        DropDownDepartment.SelectedValue = ListEmployee.ElementAt(0).Department_id.ToString();
        TxtAmount.Text = ListEmployee.ElementAt(0).Amount.ToString();
        if (ListEmployee.ElementAt(0).Amount1 > 0)
        {
            txtOldAmt1.Text = ListEmployee.ElementAt(0).Amount1.ToString();
            txtOldDt1.Text = ListEmployee.ElementAt(0).Date1.ToString();
        }
        if (ListEmployee.ElementAt(0).Amount2 > 0)
        {
            txtOldAmt2.Text = ListEmployee.ElementAt(0).Amount2.ToString();
            txtOldDt2.Text = ListEmployee.ElementAt(0).Date2.ToString();
        }
        txtDateHired.Text = ListEmployee.ElementAt(0).Date_hired.Year.ToString() + "-" + ListEmployee.ElementAt(0).Date_hired.Month.ToString() + "-" + ListEmployee.ElementAt(0).Date_hired.Day.ToString();
        txtDateHired.Text = txtDateHired.Text;
        TxtCode.Text = ListEmployee.ElementAt(0).Code.ToString();
        Session["EmployeeCVPath"] = ListEmployee.ElementAt(0).Cv;
        HttpContext.Current.Session["EmployeePhoto"] = ListEmployee.ElementAt(0).Picture.ToString();
        PicturePhoto.ImageUrl = "";
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
        grvEmployee.DataSource = _employee.GetSelect("Select Distinct employee_id, First_name, Last_name From Employee"); //lista;
        grvEmployee.PageIndex = e.NewPageIndex;
        grvEmployee.DataBind();
    } 

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void imgCalendarBonus_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void UploadPhoto_Click(object sender, EventArgs e)
    {
        #region old
        //if (FileUploadPhoto.HasFile)
        //{
        //    //Salvar na pasta de imagens do projeto
        //    FileUploadPhoto.SaveAs(MapPath("../" + "imagens/UsersPhoto/" + FileUploadPhoto.FileName));
        //    //Carregar o PicturePhoto do diretorio do projeto
        //    PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + FileUploadPhoto.FileName;
        //    //Criar uma Session para armazenar o path da foto...
        //    HttpContext.Current.Session.Add("CaminhoFotoEmployee", PicturePhoto.ImageUrl);
        //    //Session["CaminhoFotoEmployee"]
        //}
        //else
        //{
        //    //Mensagem caso não tiver foto
        //}
        #endregion
        if (string.IsNullOrEmpty(TxtFirstName.Text) || string.IsNullOrEmpty(txtLast_name.Text) || string.IsNullOrEmpty(txtDateHired.Text))
        {
            lblMsgFn.Text = "*";
            lblMsgLn.Text = "*";
            lblmsgDate.Text = "*"; 
        }
        else
        {
            //String arquivo = MapPath(".");
            if (FileUploadPhoto.HasFile)
            {
                //Salvar na pasta de imagens do projeto
                string arquivo = MapPath("../" + "/imagens/UsersPhoto/" + FileUploadPhoto.FileName.Replace(FileUploadPhoto.FileName, txtLast_name.Text.ToString() + TxtFirstName.Text.ToString() + ".jpg"));
                FileUploadPhoto.SaveAs(arquivo);
                HttpContext.Current.Session.Add("EmployeePhotoPath", arquivo.Replace(".jpg", ""));
                //Carregar o PicturePhoto do diretorio do projeto
                PicturePhoto.ImageUrl = Request.ApplicationPath + "/imagens/UsersPhoto/" + FileUploadPhoto.FileName.Replace(FileUploadPhoto.FileName, txtLast_name.Text.ToString() + TxtFirstName.Text.ToString() + ".jpg");
                //Criar uma Session para armazenar o path da foto...
                HttpContext.Current.Session.Add("CaminhoFotoEmployee", PicturePhoto.ImageUrl);
                HttpContext.Current.Session.Add("EmployeePhoto", txtLast_name.Text.ToString() + TxtFirstName.Text.ToString());
                //
            }
            if (FileUploadCV.HasFile)
            {
                string arquivo = MapPath("../" + "/imagens/UsersPhoto/Users CV/" + FileUploadCV.FileName.Replace(FileUploadCV.FileName, txtDateHired.Text.Replace("-", "") + txtLast_name.Text.ToString() + TxtFirstName.Text.ToString() + ".pdf"));
                FileUploadCV.SaveAs(arquivo);  
                Session["EmployeeCVPath"] = FileUploadCV.FileName.Replace(FileUploadCV.FileName, txtDateHired.Text.Replace("-", "") + txtLast_name.Text.ToString() + TxtFirstName.Text.ToString());
            }

        }
    }

    //private bool GravarImagem(int codigoCliente)
    //{
    //    //// Define variaveis para gravar a imagem
    //    //bool SalvaImagem = false;
    //    //string nomeArquivo = "";
    //    //try
    //    //{
    //    //    // buscamos a imagem a ser gravada
    //    //    OpenFileDialog openDlg = new OpenFileDialog();
    //    //    openDlg.Filter = "All Bitmap files|*.bmp";
    //    //    string filter = openDlg.Filter;
    //    //    openDlg.Title = "Abrir Arq. BitMap";
    //    //    if ((openDlg.ShowDialog() == Windows.Forms.DialogResult.OK))
    //    //    {
    //    //        nomeArquivo = openDlg.FileName;
    //    //        SalvaImagem = true;
    //    //    }
    //    //    else
    //    //    {
    //    //        //return false;
    //    //        //// TODO: Exit Function: Warning!!! Need to return the value
    //    //        //return;
    //    //    }
    //    //    // se uma imagem foi selecionada ent�o inicia a grava��o
    //    //    if ((SalvaImagem == true))
    //    //    {
    //    //        //// Carrega a foto
    //    //        //FileStream fsFoto;
    //    //        //fsFoto = new FileStream(nomeArquivo, FileMode.Open);
    //    //        //FileInfo fiFoto = new FileInfo(nomeArquivo);
    //    //        //long Temp = fiFoto.Length;
    //    //        //long lung = Convert.ToInt32(Temp);
    //    //        //byte[,] picture;
    //    //        //// le a imagem
    //    //        //fsFoto.Read(picture, 0, lung);
    //    //        //fsFoto.Close();
    //    //        //// cria um novo objeto command usando a stored procedure ja criada na base de dados
    //    //        //SqlCommand cmdFoto = new SqlCommand("spCarregaFoto", conClientes);
    //    //        //cmdFoto.CommandType = CommandType.StoredProcedure;
    //    //        //// recebe os parametros para a stored procedure spCarregaFoto
    //    //        //object sql_codigoCliente = new SqlParameter("@CODIGO", codigoCliente);
    //    //        //SqlParameter sql_Foto = new SqlParameter("@IMAGEM", SqlDbType.Image);
    //    //        //sql_Foto.Value = picture;
    //    //        //// adicona os parametros informados
    //    //        //cmdFoto.Parameters.Add(sql_codigoCliente);
    //    //        //cmdFoto.Parameters.Add(sql_Foto);
    //    //        //// executa a stored procedures usando os par�metros informados
    //    //        //cmdFoto.ExecuteNonQuery();
    //    //        //cmdFoto.Dispose();
    //    //        //sql_FOTO = null;
    //    //        //picture = null;
    //    //        //return true;
    //    //        //// TODO: Exit Function: Warning!!! Need to return the value
    //    //        //return;
    //    //    }
    //    //}
    //    //catch (Exception ex)
    //    //{
    //    //    //MessageBox.Show(ex.Message);
    //    //    //return false;
    //    //}
    //    return true;
    //}

    protected void grvEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnBonus_Click(object sender, EventArgs e)
    {
        if (PnlBonus.Height == 30)
        {
            PnlBonus.Height = 117;
            lblbonusAmt.Visible = true;
            lblbonusDt.Visible = true;
            txtBonusAmt.Visible = true;
            txtBonusDt.Visible = true;
            imgCalendarBonus.Visible = true;
        }
        else
        {
            PnlBonus.Height = 30;
            lblbonusAmt.Visible = false;
            lblbonusDt.Visible = false;
            txtBonusAmt.Visible = false;
            txtBonusDt.Visible = false;
            imgCalendarBonus.Visible = false;
        }
    }

    protected void lkbCV_Click(object sender, EventArgs e)
    {
        string arquivo = "";
        Boolean bOpen = false;
        
        //Caso CV for carregado do Banco de dados do usuário
        if (!string.IsNullOrEmpty(Convert.ToString(Session["EmployeeCVPath"])))
        {
            arquivo = MapPath("../" + "/imagens/UsersPhoto/Users CV/" + Convert.ToString(Session["EmployeeCVPath"]) + ".pdf");
            bOpen = true;
        } 
       
        //CV quando carregado antes de ser salvo, no momento de cadastramento
        if (FileUploadCV.HasFile)
        {
            if (string.IsNullOrEmpty(TxtFirstName.Text) || string.IsNullOrEmpty(txtLast_name.Text) || string.IsNullOrEmpty(txtDateHired.Text))
            {
                lblMsgFn.Text = "*";
                lblMsgLn.Text = "*";
                lblmsgDate.Text = "*";
                bOpen = false;
            }
            else
            {
                lblMsgFn.Text = "";
                lblMsgLn.Text = "";
                lblmsgDate.Text = "";

                arquivo = MapPath("../" + "/imagens/UsersPhoto/Users CV/" + FileUploadCV.FileName.Replace(FileUploadCV.FileName, txtDateHired.Text.Replace("-","") + txtLast_name.Text.ToString() + TxtFirstName.Text.ToString() + ".pdf"));
                //Caso o arquivo já exista
                if (File.Exists(arquivo))
                {
                    bOpen = true;
                }
                else
                {
                    FileUploadCV.SaveAs(arquivo);
                    HttpContext.Current.Session.Add("EmployeeCVPath", FileUploadCV.FileName.Replace(FileUploadCV.FileName, txtDateHired.Text.Replace("-","") + txtLast_name.Text.ToString() + TxtFirstName.Text.ToString()));
                    bOpen = true;
                }
            }
        }

        if (bOpen)
        {
            System.Diagnostics.Process proc;
            proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = arquivo;
            proc.Start();
        }
    }
}
