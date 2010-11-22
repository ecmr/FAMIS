<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Locations.ascx.cs" Inherits="Controles_Locations" %>
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
	<div class="pageLocation" >
		<div class="headerLocation">
			<h1>
				Locations
			</h1>
		</div> <!-- END #header -->
		<div class="contentLocation">
			<form class="formLocation" action="">
				<fieldset class="fieldsetLocation">
					<legend class="legendLocation">
						Location Details
					</legend>
					<ol class="OlLocation" >
						<li class="LILocation">
							<label for="name">
								Location ID:
							</label>
                            <asp:TextBox ID="txtLocation_id" Enabled="false" runat="server" Width="123px"></asp:TextBox>
						</li>
						<li class="LILocation">
							<label for="email">
								Address:
							</label>
                            <asp:TextBox ID="txtAddress" runat="server" Width="265px"></asp:TextBox>
						</li>
						<li class="LILocation">
							<label for="email">
								Number:
							</label>
                            <asp:TextBox ID="TxtNumber" runat="server" Width="265px"></asp:TextBox>
						</li>
						<li class="LILocation">
							<label for="email">
								City:
							</label>
                            <asp:TextBox ID="TxtCity" runat="server" Width="265px"></asp:TextBox>
						</li>
                        
						<li class="LILocation">
							<label for="Agency">
								Region:
							</label>
                            <asp:DropDownList ID="DropDownRegion" Width="390px" AutoPostBack="true" runat="server" Height="22px" onselectedindexchanged="DropDownRegion_SelectedIndexChanged"></asp:DropDownList>
						</li>
						<li class="LILocation">
							<label for="Agency">
								Country:
							</label>
                            <asp:DropDownList ID="DropDownCountry" Width="390px" AutoPostBack="true" runat="server" Height="22px" onselectedindexchanged="DropDownCountry_SelectedIndexChanged"></asp:DropDownList>
						</li>
						<li class="LILocation">
							<label for="Agency">
								Agency:
							</label>
                            <asp:DropDownList ID="DropDownAgency" Width="390px" runat="server" Height="22px"></asp:DropDownList>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetLocationcList">
					<legend>
						Agencies List
					</legend>
					<ol class="OlLocationList">
						<li class="LILocationList">
                            <asp:GridView ID="grvLocation" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="710px" DataKeyNames="location_id,city"  
                    OnPageIndexChanging="grvLocation_PageIndexChanging">
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
                                              DataField="location_id" HeaderStyle-CssClass="grid_tittle_div" 
                                              HeaderStyle-Width="20%">
                                        <HeaderStyle HorizontalAlign="Left" Width="10%"></HeaderStyle>
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="City" HeaderStyle-HorizontalAlign="Center" 
                                              DataField="city" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="80%">
                                        <HeaderStyle HorizontalAlign="Left" Width="40%"></HeaderStyle>
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