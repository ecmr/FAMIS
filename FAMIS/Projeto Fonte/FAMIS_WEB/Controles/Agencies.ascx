<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Agencies.ascx.cs" Inherits="Agencies" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
    <style type="text/css">
        .style1
        {
            width: 317px;
        }
    </style>
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Agencies<br />
                </div>&nbsp;
                <table id="LeadTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 630px;"> 
                    <tr>
                        <td align="left">
                            Agency ID
                        </td>
                        <td align="left">
                            Agency Name
                        </td>                    
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="TxtAgencyId" Enabled="false" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtAgencyName" runat="server" Width="490px"></asp:TextBox>
                        </td>                    
                    </tr>                    
                    </table> 
                <table id="botoesTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 629px;"   > 
                    <tr>
                        <td align="left">
                            <div id="botoesform" >
                                <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
                            </div>
                        </td>
                    </tr> 
                </table> 
                <table id="GridTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 631px;"> 
                    <tr>
                        <td align="left" class="style1">
                            &nbsp;List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left" class="style1">
                            <div id="gridform">
                                 <asp:GridView ID="grvAgency" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="600px" DataKeyNames="agency_id,name"  
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table> 
            </div>
        </div>
    </div>
<!-- End do Controle -->