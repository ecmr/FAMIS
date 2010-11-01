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
using Microsoft.Reporting.WebForms;
using System.IO; 

public partial class Controles_ReportTimesheet : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //ReportParameter[] myParam; 

            //myParam(0) = new ReportParameter("de", AnoInicial);
            //myParam(1) = new ReportParameter("ate", AnoFinal);
            //myParam(2) = new ReportParameter("codigocomercial", condicaoEstrutura);
            //myParam(3) = new ReportParameter("codigoproduto", condicaoLinha);
            //myParam(4) = new ReportParameter("codigocliente", condicaoCliente);
            //myParam(5) = new ReportParameter("MesDe", MesInicial);
            //myParam(6) = new ReportParameter("MesAte", MesFinal);

            RVTimesheet.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["ReportingServer"]);
            RVTimesheet.ServerReport.ReportPath = Path.Combine(ConfigurationManager.AppSettings["ReportingPath"], "Timesheet");  
            //RVTimesheet.ServerReport.SetParameters(myParam);
            //'RVRelatorioFaturamento.ServerReport.Refresh() ' Também Funciona
            
            RVTimesheet.DataBind();
        }
    }
}
