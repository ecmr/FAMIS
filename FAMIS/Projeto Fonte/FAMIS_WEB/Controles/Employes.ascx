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

#colunaUm {

	width: 149px;

	float: left;
        height: 61px;
    }

#colunaDois {

	width: 200px;

	float: left;
        height: 48px;
    }
</style>
</head>
<body>
	<div class="pageEmployee" >
		<div class="headerEmployee" >
			<h1>
				Employes
			</h1>
		</div> 
        <!-- END #header -->
		<div class="contentEmployee">
			<form class="formEmployee" action="">
                <table style="width: 100%; height: 401px;">
                    <tr>
                        <td>
           				    <fieldset class="fieldsetEmployee">
					            <legend>
						            Employee Details
					            </legend>
					            <ol style="height: 30px; width: 100%;">
						            <li style="height: 30px; width: 100%;">
							            <label for="name">
								            Employee ID:
							            </label>
                                        <asp:TextBox ID="TxtEmployee_id" CssClass="text" Enabled="false" runat="server" Width="100px"/>
						            </li>
						            <li style="height: 30px; width: 100%;">
							            <label for="email">
								            First Name:
							            </label>
                                        <asp:TextBox ID="TxtFirstName" CssClass="text" runat="server" Width="200px"/>
						            </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="lastName">
                                            Last Name:
                                        </label>
                                        <asp:TextBox ID="txtLast_name" runat="server" Width="200px"></asp:TextBox>
                                    </li>
                                    <li style="height: 50px; width: 100%;">
                                        <label for="code">
                                            Code:
                                        </label>
                                        <asp:TextBox ID="TextCode" TextMode="MultiLine" runat="server" Height="45px" 
                                            Width="200px"></asp:TextBox>
                                    </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="Position">
                                            Position:
                                        </label>
                                        <asp:DropDownList ID="DropDownPosition" Height="18px" Width="229px" 
                                            runat="server"></asp:DropDownList>
                                    </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="Salary">
                                            Salary:
                                        </label>
                                        <asp:TextBox ID="TxtSalary" runat="server" Width="100px"></asp:TextBox> 
                                    </li>
                                    <li>
                                        <label for="code">
                                            Hired Date:
                                        </label>
                                        <asp:TextBox ID="txtDateHired" runat="server" Width="100px"></asp:TextBox>
                                        <asp:ImageButton ID="ImgCalendar1" runat="server" ImageUrl="~/imagens/Crm/calon.gif" onclick="ImageButton1_Click" />
                                    </li>
					            </ol>
				            </fieldset>
                        </td>
                        <td>
           				    <fieldset class="fieldsetEmployeeB">
					            <legend>
						            User Photo
					            </legend>
					            <ol class="fieldsetEmployeeOl">
						            <li class="fieldsetEmployeeLi">
                                        <asp:Image ID="PicturePhoto" runat="server" ImageUrl="~/imagens/Pictures/Edinei.JPG" Width="233px" Height="181px" 
                                                    BorderStyle="Solid" BorderWidth="2px" style="text-align: center; margin-top: 0px" />
						            </li>
                                    <li class="FieldSetBrowser">
                                        <asp:FileUpload ID="FileUploadPhoto" runat="server" Width="307px" 
                                            Height="46px" />
                                    </li>
                                    <li class="FieldSetBrowser">
                                        <asp:Button ID="UploadPhoto" OnClick="UploadPhoto_Click" Width="90px" Height="23px"  runat="server" Text="Upload" />                                    
                                    </li>
					            </ol>
				            </fieldset>
                        </td>
                    </tr>
                </table>
				<fieldset class="fieldsetEmployeeList">
					<legend>
						Employee List
					</legend>
					<ol class="OlEmployeeList">
						<li class="LIEmployeeList">
                                 <asp:GridView ID="grvEmployee" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="721px" DataKeyNames="agency_id,name"  
                                    OnPageIndexChanging="grvEmployee_PageIndexChanging" 
                                     onselectedindexchanged="grvEmployee_SelectedIndexChanged">
                                      <Columns>
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
                                              DataField="agency_id" HeaderStyle-CssClass="grid_tittle_div" 
                                              HeaderStyle-Width="20%">
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="Name" HeaderStyle-HorizontalAlign="Center" 
                                              DataField="name" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="80%">
                                        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
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
				<fieldset class="fieldsetSubmitEmployeeButtons">
					<asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
    <!-- END #page -->
</body>
<!-- End do Controle -->