using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Grade : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
		{
			DataList1.DataSource = OrigemDados();
			DataList1.DataBind();
            lblCategoria.Text =" " + LegendaCategoria(Int32.Parse(Request.QueryString["Id"]))+ "<p/>";
		}
    }

    DataView OrigemDados()
    {
        DataView origem;
        int i;
        if (Request.QueryString["Id"] != null)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^[0-9]+$");
            if (!reg.IsMatch(Request.QueryString["Id"])) return null;
            if (!Int32.TryParse(Request.QueryString["Id"],out i)) return null;

            	string conectar = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=C:\\Documents and Settings\\Administrator\\Desktop\\Exemplos do livro Novatec\\Livro com DB\\Capitulo7\\nwind.Mdb;";
          	string sSql = "SELECT DISTINCTROW Categories.CategoryID, Products.ProductName, Products.UnitsInStock, Products.UnitPrice " +
                   "FROM Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID " +
                   "GROUP BY Categories.CategoryID, Products.ProductName, Products.UnitsInStock, Products.UnitPrice " +
                   "HAVING (((Categories.CategoryID)=" + Int32.Parse(Request.QueryString["Id"]) + "));";

            DataSet ds = new DataSet();
            using (OleDbConnection conn = new OleDbConnection(conectar))
            {
                OleDbCommand cmd = new OleDbCommand(sSql, conn);
                cmd.CommandType = CommandType.Text;

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(ds);
                origem = new DataView(ds.Tables[0]);
            }
        }
        else
        {
            return null;
        }
        return origem;
    }

    string LegendaCategoria(int i)
    {
        switch(i)
        {
            case 1:
                return "Beverages";
            break;
            case 2:
                return "Condiments";
            break;
            case 3:
                return "Confections";
            break;
            case 4:
                return "Dairy Products";
            break;
            case 5:
                return "Grains/Cereals";
            break;
            case 6:
                return "Meat/Poultry";
            break;
            case 7:
                return "Produce";
            break;
            case 8:
                return "Seafood";
            break;
            default:
                return "Opção inválida";
            break;
        }
    }
}
