<%@ page language="C#" masterpagefile="~/Layout.master" autoeventwireup="true" inherits="_Default, App_Web_1a2fnefw" %>
<%@ Reference Control="~/Controles/Agencies.ascx" %>
<%@ Reference Control="~/Controles/Clients.ascx"%>
<%@ Reference Control="~/Controles/Countries.ascx"%>
<%@ Reference Control="~/Controles/Departments.ascx"%>
<%@ Reference Control="~/Controles/Employes.ascx"%> 
<%@ Reference Control="~/Controles/Geospecs.ascx"%>
<%@ Reference Control="~/Controles/Locations.ascx"%>
<%@ Reference Control="~/Controles/Positions.ascx"%>
<%@ Reference Control="~/Controles/Regions.ascx"%>
<%@ Reference Control="~/Controles/Users.ascx"%>
<%@ Reference Control="~/Controles/Timesheet.ascx" %>
<%@ Reference Control="~/Controles/ControleModelo.ascx" %>
<%@ Reference Control="~/Controles/ReportTimesheet.ascx" %> 
     
<asp:Content ContentPlaceHolderID="ConteudoCentral" runat="server">
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
</asp:Content>