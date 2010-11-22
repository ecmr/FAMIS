<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Clients.ascx.cs" Inherits="Clients" %>
<!-- Begin do Controle -->
<head>
  <title></title>
  <meta http-equiv="content-type" content="text/html; charset=utf-8" />
  <style type="text/css" media="all">
  	@import "../Css/Css.css";
  	@import "../Css/fieldset-background-image_Clients.css";
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
	<div class="pageClients">
		<div class="headerAgencie">
			<h1>
				Clientes
			</h1>
		</div> <!-- END #header -->
		<div class="contentClients">
			<form class="formClients" action="">
				<fieldset class="fieldsetClients">
					<legend>
						Client Details
					</legend>
					<ol style="width:100%;">
						<li  style="width:100%;">
							<label for="name">
								Client ID:
							</label>
                            <asp:TextBox ID="txtClient_id" CssClass="text" Enabled="false" runat="server"/>
						</li>
						<li  style="width:100%;">
							<label for="email">
								Local Name:
							</label>
                            <asp:TextBox ID="txtLocalName" CssClass="text" runat="server"/>
						</li>
						<li  style="width:100%;">
							<label for="email">
								Intl Name:
							</label>
                            <asp:TextBox ID="txtIntlName" CssClass="text" runat="server"/>
						</li>
						<li  style="width:100%;">
							<label for="Code">
								Code:
							</label>
                            <asp:TextBox ID="TxtCode" CssClass="text" runat="server"/>
						</li>
                        <li  style="width:100%;">
                            <fieldset class="fieldsetClientsActive">
                                <legend>Active</legend>
                                <ol  style="width:100%;height:110px;">
                                    <li  style="width:100%;">
                                        <asp:RadioButton ID="RadioActiveTrue" Text="True" GroupName="Active" runat="server"></asp:RadioButton>
                                    </li>
                                    <li style="width:100%;">
                                        <asp:RadioButton ID="RadioActiveFalse" Text="False" GroupName="Active" runat="server"></asp:RadioButton>
                                    </li>
                                </ol>
                            </fieldset>
                            <fieldset class="fieldsetClientsMulti">
                                <legend>Multinational</legend>
                                <ol style="width:100%;">
                                    <li  style="width:100%;">
                                        <asp:RadioButton ID="RadioMultiTrue" Text="True" GroupName="Mult" runat="server"></asp:RadioButton>
                                    </li>
                                    <li style="width:100%;">
                                        <asp:RadioButton ID="RadioMultiFalse" Text="False" GroupName="Mult" runat="server"></asp:RadioButton>
                                    </li>
                                </ol>
                            </fieldset>
		                </li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetClientsList">
					<legend>
						Client List
					</legend>
					<ol  style="width:100%; height:27%;">
						<li  style="width:100%; height:90%;">
                            <asp:GridView ID="grvClient" runat="server" AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                                    CellPadding="4" GridLines="Horizontal" Width="98%" DataKeyNames="client_id,local_name,active"
                                    OnPageIndexChanging="grvClient_PageIndexChanging">
                                    <Columns>
                                        <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Imagens/Icones/editar.gif"
                                                    ToolTip="Editar" OnClick="btnEditar_Click" />
                                            </ItemTemplate>
                                            <HeaderStyle CssClass="grid_tittle"></HeaderStyle>
                                            <ItemStyle Width="2%"></ItemStyle>
                                        </asp:TemplateField>
                                        <asp:TemplateField ItemStyle-Width="25px" ItemStyle-HorizontalAlign="Center" HeaderStyle-CssClass="grid_tittle_div">
                                            <HeaderStyle CssClass="grid_tittle_div"></HeaderStyle>
                                            <ItemStyle Width="2%"></ItemStyle>
                                        </asp:TemplateField>
                                        <asp:BoundField HeaderText="ID" HeaderStyle-HorizontalAlign="Center" DataField="client_id"
                                            HeaderStyle-CssClass="grid_tittle_div" HeaderStyle-Width="20%">
                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        </asp:BoundField>
                                        <asp:BoundField HeaderText="Local Name" HeaderStyle-HorizontalAlign="Center" DataField="local_name"
                                            HeaderStyle-CssClass="grid_tittle" HeaderStyle-Width="60%">
                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        </asp:BoundField>
                                        <asp:BoundField HeaderText="Active" HeaderStyle-HorizontalAlign="Center" DataField="active"
                                            HeaderStyle-CssClass="grid_tittle" HeaderStyle-Width="10%">
                                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                                        </asp:BoundField>
                                    </Columns>
                                    <PagerStyle BackColor="LightBlue" />
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