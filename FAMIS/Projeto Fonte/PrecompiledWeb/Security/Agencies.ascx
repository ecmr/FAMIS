<%@ Control ClassName="ctrlAgencies" %> <!-- Language="C#" AutoEventWireup="true" CodeFile="Agencies.ascx.cs" Inherits="Security_Agencies" -->
<script runat="server"></script>
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<div id="framecontent">
<!--    <div id="toplogin">
    <ul>
    	<li><b><asp:Label ID="lblLogin" runat="server" Text="Edinei Menezes"></asp:Label></b></li>
        <li><asp:Label ID="lblEmpresa" runat="server" Text="FAMIS - Grey"></asp:Label></li>
    </ul>
    </div>   
</div>
-->    
<div id="maincontent">
<div class="contentform">

<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td id="formtitulo">&nbsp;</td>
  </tr>
  <tr>
    <td><table width="99%" align="right" border="0" cellspacing="3" cellpadding="0" id="formfont">
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td width="25%">&nbsp;</td>
          <td width="25%">&nbsp;</td>
        </tr>
        <tr>
          <td width="25%">Agency ID:</td>
          <td width="25%">Agency Name:</td>
          <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
          <td>
              <asp:TextBox ID="txtAgency_id" Enabled="false" runat="server"></asp:TextBox>
            </td>
          <td><asp:TextBox ID="txtAgency_name" runat="server" CssClass="txtbox" Width="88%"/></td>
          <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
          <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
          <td colspan="4"><table width="100%" border="0" cellspacing="1" cellpadding="0" id="formfont">
              <tr>
                <td width="48%"><asp:TextBox ID="txtAgencyAdd" runat="server" CssClass="txtbox" Width="98%" TextMode="MultiLine" Height="120px"/></td>
                <td width="4%" align="center"><table border="0" cellspacing="0" cellpadding="2">
                  <tr>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    <td>&nbsp;</td>
                  </tr>
                  <tr>
                    
                  </tr>
                </table></td>
                <td width="48%">&nbsp;</td>
              </tr>
            </table></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
        </tr>
      </table></td>
  </tr>
  <tr>
    <td id="botoes">
        <!-- **** DESIGN INFORMATION: start botoes form **** -->
    	<div id="botoesform">
	    <ul>
	        <li><asp:LinkButton ID="lkbSalvar" runat="server" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Icones/salvar.gif"/> 
                Salvar X</asp:LinkButton></li>
	        <li class="separator"></li>
	        <li><asp:LinkButton ID="lkbCancelar" runat="server"><asp:Image ID="btnCancelar" runat="server" ToolTip="Cancelar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Icones/cancelar.gif"/> 
                Cancelar</asp:LinkButton></li>
	    </ul>
	    </div>
	    <!-- **** DESIGN INFORMATION: end botoes form **** -->   
    </td>
  </tr>
</table>
<!-- *******************************************************************************
 DESIGN INFORMATION: end form 
******************************************************************************** -->


</div>
</div>

    <script type="text/javascript">
        $.ajax({
            type: "POST",
            url: "../Controles/Menu.asmx/Generate",
            data: "{}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function(msg) {
                $("#menuModel").html(msg.d);

                var menuModel = new DHTMLSuite.menuModel();
                DHTMLSuite.configObj.setCssPath('css/');
                menuModel.addItemsFromMarkup('menuModel');
                menuModel.setMainMenuGroupWidth(00);
                menuModel.init();
                var menuBar = new DHTMLSuite.menuBar();
                menuBar.addMenuItems(menuModel);
                menuBar.setTarget('menuDiv');
                menuBar.init();
            },
            error: function(msg) {
                alert(msg);
            }
        });
</script>
