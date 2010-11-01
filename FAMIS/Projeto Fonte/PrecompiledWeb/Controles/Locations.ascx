<%@ control language="C#" autoeventwireup="true" inherits="Controles_Locations, App_Web_l0urcdma" %>
<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Locations</div>&nbsp;
                <table id="LeadTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;" align="center"> 
                    <tr>
                        <td width="100px" align="left">
                            Location ID
                        </td>
                        <td width="200px" align="left">
                            Address
                        </td>  
                        <td align="left">
                            Number
                        </td>                                          
                    </tr> 
                    <tr>

                        <td align="left">
                            <asp:TextBox ID="txtLocation_id" Enabled="false" runat="server" Width="123px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtAddress" runat="server" Width="265px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtNumber" runat="server" Width="191px"></asp:TextBox>
                        </td>                                                                    
                    </tr>
                    <tr>
                        <td align="left">
                            City</td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td align="left" colspan="3" >
                            <asp:TextBox ID="TxtCity" runat="server" Width="589px"></asp:TextBox>
                        </td>
                    </tr>
<!--***********************************-->
                    <tr>
                      <td colspan="3">
                          Region
                      </td>
                    </tr>
                    <tr>
                      <td colspan="3">
                          <asp:DropDownList ID="DropDownRegion" Width="589px" runat="server" Height="22px"></asp:DropDownList>
                      </td>
                    </tr>
                    <tr>
                      <td colspan="3">
                          Country
                      </td>
                    </tr>
                    <tr>
                      <td colspan="3">
                          <asp:DropDownList ID="DropDownCountry" Width="589px" runat="server" Height="22px"></asp:DropDownList>
                      </td>
                    </tr>  
                    <tr>
                      <td colspan="3">
                          Agency
                      </td>
                    </tr>
                    <tr>
                      <td colspan="3">
                          <asp:DropDownList ID="DropDownAgency" Width="589px" runat="server" Height="22px"></asp:DropDownList>
                      </td>
                    </tr>                                                           
                </table>
                <table id="botoesTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 598px;" align="center"> 
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
                    style="border-bottom-color: #00008b; width: 599px;" align="center"> 
                    <tr>
                        <td align="left">
                            &nbsp;List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left">
                            <div id="gridform">
                                 <asp:GridView ID="grvLocation" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="581px" DataKeyNames="location_id,city"  
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table>                
            </div>
        </div>    
    </div>  