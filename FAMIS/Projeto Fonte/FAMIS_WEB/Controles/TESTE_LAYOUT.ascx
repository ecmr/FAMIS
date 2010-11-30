<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TESTE_LAYOUT.ascx.cs" Inherits="Controles_TESTE_LAYOUT" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<html>
<head>
    <title></title>
</head>
<body>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
<table style="width:100%;">
    <tr>
    <td>

        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" 
            ConfirmText="E ae?" Enabled="True" TargetControlID="Button1">
        </asp:ConfirmButtonExtender>

    </td>
    </tr>
</table>
</body>
</html>

