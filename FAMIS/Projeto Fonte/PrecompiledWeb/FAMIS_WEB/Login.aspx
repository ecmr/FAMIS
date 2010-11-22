<%@ page language="C#" autoeventwireup="true" inherits="Login, App_Web_at13n3yt" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd"><html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en">
<!-- **** DESIGN INFORMATION: start head **** --> 
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>FAMIS - GREY</title>
<link href="Css/Css.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="Js/Login.js"></script>
<script type="text/javascript" language="javascript">
<!--
    function start(user) {
        //Excluir
        if (user == 'uts')
        {
            var winOpen = window.open('Timesheet.aspx', '', 'resizable=no,scrooling=no');
	        winOpen.moveTo(0, 0);
	        //winOpen.resizeTo(screen.availWidth - 293, screen.availHeight);
	        window.opener = window;
	        window.close();        
        }
        else
        {
            var winOpen = window.open('Default.aspx', '', 'resizable=no,scrollbars=yes'); //scrooling=no,
	        winOpen.moveTo(0, 0);
	        winOpen.resizeTo(screen.availWidth, screen.availHeight);
	        window.opener = window;
	        window.close();
	    }
    }
    function WindowSize()
    {
/*            var winOpen = window.open('Login.aspx', '', 'resizable=no,scrooling=no,menubar=no,toolbar=no');
	        winOpen.moveTo(0, 0);
	        winOpen.resizeTo(400, 500);
	        window.opener = window;
	        window.close();        
*/
    }
//-->
</script>

</head>
<!-- **** DESIGN INFORMATION: end head **** --> 


<!-- **** DESIGN INFORMATION: BODY **** --> 
<body >
<form id="Form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
<div id="framecontent">
	<div id="toplogo">

        <img src="Imagens/topo/logo_puro.jpg"/></div>
    <div id="toplogin"></div>
    <div id="topmenu"></div>
</div>


<!-- *******************************************************************************
 DESIGN INFORMATION: start div content 
******************************************************************************** --> 
<div id="logincontent">
<div class="logincontentform">

    <div id="wraplogin" style="width:350px; height:200px; margin: auto; background-color:#FFF; border:solid 1px #6693cf;">
      <div id="logintitulo"><img src="Imagens/div_titulo.gif" align="middle">Login</div>
            <div id="mensagemerro"><img src="Imagens/login/login_erro.png" alt="" align="middle" class="loginerro">Inválid user and password!</div>
	  <div id="loginimagem"><img src="Imagens/login/login.png" alt=""></div>
      <div id="loginusuario">
      <ul>
      	<li>User</li>
        <li>
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="txtbox" style="width:180px" ></asp:TextBox></li>
        <li>Password</li>
        <li><asp:TextBox ID="txtSenha" runat="server" CssClass="txtbox" style="width:180px" 
                TextMode="Password" ></asp:TextBox></li>
        <li>
            <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="~/Imagens/Login/btn_login.png" onclick="btnLogin_Click" CssClass="loginbtn" /></li>
      </ul>
      </div>
    </div>
    
</div>    
</div>
<!-- *******************************************************************************
 DESIGN INFORMATION: end div content 
******************************************************************************** --> 


<!-- *******************************************************************************
 DESIGN INFORMATION: start modal 
******************************************************************************** -->
<asp:Button id="btnPesquisarHidden" Visible="false" runat="server" /> 
<!-- <input id="btnPesquisarHidden" type="hidden" /> -->

<asp:Panel ID="pnCad" runat="server" CssClass="modal">
<div class="contentformpopup">
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td id="formtitulo"><img alt="" src="../Imagens/div_titulo.gif" align="middle"/>Alterar Senha</td>
  </tr>
  <tr>
    <td>
    <table width="99%" align="right" border="0" cellspacing="3" cellpadding="0" id="formfont">
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td width="25%">&nbsp;</td>
    <td width="25%">&nbsp;</td>
  </tr>
  <tr>
    <td width="25%">Old password:</td>
    <td width="25%">New password:</td>
    <td>confirm password:</td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td><asp:TextBox ID="txtSenhaAnterior" runat="server" CssClass="txtbox" Width="90%"/></td>
    <td><asp:TextBox ID="txtNovaSenha" runat="server" CssClass="txtbox" Width="90%"/></td>
    <td><asp:TextBox ID="txtConfirmarSenha" runat="server" CssClass="txtbox" Width="90%"/></td>
    <td>&nbsp;</td>
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
    <td>&nbsp;</td>
  </tr>
</table>
    </td>
  </tr>
  <tr>
    <td id="botoes">
        <!-- **** DESIGN INFORMATION: start botoes form **** -->
    	<div id="botoesform">
	    <ul>
	        <li><asp:LinkButton ID="lkbSalvar" runat="server" ><asp:Image ID="imgSalvar" runat="server" ImageAlign="AbsMiddle" ImageUrl="../Imagens/Icones/salvar.gif"/> Save</asp:LinkButton></li>                
	        <li class="separator"></li>
	        <li><asp:LinkButton ID="lkbCancelar" runat="server" ><asp:Image ID="imgSancelar" runat="server" ToolTip="Cancelar" ImageAlign="AbsMiddle" ImageUrl="../Imagens/Icones/cancelar.gif"/> Cancel</asp:LinkButton></li>
	    </ul>
	    </div>
	    <!-- **** DESIGN INFORMATION: end botoes form **** -->      
    </td>
  </tr>
</table>

</div>
</asp:Panel>
<!-- *******************************************************************************
 DESIGN INFORMATION: end modal 
******************************************************************************** -->
</form>
</body>
</html>
<!-- **** DESIGN INFORMATION: BODY **** --> 