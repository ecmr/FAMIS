<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Employes.ascx.cs" Inherits="Controles_Employes"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!-- Begin do Controle -->
<head>
  <title></title>
  <meta http-equiv="content-type" content="text/html; charset=utf-8" />
  <style type="text/css" media="all">
  	@import "../Css/Css.css";
   </style>
  <!--[if lte IE 7]>

  <style type="text/css" media="all">
  	@import "../Css/fieldset-background-image-ie.css";
      #header
      {
          width: 597px;
      }
  </style>

  <![endif]-->
<style type="text/css">

    * { margin: 0; padding: 0; }

#container { width: 600px; margin: 0 auto; }

    </style>
</head>
<body>
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
	<!-- BEGIN #page -->
    <div class="pageEmployee" >
        <!-- END #header -->
		<div class="contentEmployee">
			<form class="formEmployee" action="">
                <table style="width: 75%; height: 366px;" >
                    <tr>
                        <td colspan="3">
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>
                                    <fieldset class="fieldsetSubmitEmployeeButtons">
                                        <label class="LabelTitle" >Employes</label>
                                        <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" OnClick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Save"   ImageAlign="AbsMiddle" ImageUrl="~/images/Buttons/btnSave22.JPG" /></asp:LinkButton>
                                        <asp:LinkButton ID="lblChange" runat="server" BorderColor="ActiveBorder" >                          <asp:Image ID="btnChange" runat="server" ToolTip="Change" ImageAlign="AbsMiddle" ImageUrl="~/images/Buttons/btnChange22.JPG" /></asp:LinkButton>
                                        <asp:LinkButton ID="lblPrint" runat="server" BorderColor="ActiveBorder" >                           <asp:Image ID="btnPrint"  runat="server" ToolTip="Print"  ImageAlign="AbsMiddle" ImageUrl="~/images/Buttons/btnPrint22.JPG" /></asp:LinkButton>                                     
				                    </fieldset>                    
                                </ContentTemplate>
                            </asp:UpdatePanel>                    
                        </td>
                    </tr>
                        <tr>
                        <td class="colunaUm">
                            <fieldset class="fieldsetEmployeeC1">
					            <legend>
						            Details
					            </legend>
					            <ol style="height: 290px; width: 99%;">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:Table ID="tableEmployeeID" runat="server">
                                        <asp:TableRow runat="server">
                                            <asp:TableCell runat="server">ID:</asp:TableCell>
                                            <asp:TableCell ID="TableCell1" runat="server">Code</asp:TableCell>
                                        </asp:TableRow>
                                        <asp:TableRow ID="TableRow1" runat="server">
                                            <asp:TableCell ID="TableCell2" runat="server">
                                                <asp:TextBox ID="TxtEmployee_id" Enabled="false" Width="55px" Height="18px" runat="server"/>
                                            </asp:TableCell>
                                            <asp:TableCell ID="TableCell3" runat="server">
                                                <asp:TextBox ID="TxtCode" Height="18px" Width="150px" runat="server" ></asp:TextBox>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                    <li>
							            <label for="email">
								            First Name:
							            </label>
                                        <asp:TextBox ID="TxtFirstName" CssClass="text" runat="server"/>
                                        <asp:Label ID="lblMsgFn" runat="server" ></asp:Label>
						            </li>
                                    <li>
                                        <label for="lastName">
                                            Last Name:
                                        </label>
                                        <asp:TextBox ID="txtLast_name" CssClass="text" runat="server"></asp:TextBox>
                                        <asp:Label ID="lblMsgLn" runat="server"></asp:Label>
                                    </li>
                                    <li>
                                        <label for="Position">
                                            Position:
                                        </label>
                                        <asp:DropDownList ID="DropDownPosition" Height="22px" Width="206px" 
                                            runat="server"></asp:DropDownList>
                                    </li>
                                    <li>
                                        <label for="Agency">
                                            Agency:
                                        </label>
                                        <asp:DropDownList ID="DropDownAgency" Height="22px" Width="206px" 
                                            runat="server"></asp:DropDownList>
                                    </li>
                                    <li>
                                        <label for="Department">
                                            Department:
                                        </label>
                                        <asp:DropDownList ID="DropDownDepartment" Height="22px" Width="206px" 
                                            runat="server"></asp:DropDownList>
                                    </li>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                                    <li>
                                        <label for="Hireddate">
                                            Hired Date:
                                        </label>
                                        <asp:TextBox ID="txtDateHired" Height="18px" Width="140px" runat="server"></asp:TextBox>
                                        <asp:Label ID="lblmsgDate" runat="server" /> 
                                        <asp:ImageButton ID="ImgCalendar1" runat="server" ImageUrl="~/imagens/Crm/calon.gif" onclick="ImageButton1_Click" />
                                        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDateHired" Format="yyyy-MM-dd" PopupButtonID="ImgCalendar1" />
                                    <//li>    
					            </ol>
				            </fieldset>
                        </td>
                        <td class="colunaDois">
                        <fieldset class="fieldsetEmployeeC2">
	                        <legend>
		                        Salary    
	                        </legend>
	                        <ol style="height: 290px; width: 99%;">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        	                        <ContentTemplate>
			                        <li>
                                    <label class="labelEmployee_B">Amount</label>
                                    <asp:TextBox id="TxtAmount" runat="server" /><br />
                                <asp:panel ID="pnlAmount" runat="server" BackColor="Transparent" Width="180px" Height="207px" ScrollBars="Vertical" >
                                    <asp:Label id="lbloldAmt1" CssClass="labelEmployee_B" Text="Old Amount One" runat="server"/><br />
                                    <asp:TextBox id="txtOldAmt1" runat="server" /><br />
                                    <asp:label id="lbloldDt1" CssClass="labelEmployee_B"  Text="Old Date" runat="server" /><br />
                                    <asp:TextBox id="txtOldDt1" runat="server" /><br />
                                    <asp:label id="lbloldAmt2" Cssclass="labelEmployee_B" Text="Old Amount Two" runat="server" /><br />
                                    <asp:TextBox id="txtOldAmt2" runat="server" /><br />
                                    <asp:label id="lbloldDt2" Cssclass="labelEmployee_B" Text="Old Date" runat="server" /><br />
                                    <asp:TextBox id="txtOldDt2" runat="server" /><br />
                                </asp:panel><br />

                                <asp:Panel ID="PnlBonus" runat="server" BackColor="Transparent" Width="178px" Height="117px" >
                                <asp:Button ID="btnBonus" Text="Bonus" runat="server" onclick="btnBonus_Click" />
                                    <br />
                                    <asp:label ID="lblbonusAmt" Cssclass="labelEmployee_B" Text="Amount" runat="server" /><br />
                                    <asp:TextBox ID="txtBonusAmt" runat="server" /><br />
                                    <asp:label ID="lblbonusDt" Cssclass="labelEmployee_B" Text="Date" runat="server" /><br />
                                    <asp:TextBox ID="txtBonusDt" Width="120px" runat="server" />
                                    <asp:ImageButton ID="imgCalendarBonus" runat="server" ImageUrl="~/imagens/Crm/calon.gif" OnClick="imgCalendarBonus_Click" />
                                    <asp:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtBonusDt" Format="yyyy-MM-dd" PopupButtonID="imgCalendarBonus" />
                                </asp:Panel>
                                    </li>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
	                        </ol>
                        </fieldset>                           
                        </td>
                        <td class="colunaTres">
                            <fieldset class="fieldsetEmployeeC3">
					                    <legend>
						                    Employee Photo
					                    </legend>
                                        &nbsp;&nbsp;<asp:Image ID="PicturePhoto" runat="server" 
                                            ImageUrl="~/imagens/Pictures/Edinei.JPG" Width="220px" Height="175px" 
                                            BorderStyle="Solid" BorderWidth="2px" style="margin-top: 0px; top: 0;" 
                                            ImageAlign="Top" /><br />
                                            <asp:FileUpload ID="FileUploadPhoto" runat="server" EnableViewState="false" />
                                        <fieldset style="width: 252px;">
                                            <legend>
                                                Curriculum Vitae
                                            </legend>
                                            <asp:FileUpload ID="FileUploadCV" runat="server" EnableViewState="false" />    
                                            <div id="btnCv">
                                                <asp:LinkButton ID="linkCV" runat="server" BorderColor="ActiveBorder" OnClick="lkbCV_Click" ><asp:Image ID="ImageCV" runat="server" ToolTip="Open Curriculum Vitae" ImageAlign="AbsMiddle" ImageUrl="~/images/Buttons/PDF_Logo.JPG" Height="18px" Width="18px" BackColor="Transparent"  /><asp:Label ID="Label1" Text=" Open Currículum" runat="server" /></asp:LinkButton>
                                            </div>                                        
                                        </fieldset>
                                            <asp:Button ID="UploadPhoto" OnClick="UploadPhoto_Click" Width="90px" Height="23px"  runat="server" Text="Upload files" /><br />
                            </fieldset>
					    </td></tr></table><asp:UpdatePanel ID="UpdatePanel3" runat="server">
                    <ContentTemplate>
                        <fieldset class="fieldsetEmployeeList">
					        <legend>
						        Employee List </legend><ol class="OlEmployeeList">
						        <li class="LIEmployeeList">
                                    <asp:GridView ID="grvEmployee" runat="server" 
                                        AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="839px" DataKeyNames="employee_id,first_name,last_name"  
                                    OnPageIndexChanging="grvEmployee_PageIndexChanging" 
                                     onselectedindexchanged="grvEmployee_SelectedIndexChanged"><Columns>
                                      <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" 
                                              HeaderStyle-CssClass="grid_tittle" >
                                        <ItemTemplate>
                                          <asp:ImageButton ID="btnEditar" runat="server" 
                                                ImageUrl="~/Imagens/Icones/editar.gif" ToolTip="Editar" 
                                                OnClick="btnEditar_Click" />
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="grid_tittle"></HeaderStyle>
                                        <ItemStyle Width="2%"></ItemStyle>
                                      </asp:TemplateField>
                                      <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" 
                                              HeaderStyle-CssClass="grid_tittle_div">
                                        <ItemTemplate>
                                          <asp:ImageButton ID="btnExcluir" runat="server" 
                                                ImageUrl="~/Imagens/Icones/excluir.gif" ToolTip="Excluir" 
                                                OnClick="btnExcluir_Click" />
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="grid_tittle_div"></HeaderStyle>
                                        <ItemStyle Width="2%"></ItemStyle>
                                      </asp:TemplateField>
                                      <asp:BoundField HeaderText="ID" HeaderStyle-HorizontalAlign="Center" 
                                              DataField="employee_id" HeaderStyle-CssClass="grid_tittle_div" 
                                              HeaderStyle-Width="20%"><HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="First Name" HeaderStyle-HorizontalAlign="Center" 
                                              DataField="first_name" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="30%"><HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="Last Name" HeaderStyle-HorizontalAlign="Center" 
                                              DataField="last_name" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="50%"><HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                      </asp:BoundField>
				                    </Columns>
                                    <pagerstyle backcolor="LightBlue"/>                
                                    <FooterStyle />
                                    <RowStyle CssClass="grid_line_01" />
                                    <HeaderStyle />
                                    <AlternatingRowStyle CssClass="grid_line_02" />
                                </asp:GridView>
						        </li>
					        </ol>
				        </fieldset>        
                    </ContentTemplate>
                </asp:UpdatePanel>
			</form>
		</div><!-- END #content -->
	</div> 
    <!-- END #page -->
    <!-- END #page -->
</body>
<!-- End do Controle -->