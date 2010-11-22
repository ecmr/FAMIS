<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Countries.ascx.cs" Inherits="Countries" %>
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
          width: 821px;
      }
  </style>

  <![endif]-->
</head>
<body>
	<div id="page">
		<div id="header">
			<h1>
				Countries
			</h1>
		</div> <!-- END #header -->
		<div class="contentFilho">
			<form class="formFilho" action="">
				<fieldset class="fieldset">
					<legend>
						Country Details
					</legend>
					<ol>
						<li>
							<label for="name">
								Country ID:
							</label>
                            <asp:TextBox ID="txtCountry_id" CssClass="text" Enabled="false" runat="server"/>
						</li>
						<li>
							<label for="email">
								Country Name:
							</label>
                            <asp:TextBox ID="txtCountryName" CssClass="text" runat="server"/>
						</li>
						<li>
							<label for="email">
								Regions:
							</label>
                            <asp:DropDownList ID="DropDowCountries" Width="350px" runat="server"></asp:DropDownList>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetCountriesList">
					<legend>
						Country List
					</legend>
					<ol>
						<li>
                            <asp:GridView ID="grvCountry" runat="server" AllowPaging="True"  
                                    AutoGenerateColumns="False" CellPadding="4" PageSize="5"  
                                    GridLines="Horizontal" Width="699px" DataKeyNames="country_id,region_id,name"  
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
                                                  DataField="country_id" HeaderStyle-CssClass="grid_tittle_div" 
                                                  HeaderStyle-Width="10%">
                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                          </asp:BoundField>
                                              <asp:BoundField HeaderText="Name" DataField="name"  HeaderStyle-HorizontalAlign="Left" 
                                                  HeaderStyle-CssClass="grid_tittle" 
                                                  HeaderStyle-Width="70%">
                                      <HeaderStyle HorizontalAlign="Left" CssClass="grid_tittle" Width="20%"></HeaderStyle>
                                              </asp:BoundField>
                                          <asp:BoundField HeaderText="Region id" HeaderStyle-HorizontalAlign="Left" 
                                                  DataField="region_id" HeaderStyle-CssClass="grid_tittle" 
                                                  HeaderStyle-Width="10%">
                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                          </asp:BoundField>
                                          </Columns>                                    <pagerstyle backcolor="LightBlue"/>                
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