<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Geospecs.ascx.cs" Inherits="Controles_Geospecs" %>
<!-- Begin do Controle -->
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Geospecs</div>&nbsp;
                <table id="LeadTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;" align="center"> 
                    <tr>
                        <td align="left">
                            Geospec ID
                        </td>
                        <td align="left">
                            Currency
                        </td> 
                        <td align="left">
                            Decimal Symbol
                        </td>
                        <td align="left">
                            Date Format
                        </td>                                                 
                    </tr> 
                    <tr>
                        <td align="left" width="120px">
                            <asp:TextBox ID="txtGeospec_id" Enabled="false" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtCurrency" runat="server" MaxLength="10"  Width="125px"></asp:TextBox>
                        </td>                    
                        <td align="left" width="120px">
                            <asp:TextBox ID="txtDecimalSymbol" runat="server" Width="157px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtDateFormat" runat="server" Width="143px"></asp:TextBox>
                        </td>           
                    </tr>
                    <tr>
                        <td colspan="2" align="left">
                            Region
                        </td>
                        <td colspan="2" align="left">
                            Country
                        </td>                        
                    </tr>
                    <tr>
                        <td colspan="2" align="left">
                            <asp:DropDownList ID="DropRegion" runat="server" Height="22px" Width="300px" AutoPostBack="true" onselectedindexchanged="DropRegion_SelectedIndexChanged"></asp:DropDownList>
                        </td>                    
                        <td colspan="2" align="left">
                            <asp:DropDownList ID="DropCountry" runat="server" Height="22px" Width="300px"></asp:DropDownList>
                        </td>                                            
                    </tr>
                </table> 
                <table id="botoesTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 614px;" align="center"> 
                    <tr>
                        <td align="left">
                            <div id="botoesform" >
                                <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
                            </div>
                        </td>
                    </tr> 
                </table>                 
                <table id="GridTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 612px;" align="center"> 
                    <tr>
                        <td align="left">
                            List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left">
                            <div id="gridform">
                                 <asp:GridView ID="grvGeospec" runat="server" AllowPaging="True" PageSize="5" AutoGenerateColumns="False" CellPadding="4" GridLines="Horizontal" Width="600px" DataKeyNames="geospec_id,currency" OnPageIndexChanging="grvGeospec_PageIndexChanging">
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table> 
            </div>
        </div>
    </div>
<!-- End do Controle -->


