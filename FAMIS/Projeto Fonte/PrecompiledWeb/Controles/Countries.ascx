<%@ control language="C#" autoeventwireup="true" inherits="Countries, App_Web_l0urcdma" %>
<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Countries</div>&nbsp;
                <table id="LeadTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;"> 
                    <tr>
                        <td align="left">
                            Country ID
                        </td>
                        <td align="left">
                            Regions
                        </td>                    
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="txtCountry_id" Enabled="false" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:DropDownList ID="DropDowCountries" Width="350px" runat="server"></asp:DropDownList>
                        </td>                    
                    </tr>  
                    <tr>
                        <td align="left">
                            Country Name
                        </td>
                        <td></td>
                    </tr> 
                    <tr>
                        <td align="left" colspan="2">
                            <asp:TextBox ID="txtCountryName" runat="server" Width="514px"></asp:TextBox>
                        </td>
                    </tr>                                        
                </table> 
                <table id="botoesTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;"   > 
                    <tr>
                        <td align="left">
                            <div id="botoesform" >
                                <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
                            </div>
                        </td>
                    </tr> 
                </table> 
                <table id="GridTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;"> 
                    <tr>
                        <td align="left">
                            &nbsp;List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left">
                            <div id="gridform">
                                 <asp:GridView ID="grvCountry" runat="server" AllowPaging="True"  
                                    AutoGenerateColumns="False" CellPadding="4" PageSize="5"  
                                    GridLines="Horizontal" Width="600px" DataKeyNames="country_id,region_id,name"  
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table> 
            </div>
        </div>
    </div>
<!-- End do Controle -->
