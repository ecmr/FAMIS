﻿<%@ control language="C#" autoeventwireup="true" inherits="Controles_Positions, App_Web_l0urcdma" %>
<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Positions</div>&nbsp;
                <table id="LeadTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 763px;"> 
                    <tr>
                        <td align="left" width="300px">
                            Position ID
                        </td>
                        <td align="left">
                            Code
                        </td>                                    
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="txtPosition_id" Enabled="false" runat="server" Width="100px" 
                                style="text-align: left"></asp:TextBox>
                            <br />
                            <br />
                            <br />
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtCode" runat="server" Width="98%" TextMode="MultiLine" 
                                Height="81px" style="margin-left: 0px"></asp:TextBox>                        
                        </td>                        
                    </tr>
                    <tr>
                        <td align="left" width="300px">
                            Department
                        </td>                    
                        <td align="left">
                            Name
                        </td>
                    </tr>
                    <tr>
                        <td align="left" width="300px">
                            <asp:DropDownList ID="DropDownDepartment" Width="92%" runat="server" 
                                Height="24px"></asp:DropDownList>
                            <br />
                            <br />
                            <br />
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtName" Width="98%" TextMode="MultiLine" runat="server" 
                                Height="81px" style="margin-left: 0px"></asp:TextBox>
                        </td>                         
                    </tr>                    
                    <tr>
                        <td align="left">
                            Salary
                        </td>                    
                    </tr>
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="TxtSalaray" runat="server"></asp:TextBox>
                        </td> 
                    </tr>                                        
                </table> 
                <table id="botoesTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 766px;"   > 
                    <tr>
                        <td align="left">
                            <div id="botoesform" >
                                <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
                            </div>
                        </td>
                    </tr> 
                </table>
                <table id="GridTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 767px;"> 
                    <tr>
                        <td align="left">
                            &nbsp;List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left">
                            <div id="gridform">
                                 <asp:GridView ID="grvPosition" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="600px" DataKeyNames="position_id,name"  
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table> 
            </div>
        </div>
    </div>
<!-- End do Controle -->