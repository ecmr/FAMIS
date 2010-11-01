<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Clients.ascx.cs" Inherits="Clients" %>
<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
</head>

    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Clients</div>&nbsp;
                <table id="LeadTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;"> 
                    <tr>
                        <td align="left">
                            Client ID
                        </td>
                        <td align="left">
                            Local Name
                        </td>                    
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="txtClient_id" Enabled="false" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="txtLocalName" runat="server" Width="490px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="left">
                            Intl Name
                        </td>
                        <td align="left">
                            Code
                        </td>                    
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:TextBox ID="txtIntlName" runat="server" Width="100px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <asp:TextBox ID="TxtCode" runat="server" Width="190px"></asp:TextBox>
                        </td>
                    </tr>  
                    <tr>
                        <td align="left">
                            Active
                        </td>
                        <td align="left">
                            Multinational
                        </td>                    
                    </tr> 
                    <tr>
                        <td align="left">
                            <asp:RadioButton ID="RadioActiveTrue" Text="true" GroupName="Active" runat="server"></asp:RadioButton>
                            <asp:RadioButton ID="RadioActiveFalse" Text="false" GroupName="Active" runat="server"></asp:RadioButton>
                        </td>
                        <td align="left">
                            <asp:RadioButton ID="RadioMultiTrue" Text="true" GroupName="Mult" runat="server"></asp:RadioButton>
                            <asp:RadioButton ID="RadioMultiFalse" Text="false" GroupName="Mult" runat="server"></asp:RadioButton>
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
                                <asp:GridView ID="grvClient" runat="server" AllowPaging="True" PageSize="5" AutoGenerateColumns="False"
                                    CellPadding="4" GridLines="Horizontal" Width="100%" DataKeyNames="client_id,local_name,active"
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
                            </div>
                            &nbsp;
                        </td>
                    </tr>  
                </table> 
            </div>
        </div>
    </div>
<!-- End do Controle -->
