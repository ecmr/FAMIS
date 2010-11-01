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
using System.Diagnostics;
using FAMIS_BLL;

public partial class Controles_UserAppointment : System.Web.UI.UserControl
{
    Stopwatch sw;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FAMIS_BLL.Timesheet _timesheet = new Timesheet();
            Timer1.Enabled = false;

            DropDownCliPro.DataSource = _timesheet.LoadDropDow();
            DropDownCliPro.DataTextField = "clientProject_name";
            DropDownCliPro.DataValueField = "clientProject_id";
            DropDownCliPro.DataBind();

            Model.User _user = (Model.User)HttpContext.Current.Session["UsuarioLogado"];
            LblUser.Text += _user.User_id.ToString() + "-" + _user.First_name.ToString();
            DateTime dtDaysW = DateTime.Now;
            lblDaysWeek.Text = dtDaysW.DayOfWeek.ToString() + " " + dtDaysW.Month.ToString() + "/" + dtDaysW.Day.ToString();
        }
    }

    protected void UpdateTimer_Tick(object sender, EventArgs e)
    {
        if (Convert.ToInt32(HttpContext.Current.Session["iSecound"]) >= 59)
        {
            HttpContext.Current.Session["iSecound"] = 0;
            HttpContext.Current.Session["iMinute"] = Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + 1;
            if (Convert.ToInt32(HttpContext.Current.Session["iMinute"]) >= 9)
            {
                lblTime.Text = "00:" + Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + ":0" + Convert.ToInt32(HttpContext.Current.Session["iSecound"]);
            }
            else
            {
                lblTime.Text = "00:0" + Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + ":0" + Convert.ToInt32(HttpContext.Current.Session["iSecound"]);
            }

        }
        else if (Convert.ToInt32(HttpContext.Current.Session["iSecound"]) < 9)
        {
            HttpContext.Current.Session["iSecound"] = Convert.ToInt32(HttpContext.Current.Session["iSecound"]) + 1;
            if (Convert.ToInt32(HttpContext.Current.Session["iMinute"]) >= 9)
            {
                lblTime.Text = "00:" + Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + ":0" + Convert.ToInt32(HttpContext.Current.Session["iSecound"]);
            }
            else
            {
                lblTime.Text = "00:0" + Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + ":0" + Convert.ToInt32(HttpContext.Current.Session["iSecound"]);
            }
        }
        else if (Convert.ToInt32(HttpContext.Current.Session["iSecound"]) >= 9)
        {
            HttpContext.Current.Session["iSecound"] = Convert.ToInt32(HttpContext.Current.Session["iSecound"]) + 1;
            lblTime.Text = "00:0" + Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + ":" + Convert.ToInt32(HttpContext.Current.Session["iSecound"]);
        }
        else if (Convert.ToInt32(HttpContext.Current.Session["iSecound"]) >= 9 && Convert.ToInt32(HttpContext.Current.Session["iMinute"]) >= 9)
        {
            HttpContext.Current.Session["iSecound"] = Convert.ToInt32(HttpContext.Current.Session["iSecound"]) + 1;
            lblTime.Text = "00:" + Convert.ToInt32(HttpContext.Current.Session["iMinute"]) + ":" + Convert.ToInt32(HttpContext.Current.Session["iSecound"]);
        }

    }

    protected void imgStart_Click(object sender, ImageClickEventArgs e)
    {
        Timer1.Enabled = true;
        sw = new Stopwatch();
        sw.Start();
        Session.Add("Cronometro", sw);

        BeginJob();
    }

    protected void Timer1_Tick1(object sender, EventArgs e)
    {
        Stopwatch swL = Session["Cronometro"] as Stopwatch;

        TimeSpan ts = swL.Elapsed;
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        lblTime.Text = elapsedTime.ToString();

    }

    protected void imgComent_Click(object sender, ImageClickEventArgs e)
    {
        txtcoment.Visible = true;
        btnComentSend.Visible = true;
    }

    protected void btnComentSend_Click(object sender, EventArgs e)
    {
        FAMIS_BLL.Timesheet _timesheet = new Timesheet();
        Model.Timesheet ts = new Model.Timesheet();

        ts.Timesheet_id = Convert.ToInt32(HttpContext.Current.Session["Timesheet_id"]);

        Model.Timesheet _TsComment = _timesheet.SelectQuery(" Where timesheet_id=" + ts.Timesheet_id);
        ts.Coment = _TsComment.Coment + Environment.NewLine + txtcoment.Text;
        _TsComment = null;
        _timesheet.Update(ts);

        txtcoment.Visible = false;
        txtcoment.Text = "";
        btnComentSend.Visible = false;
    }

    protected void imgStop_Click(object sender, ImageClickEventArgs e)
    {
        Timer1.Enabled = false;
        FAMIS_BLL.Timesheet _timesheet = new Timesheet();
        string sRet = _timesheet.StopTime(Convert.ToInt32(HttpContext.Current.Session["Timesheet_id"]));
        _timesheet = null; 
    }

    private void BeginJob()
    {
        FAMIS_BLL.Timesheet _timesheet = new Timesheet();
        Model.Timesheet ts = new Model.Timesheet();
        ts.Coment = txtcoment.Text;
        Model.ClientProject _cp = _timesheet.GetClientProjectID(Convert.ToInt32(DropDownCliPro.SelectedItem.Value));
        ts.Client_id = _cp.Client_id;
        ts.Project_id = _cp.Project_id; 
        Model.User _user = (Model.User)HttpContext.Current.Session["UsuarioLogado"];
        ts.User_id = _user.User_id;
        ts.StartTime = DateTime.Now;
        _timesheet.Add(ts);
        //Grava na session o id do timesheet
        //Para gravar possiveis comments...
        Model.Timesheet _timesheetUid = _timesheet.SelectQuery("Where client_id=" + ts.Client_id + " and Project_id=" + ts.Project_id + " and user_id=" + ts.User_id + " and startTime='" + ts.StartTime + "' ");
        HttpContext.Current.Session.Add("Timesheet_id", _timesheetUid.Timesheet_id.ToString());
    }
}
