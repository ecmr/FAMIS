<%@ control language="C#" autoeventwireup="true" inherits="Modelo, App_Web_zlagw1yj" %>
<style type="text/css">
    .style3
    {
        color: #0000FF;
        font-weight: bold;
        font-size: x-large;
    }
</style>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<link href="Css/Css.css" rel="Stylesheet" type="text/css"/>
<table border="0" cellspacing="0" cellpadding="0" style="width: 53%" 
    align="left">
  <tr>
    <td id="formtitulo"><img src="imagens/div_titulo.gif" align="absmiddle"/><span 
            class="style3">Users</span></td>
  </tr>
  <tr>
    <td>
        <table width="99%" align="center" border="0" cellspacing="3" cellpadding="0" id="formfont">
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td width="25%">&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td width="25%">Agency id</td>
          <td width="25%">&nbsp;</td>
          <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
          <td>
              <asp:TextBox ID="txtAgency_id" Enabled="false" runat="server"></asp:TextBox>
            </td>
          <td>&nbsp;</td>
          <td colspan="2">&nbsp;</td>
        </tr>
            <tr>
          <td width="25%">Agency Name</td>
          <td width="25%">&nbsp;</td>
          <td colspan="2">&nbsp;</td>
                    </tr>
            <tr>
          <td>
              <asp:TextBox ID="txtAgencyName" runat="server"></asp:TextBox>
            </td>
          <td>
              &nbsp;</td>
          <td colspan="2">&nbsp;</td>
            </tr>
        <tr>
          <td colspan="4">
              Picture</td>
        </tr>
        <tr>
          <td colspan="4">
              <br />
              </td>
        </tr>
        </table>
    </td>
  </tr>
  <tr>
    <td id="botoes">
    	    <div id="botoesform">
	        </div>   
    </td>
  </tr>
</table>