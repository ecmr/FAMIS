<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SetupMenu.aspx.cs" Inherits="Principal_SetupMenu" %>

<%@ Register src="../Controles/MenuTopo.ascx" tagname="MenuTopo" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >


<!-- **** DESIGN INFORMATION: start head **** --> 
<head id="Head1" runat="server">
    <title>FAMIS - Grey: Setup Menu</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <script type="text/javascript" src="../Js/menu-for-applications.js"></script>
    <link href="../Css/Css.css" rel="stylesheet" type="text/css" />
    <link href="../Css/MenuBar.css" rel="stylesheet" media="screen" type="text/css" />
    <script type="text/javascript" src="../Js/Includes.js"></script>    
    <style type="text/css">
        .style1
        {
            width: 36px;
        }
        .style5
        {
            width: 59px;
        }
        .style6
        {
            width: 39px;
        }
        .style7
        {
            width: 58px;
        }
    </style>
</head>
<!-- **** DESIGN INFORMATION: end /head **** --> 


<!-- **** DESIGN INFORMATION: BODY **** --> 
<body>
<form id="form1" runat="server" >
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


<!-- *******************************************************************************
 DESIGN INFORMATION: start div top 
******************************************************************************** -->
<div id="framecontent">
	<div id="toplogo"><img src="../Images/topo/logo.jpg"></div>
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
    <td id="formtitulo"><img src="../Images/div_titulo.gif" align="absmiddle"/>FAMIS System:: Setup Menu</td>
  </tr>
  <tr>
    <td>
        &nbsp;</td>
  </tr>
  <tr>
    <td id="botoes">
        <!-- **** DESIGN INFORMATION: start botoes form **** -->
    	<div id="botoesform">
	    <ul>
	        <li></li>
	        <li class="separator"></li>
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
        <br />
        <br />
      </div>
      <div id="MainMenu">
        <br />
        <table cellpadding="0" cellspacing="0" width="836" align="center">
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td align="center" class="style6">
                    <a href="../Modelo Layout/Agency.aspx"><img src="../Images/Menu/ico_syssettings.gif"  border="0" /></a>
                </td>
                <td>
                    <a href="../Modelo Layout/Agency.aspx" class="Custom_menuBar_top" >
                    Maintence Agencies<br />
                    </a></td>
                <td class="style7">
                    <img src="../Images/Menu/ico_settings.gif"   onclick=""   />
                </td>
                <td>
                    <a href="../Modelo Layout/Agency.aspx" class="Custom_menuBar_top">
                    Timesheet</a><a href="../Modelo%20Layout/Agency.aspx"></a></td>
                <td class="style5">
                    <img src="../Images/Menu/ico_relationship_role_manager.gif"  onclick=""   />
                </td>
                <td>
                    <a href="../Modelo Layout/Agency.aspx" class="Custom_menuBar_top">
                    Human Resources </a>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td align="center" class="style6">
                    <a href="../Modelo Layout/Agency.aspx" class="Custom_menuBar_top"><img src="../Images/Menu/ico_transactioncurrency.gif"   border="0" /></a>
                </td>
                <td>
                    <a href="../Modelo Layout/Agency.aspx" class="Custom_menuBar_top">
                    Budget </a></td>
                <td class="style7">
                    <img src="../Images/Menu/ico_transactioncurrency.gif"  onclick=""   />
                </td>
                <td>
                    <a href="../Modelo Layout/Agency.aspx" class="Custom_menuBar_top">
                    Billing</a></td>
                <td class="style5">
                    
                </td>
                <td>
                    
                </td>
                <td>
                    
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;&nbsp;
                    <br />
                    &nbsp;</td>
                <td class="style6">
                </td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>            
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>                                                            
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>                                                            
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>                                                            
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>                                                            
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>                                                            
        </table>      
        <br />      
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