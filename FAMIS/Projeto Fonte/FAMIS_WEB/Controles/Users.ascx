<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Users.ascx.cs" Inherits="Controles_Users" %>
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
<div class="pageUser" >
		<div class="headerUser">
			<h1>
				Users
			</h1>
		</div> <!-- END #header -->
		<div class="contentUser">
			<form class="formUser" action="">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                <ContentTemplate>
				<fieldset class="fieldsetUser">
					<legend class="legendUser">
						User Details
					</legend>
					<ol style="height: 124px; width: 100%" >
						<li style="height: 30px; width: 100%">
							<label for="name">
								User ID:
							</label>
                            <asp:TextBox ID="txtUser_id" CssClass="text" Enabled="false" runat="server"/>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								First Name:
							</label>
                            <asp:TextBox ID="txtFirstName" CssClass="text" runat="server"/>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								Last Name:
							</label>
                            <asp:TextBox ID="TxtLastName" CssClass="text" runat="server"/>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								E-Mail:
							</label>
                            <asp:TextBox ID="TxtEmail" CssClass="text" runat="server"/>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								Active:
							</label>
                            <asp:DropDownList ID="DropDownActive" runat="server"><asp:ListItem Value="1">True</asp:ListItem><asp:ListItem Value="0">False</asp:ListItem></asp:DropDownList>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								User Name:
							</label>
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
						</li>
						<li style="height: 30px; width: 100%">
							<label for="email">
								Password:
							</label>
                            <asp:TextBox ID="TxtPassword" TextMode="SingleLine" runat="server"></asp:TextBox>
						</li>
					</ol>
				</fieldset>
                </ContentTemplate>
            </asp:UpdatePanel>
				<fieldset class="fieldsetUsercList">
					<legend>
						Users List
					</legend>
					<ol class="OlUserList">
						<li class="LIUserList">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <asp:GridView ID="grvUser" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="715px" DataKeyNames="user_id,first_name,last_name"  
                                        OnPageIndexChanging="grvUser_PageIndexChanging">
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
                                              DataField="user_id" HeaderStyle-CssClass="grid_tittle_div" 
                                              HeaderStyle-Width="20%">
                                        <HeaderStyle HorizontalAlign="Left" Width="10%"></HeaderStyle>
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="First Name" HeaderStyle-HorizontalAlign="Center" 
                                              DataField="first_name" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="80%">
                                        <HeaderStyle HorizontalAlign="Left" Width="40%"></HeaderStyle>
                                      </asp:BoundField>
                                          <asp:BoundField HeaderText="Last Name" DataField="last_name">
                                              <HeaderStyle Width="50%" />
                                          </asp:BoundField>
                                      </Columns>
                                    <pagerstyle backcolor="LightBlue"/>                
                                    <FooterStyle />
                                    <RowStyle CssClass="grid_line_01" />
                                    <HeaderStyle />
                                    <AlternatingRowStyle CssClass="grid_line_02" />
                                </asp:GridView>
                                </ContentTemplate>

                            </asp:UpdatePanel>
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetSubmitUserButtons" >
					<asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
</body>   