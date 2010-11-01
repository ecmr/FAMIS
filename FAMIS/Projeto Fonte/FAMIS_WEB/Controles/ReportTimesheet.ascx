<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportTimesheet.ascx.cs" Inherits="Controles_ReportTimesheet" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>

<rsweb:ReportViewer ID="RVTimesheet" ShowToolBar="true" runat="server" Width="712px">
</rsweb:ReportViewer>


