<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Departments.ascx.cs" Inherits="Departments" %>
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
</head>
<body>
	<div id="page">
		<div id="header">
			<h1>
				Departments
			</h1>
		</div> <!-- END #header -->
		<div class="contentFilho">
			<form class="formFilho" action="">
				<fieldset class="fieldset">
					<legend>
						Department Details
					</legend>
					<ol class="OlDepartment">
						<li class="LIOlDepartment">
							<label for="name">
								Department ID:
							</label>
                            <asp:TextBox ID="txtDepartment_id" CssClass="text" Enabled="false" runat="server"/>
						</li>
						<li class="LIOlDepartment">
							<label for="email">
								Department Name:
							</label>
                            <asp:TextBox ID="txtDepartmentName" CssClass="text" runat="server"/>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetDepartmentsList">
					<legend>
						Departments List
					</legend>
					<ol>
						<li>
                            <asp:GridView ID="grvDepartment" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="699px" DataKeyNames="department_id,name"  
                    OnPageIndexChanging="grvClient_PageIndexChanging">
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
                                            OnClick="btnExcluir_Click"  />
                                    </ItemTemplate>
                                    <HeaderStyle CssClass="grid_tittle_div"></HeaderStyle>
                                    <ItemStyle Width="2%"></ItemStyle>
                                  </asp:TemplateField>
                                  <asp:BoundField HeaderText="ID" HeaderStyle-HorizontalAlign="Center" 
                                          DataField="department_id" HeaderStyle-CssClass="grid_tittle_div" 
                                          HeaderStyle-Width="20%">
                                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                  </asp:BoundField>
                                      <asp:BoundField HeaderText="Name" DataField="name"  HeaderStyle-HorizontalAlign="Left" 
                                          HeaderStyle-CssClass="grid_tittle" 
                                          HeaderStyle-Width="20%">
            <HeaderStyle HorizontalAlign="Left" CssClass="grid_tittle" Width="20%"></HeaderStyle>
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
				<fieldset class="fieldsetSubmit" >
					<asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
</body>
<!-- End do Controle -->