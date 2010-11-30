using System;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASP;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["Id"] == null)
        {
            Control ctrlRet = Page.LoadControl("~/Controles/TESTE_LAYOUT.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);

            //Control ctrlRet = Page.LoadControl("~/Controles/Agencies.ascx");
            //PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle de Agencias    
        else if (Request.QueryString["Id"].Trim()=="1")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Agencies.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);   
        }
        //Chamda do controle de Clients
        else if (Request.QueryString["Id"].Trim() == "2")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Clients.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);   
        }
        //Chamda do controle de Countries
        else if (Request.QueryString["Id"].Trim() == "3")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Countries.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);   
        }
        //Chamda do controle Department     
        else if (Request.QueryString["Id"].Trim() == "4")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Departments.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Employee     
        else if (Request.QueryString["Id"].Trim() == "5")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Employes.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Geospec     
        else if (Request.QueryString["Id"].Trim() == "6")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Geospecs.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }

        //Chamda do controle de Group    
        else if (Request.QueryString["Id"].Trim() == "7")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Groups.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Location     
        else if (Request.QueryString["Id"].Trim() == "8")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Locations.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Positions     
        else if (Request.QueryString["Id"].Trim() == "9")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Positions.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Regions     
        else if (Request.QueryString["Id"].Trim() == "10")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Regions.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Users     
        else if (Request.QueryString["Id"].Trim() == "11")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Users.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Apontamento 
        else if (Request.QueryString["Id"].Trim() == "12")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/UserAppointment.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Apontamento 
        else if (Request.QueryString["Id"].Trim() == "30")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/TESTE_LAYOUT.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Timesheet 
        else if (Request.QueryString["Id"].Trim() == "50")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/Timesheet.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);
        }
        //Chamda do controle Report Timesheet 
        else if (Request.QueryString["Id"].Trim() == "101")
        {
            Control ctrlRet = Page.LoadControl("~/Controles/ReportTimesheet.ascx");
            
            PlaceHolder1.Controls.Add(ctrlRet);
        }

        else
        {
            //PlaceHolder1.Controls.Add(Home());
            Control ctrlRet = Page.LoadControl("~/Controles/NewModel.ascx"); //  Agencies.ascx");
            PlaceHolder1.Controls.Add(ctrlRet);   
        }
    }

    private Label Home()
    {
        Label lblHome = new Label();
        //lblHome.Text = "Selecione um item do menu ao lado.";
        lblHome.Text = "Select one iten in side menu.";
        lblHome.Font.Name="Verdana";
        lblHome.Font.Size = 14;
        return lblHome;
    }    
}
