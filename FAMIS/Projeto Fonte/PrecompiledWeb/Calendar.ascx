<!--Arquivo de exemplo:Calendar.ascx-->
<%@ control language="C#" autoeventwireup="true" inherits="Calendar, App_Web_wegg2lxr" %>
<asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White"
    BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px"
    NextPrevFormat="FullMonth" Width="350px">
    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
    <TodayDayStyle BackColor="#CCCCCC" />
    <OtherMonthDayStyle ForeColor="#999999" />
    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
        Font-Size="12pt" ForeColor="#333399" />
</asp:Calendar>
