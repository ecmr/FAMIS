<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TESTENEWPAGE.ascx.cs" Inherits="Controles_TESTENEWPAGE" %>

<%@ Register src="../Controles/MenuTopo.ascx" tagname="MenuTopo" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >


<!-- **** DESIGN INFORMATION: start head **** --> 
<head id="Head1">SARAIVA - SEGMENTA��O</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <script type="text/javascript" src="../Js/menu-for-applications.js"></script>
    <link href="../Css/Css.css" rel="stylesheet" type="text/css" />
    <link href="../Css/MenuBar.css" rel="stylesheet" media="screen" type="text/css" />
    <script type="text/javascript" src="../Js/Includes.js"></script>    
</head>
<!-- **** DESIGN INFORMATION: end /head **** --> 


<!-- **** DESIGN INFORMATION: BODY **** --> 
<body>
<form id="form1" >
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


<!-- *******************************************************************************
 DESIGN INFORMATION: start div top 
******************************************************************************** -->
<div id="framecontent">
	<div id="toplogo"><img src="../Imagens/topo/logo.jpg"></div>
    <div id="toplogin">
    <ul>
    	<li><b><asp:Label ID="lblLogin" runat="server" Text="Rodrigo Nobrega"></asp:Label></b></li>
        <li><asp:Label ID="lblEmpresa" runat="server" Text="W IT Solutions"></asp:Label></li>
    </ul>
    </div>   
    <div id="topmenu"><uc2:MenuTopo ID="MenuTopo1" runat="server" /></div>
</div>    
<!-- *******************************************************************************
 DESIGN INFORMATION: end div top 
******************************************************************************** -->


<!-- *******************************************************************************
 DESIGN INFORMATION: start div content 
******************************************************************************** -->  
<div id="maincontent">
<div class="contentform">


<!-- *******************************************************************************
 DESIGN INFORMATION: start form
******************************************************************************** --> 
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td id="formtitulo"><img src="../Imagens/div_titulo.gif" alt="" align="middle"/>Seguran�a | Usu�rio | Manuten��o</td>
  </tr>
  <tr>
    <td>
    <table width="99%" align="right" border="0" cellspacing="3" cellpadding="0" id="formfont">
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
          <td width="25%">Nome do Usu�rio:</td>
          <td width="25%">Email:</td>
          <td width="25%">Senha:</td>
          <td width="25%" colspan="2">Confirmar Senha:</td>
        </tr>
        <tr>
          <td><asp:TextBox ID="txtNomeUsuario" runat="server" CssClass="txtbox" Width="95%"/></td>
          <td><asp:TextBox ID="txtEmail" runat="server" CssClass="txtbox" Width="95%"/></td>
          <td><asp:TextBox ID="txtSenha" runat="server" CssClass="txtbox" Width="95%"/></td>
          <td><asp:TextBox ID="txtConfirmarSenha" runat="server" CssClass="txtbox" Width="95%"/></td>
          <td width="12%"><asp:CheckBox ID="ckbAlterarSenha" runat="server" Text='&nbsp;Alterar Senha'/></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td>&nbsp;</td>
          <td colspan="2">&nbsp;</td>
        </tr>
      </table>
      </td>
  </tr>
  <tr>
    <td id="botoes">
        <!-- **** DESIGN INFORMATION: start botoes form **** -->
    	<div id="botoesform">
	    <ul>
	        <li><asp:LinkButton ID="lkbSalvar" runat="server" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="../Imagens/Icones/salvar.gif"/> Salvar</asp:LinkButton></li>
	        <li class="separator"></li>
	        <li><asp:LinkButton ID="lkbCancelar" runat="server" ><asp:Image ID="btnCancelar" runat="server" ToolTip="Cancelar" ImageAlign="AbsMiddle" ImageUrl="../Imagens/Icones/cancelar.gif"/> Cancelar</asp:LinkButton></li>
	    </ul>
	    </div>
	    <!-- **** DESIGN INFORMATION: end botoes form **** -->    
    </td>
  </tr>
  <tr>
    <td>
<!-- *******************************************************************************
 DESIGN INFORMATION: start grid
******************************************************************************** -->        
    <div id="gridform">
        <asp:GridView ID="grvManutencaoUsuarios" runat="server" AutoGenerateColumns="False" GridLines="none"
        Width="100%" AllowPaging="false" CellPadding="4">
          <FooterStyle/>
          <RowStyle CssClass="grid_line_01" />
          <Columns>
          <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle">
            <ItemTemplate>
              <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagens/Icones/editar.gif" ToolTip="Editar"/>
            </ItemTemplate>
            <HeaderStyle CssClass="grid_tittle"></HeaderStyle>
            <ItemStyle CssClass="grid_ico" Width="2%"></ItemStyle>
          </asp:TemplateField>
          <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle_div">
            <ItemTemplate>
              <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Imagens/Icones/excluir.gif" ToolTip="Excluir" />
            </ItemTemplate>
            <HeaderStyle CssClass="grid_tittle_div"></HeaderStyle>
            <ItemStyle CssClass="grid_ico" Width="2%"></ItemStyle>
          </asp:TemplateField>
          <asp:BoundField HeaderText="C�digo" HeaderStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle_div" HeaderStyle-Width="10%">
            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
          </asp:BoundField>
          <asp:BoundField HeaderText="Nome" HeaderStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle_div" HeaderStyle-Width="60%">
            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
          </asp:BoundField>
          <asp:BoundField HeaderText="Email" HeaderStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle" HeaderStyle-Width="40%">
            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
          </asp:BoundField>
          </Columns>
          <HeaderStyle/>
          <AlternatingRowStyle CssClass="grid_line_02"/>
        </asp:GridView>
      </div>
<!-- *******************************************************************************
 DESIGN INFORMATION: end grid
******************************************************************************** -->          
      </td>
  </tr>
</table>
<!-- *******************************************************************************
 DESIGN INFORMATION: end form
******************************************************************************** --> 


</div>
</div>
</form>
<!-- *******************************************************************************
 DESIGN INFORMATION: end div content 
******************************************************************************** --> 


<!-- *******************************************************************************
 DESIGN INFORMATION: start script page frames 
******************************************************************************** -->
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
<!-- *******************************************************************************
 DESIGN INFORMATION: start script page frames 
******************************************************************************** -->   
</body>
</html>
<!-- **** DESIGN INFORMATION: BODY **** -->