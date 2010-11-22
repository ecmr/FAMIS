<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Geospecs.ascx.cs" Inherits="Controles_Geospecs" %>
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
          width: 821px;
      }
  </style>

  <![endif]-->
</head>
<body>
	<div class="pageGeospec" >
		<div class="headerGeospec">
			<h1>
				Geospec
			</h1>
		</div> <!-- END #header -->
		<div class="contentGeospec">
			<form class="formGeospec" action="">
				<fieldset class="fieldsetGeospec">
					<legend>
						Geospec Details
					</legend>
					<ol class="OlGeospec">
						<li class="LIGeospec">
							<label for="GeospecId">
								Geospec ID:
							</label>
                            <asp:TextBox ID="txtGeospec_id" Enabled="false" runat="server" Width="100px" />
						</li>
						<li class="LIGeospec">
							<label for="Currency">
								Currency:
							</label>
                            <asp:TextBox ID="txtCurrency" runat="server" MaxLength="10"  Width="125px" />
						</li>
						<li class="LIGeospec">
							<label for="DecSymbol">
								Decimal Symbol:
							</label>
                            <asp:TextBox ID="txtDecimalSymbol" runat="server" Width="157px" />
						</li>
                        <li class="LIGeospec">
                            <label for="DateFormat">
                                Date Format
                            </label>
                            <asp:TextBox ID="txtDateFormat" runat="server" Width="143px" />
                        </li>
                        <li class="LIGeospec">
                            <label for="Region">
                                Region
                            </label>
                            <asp:DropDownList ID="DropRegion" runat="server" Height="22px" Width="300px" AutoPostBack="true" onselectedindexchanged="DropRegion_SelectedIndexChanged" />
                        </li>
                        <li class="LIGeospec">
                            <label for="">
                                Country
                            </label>
                            <asp:DropDownList ID="DropCountry" runat="server" Height="22px" Width="300px" />
                        </li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetGeospecList">
					<legend>
						Geospec List
					</legend>
					<ol class="OlGeospecList">
						<li class="LIGeospecList">
                            <asp:GridView ID="grvGeospec" runat="server" AllowPaging="True" PageSize="5" 
                                                                 AutoGenerateColumns="False" 
                                CellPadding="4" GridLines="Horizontal" 
                                                                 Width="711px" DataKeyNames="geospec_id,currency" 
                                                                 
                                OnPageIndexChanging="grvGeospec_PageIndexChanging">
                                      <Columns>
                                      <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle" >
                                        <ItemTemplate>
                                          <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Imagens/Icones/editar.gif" ToolTip="Editar" OnClick="btnEditar_Click" />
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="grid_tittle"></HeaderStyle>
                                        <ItemStyle Width="2%"></ItemStyle>
                                      </asp:TemplateField>
                                      <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle_div">
                                        <ItemTemplate>
                                          <asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/Imagens/Icones/excluir.gif" ToolTip="Excluir" OnClick="btnExcluir_Click" />
                                        </ItemTemplate>
                                        <HeaderStyle CssClass="grid_tittle_div"></HeaderStyle>
                                        <ItemStyle Width="2%"></ItemStyle>
                                      </asp:TemplateField>
                                      <asp:BoundField HeaderText="ID" HeaderStyle-HorizontalAlign="Left" DataField="geospec_id" HeaderStyle-CssClass="grid_tittle" HeaderStyle-Width="20%">
                                        <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="Currency" HeaderStyle-HorizontalAlign="Left" DataField="currency" HeaderStyle-CssClass="grid_tittle" HeaderStyle-Width="80%">
                                        <HeaderStyle HorizontalAlign="Left" Width="30%" />
                                      </asp:BoundField>

                                      <asp:BoundField HeaderText="Region id" HeaderStyle-HorizontalAlign="Left" DataField="region_id" HeaderStyle-CssClass="grid_tittle" >
                                        <HeaderStyle HorizontalAlign="Left" Width="30%" />
                                      </asp:BoundField>
                                          
                                      <asp:BoundField HeaderText="Country id" HeaderStyle-HorizontalAlign="Left" DataField="country_id" HeaderStyle-CssClass="grid_tittle" >
                                          <HeaderStyle HorizontalAlign="Left" Width="30%" />
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
				<fieldset class="fieldsetSubmitGeospecButtons" >
					<asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
</body>
<!-- End do Controle -->


