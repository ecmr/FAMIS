<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Users.ascx.cs" Inherits="Controles_Users" %>

<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Users</div>&nbsp;
                <table id="LeadTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;" align="center"> 
                    <tr>
                        <td align="left">
                            User ID
                        </td>
                        <td align="left">
                            First Name
                        </td>  
                        <td align="left">
                            Last Name
                        </td>                                          
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="txtUser_id" Enabled="false" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtFirstName" runat="server" Width="286px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtLastName" runat="server" Width="286px"></asp:TextBox>
                        </td>                                            
                    </tr>
                    <tr>
                        <td align="left">
                            E-Mail
                        </td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td align="left" colspan="3" >
                            <asp:TextBox ID="TxtEmail" runat="server" Width="486px"></asp:TextBox>
                        </td>
                    </tr>
<!--***********************************-->
                    <tr>
                      <td colspan="3">
                          Active
                          <asp:DropDownList ID="DropDownActive" runat="server">
                              <asp:ListItem Value="1">True</asp:ListItem>
                              <asp:ListItem Value="0">False</asp:ListItem>
                          </asp:DropDownList>
                          &nbsp;
                      </td>
                    </tr>
                    <tr>
                        <td width="25%">User Name</td>
                        <td width="25%">Password</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:TextBox ID="TxtPassword" TextMode="SingleLine" runat="server"></asp:TextBox>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
<!--***********************************-->                                                            
                </table>
                <table id="botoesTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 716px;" align="center"> 
                    <tr>
                        <td align="left">
                            <div id="botoesform" >
                                <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
                                <br />
                            </div>
                        </td>
                    </tr> 
                </table>
                <table id="GridTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 718px;" align="center"> 
                    <tr>
                        <td align="left">
                            &nbsp;List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left">
                            <div id="gridform">
                                 <asp:GridView ID="grvUser" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="600px" DataKeyNames="user_id,first_name,last_name"  
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table>                
            </div>
        </div>    
    </div>    