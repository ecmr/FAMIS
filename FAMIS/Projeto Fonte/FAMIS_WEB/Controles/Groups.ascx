<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Groups.ascx.cs" Inherits="Controles_Groups" %>
<!-- Begin do Controle -->
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
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
	<div class="pageGroup" >
		<div class="headerGroup">
			<h1>
				Groups
			</h1>
		</div> <!-- END #header -->
		<div class="contentGroup">
			<form class="formGroup" action="">
				<fieldset class="fieldsetGroup">
					<legend class="legendGroup">
						Group Details
					</legend>
					<ol class="OlGroup" >
						<li class="LIGroup">
							<label for="name">
								Group ID:
							</label>
                            <asp:TextBox ID="txtGroup_id" Enabled="false" runat="server" Width="100px"></asp:TextBox>
						</li>
						<li class="LIGroup">
							<label for="email">
								Group Name:
							</label>
                            <asp:TextBox ID="txtName" runat="server" Width="322px"></asp:TextBox>
						</li>
						<li class="LIGroup">
							<label for="Agency">
								Agency:
							</label>
                            <asp:DropDownList ID="DropDownAgency" runat="server" Height="22px" Width="322px"></asp:DropDownList>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetGroupcList">
					<legend>
						Agencies List
					</legend>
					<ol class="OlGroupList">
						<li class="LIGroupList">
                            <asp:GridView ID="grvGroups" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="710px" DataKeyNames="group_id,name" OnPageIndexChanging="grvGroup_PageIndexChanging">
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
				<fieldset class="fieldsetSubmitAgencieButtons" >
					<asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
</body>
<!-- End do Controle -->