<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Positions.ascx.cs" Inherits="Controles_Positions" %>
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
	<div class="pagePosition" >
		<div class="headerPosition">
			<h1>
				Positions
			</h1>
		</div> <!-- END #header -->
		<div class="contentPosition">
			<form class="formPosition" action="">
				<fieldset class="fieldsetPosition">
					<legend class="legendPosition">
						Position Details
					</legend>
					<ol class="OlPosition" >
						<li class="LIPosition">
							<label for="PositionId">
								Position ID:
							</label>
                            <asp:TextBox ID="txtPosition_id" Enabled="false" runat="server" Width="100px" style="text-align: left"></asp:TextBox>
						</li>
						<li style="height: 55px; width:100%;" >
							<label for="email">
								Name:
							</label>
                            <asp:TextBox ID="TxtName" Width="290px" TextMode="MultiLine" runat="server" Height="49px" style="margin-left: 0px"></asp:TextBox>
						</li>
						<li style="height: 55px; width:100%;" >
							<label for="code">
								Code:
							</label>
                            <asp:TextBox ID="TxtCode" runat="server" Width="290px" TextMode="MultiLine" Height="53px" style="margin-left: 0px"></asp:TextBox> 
						</li>
						<li class="LIPosition">
							<label for="email">
								Department:
							</label>
                            <asp:DropDownList ID="DropDownDepartment" Width="290px" runat="server" Height="24px"></asp:DropDownList>
						</li>
						<li class="LIPosition">
							<label for="email">
								Salary:
							</label>
                            <asp:TextBox ID="TxtSalaray" runat="server"></asp:TextBox>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetPositioncList">
					<legend>
						Positions List
					</legend>
					<ol class="OlPositioncList">
						<li class="LIPositioncList">
                            <asp:GridView ID="grvPosition" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="711px" DataKeyNames="position_id,name" 
                                OnPageIndexChanging="grvPosition_PageIndexChanging">
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
                                              DataField="position_id" HeaderStyle-CssClass="grid_tittle_div" 
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