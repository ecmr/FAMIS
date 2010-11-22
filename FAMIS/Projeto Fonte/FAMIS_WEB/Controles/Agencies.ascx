<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Agencies.ascx.cs" Inherits="Agencies" %>
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
</head>
<body>
	<div class="pageAgencie" >
		<div class="headerAgencie">
			<h1>
				Agencies
			</h1>
		</div> <!-- END #header -->
		<div class="contentAgencie">
			<form class="formAgencie" action="">
				<fieldset class="fieldsetAgencie">
					<legend class="legendAgencie">
						Agency Details
					</legend>
					<ol style="height: 78px; width: 100%" >
						<li style="height: 30px; width: 100%">
							<label for="name">
								Agency ID:
							</label>
                            <asp:TextBox ID="TxtAgencyId" CssClass="text" Enabled="false" runat="server"/>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								Agency Name:
							</label>
                            <asp:TextBox ID="TxtAgencyName" CssClass="text" runat="server"/>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetAgencieList">
					<legend>
						Agencies List
					</legend>
					<ol>
						<li>
                                <asp:GridView ID="grvAgency" runat="server" AllowPaging="True" PageSize="5" 
                                AutoGenerateColumns="False" CellPadding="4" 
                                GridLines="Horizontal" Width="705px" DataKeyNames="agency_id,name"  
                                OnPageIndexChanging="grvAgency_PageIndexChanging">
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