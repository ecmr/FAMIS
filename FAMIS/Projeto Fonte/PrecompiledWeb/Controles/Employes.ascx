<%@ control language="C#" autoeventwireup="true" inherits="Controles_Employes, App_Web_l0urcdma" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
    <style type="text/css">
        .style1
        {
            height: 232px;
        }
    </style>
</head>
<asp:scriptmanager runat="server"></asp:scriptmanager>
    <div id="MainDiv">
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDiv" >
                <div class="Title">
                    Employes</div>&nbsp;
                <table id="LeadTable" runat="server" width="300px" cellpadding="0" cellspacing="3" style="border-bottom-color: #00008b;" align="center"> 
                  <tr>
                    <td id="formtitulo"><span 
                            class="style3">Employes</span></td>
                  </tr>
                  <tr>
                    <td>
                        <table width="99%" align="right" border="0" cellspacing="3" cellpadding="0" id="formfont">
                        <tr>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>Employee Id</td>
                        </tr>
                        <tr>
                            <td><asp:TextBox ID="txtEmployee_Id" Enabled ="false" runat="server" CssClass="txtbox" Width="120px" /></td>
                            <td rowspan="5"><asp:Image ID="PicturePhoto" runat="server" 
                                    ImageUrl="~/imagens/Pictures/Edinei.JPG" Width="187px" Height="184px" /></td>
                        </tr>
                        <tr>
                            <td>First Name</td>
                        </tr>
                        <tr>
                            <td><asp:TextBox ID="txtFirst_name" runat="server" CssClass="txtbox" Width="120px" /></td>
                        </tr>
                        <tr>
                            <td>Last Name</td>                          
                        </tr>
                        <tr>
                            <td><asp:TextBox ID="txtLast_name" runat="server" CssClass="txtbox" Width="120px" /></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:FileUpload ID="FileUploadPhoto" runat="server" Width="218px" /></td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td><asp:Button ID="UploadPhoto" OnClick="UploadPhoto_Click" Width="90px" 
                                    Height="23px"  runat="server" Text="Upload"  /></td>
                        </tr>
                        <tr>
                            <td>Position</td>
                            <td>Agency</td>
                        </tr>
                        <tr>
                            <td><asp:DropDownList ID="DropDownPosition" Height="22px" Width="100%"  runat="server"></asp:DropDownList></td>
                            <td><asp:DropDownList ID="DropDownAgencies" Height="22px" Width="65%"  runat="server"></asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td>Hired Date</td>
                            <td>Salary</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="txtDateHired" runat="server" CssClass="txtbox" Width="90px" />

                                <asp:ImageButton ID="ImgCalendar1" runat="server" ImageUrl="~/imagens/Crm/calon.gif" onclick="ImageButton1_Click"/>
                                <asp:CalendarExtender ID="CalendarExtender1" PopupButtonID="ImgCalendar1" TargetControlID="txtDateHired" runat="server">
                                </asp:CalendarExtender>
                            </td>
                                <td><asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
                                </tr>
                                <tr><td width="148">Code</td></tr>
                                <tr>
                                    <td colspan="2"><asp:TextBox ID="txtCode0" runat="server" CssClass="txtbox" Height="54px" TextMode="MultiLine" Width="88%" /></td>
                                </tr>
                        </table>
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
                    style="border-bottom-color: #00008b; width: 618px;" align="right"> 
                    <tr>
                        <td align="left">
                            List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left" class="style1">
                            <div id="gridform">
                                 <asp:GridView ID="grvEmployee" runat="server" AllowPaging="True" PageSize="5" 
                                     AutoGenerateColumns="False" CellPadding="4" GridLines="Horizontal" 
                                     Width="600px" DataKeyNames="geospec_id,currency" 
                                     OnPageIndexChanging="grvEmployee_PageIndexChanging" Height="140px">
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
                                      <asp:BoundField HeaderText="ID" HeaderStyle-HorizontalAlign="Left" 
                                              DataField="employee_id" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="20%">
                                        <HeaderStyle HorizontalAlign="Left" Width="10%" />
                                      </asp:BoundField>
                                      <asp:BoundField HeaderText="Last Name" HeaderStyle-HorizontalAlign="Left" 
                                              DataField="last name" HeaderStyle-CssClass="grid_tittle" 
                                              HeaderStyle-Width="80%">
                                        <HeaderStyle HorizontalAlign="Left" Width="30%" />
                                      </asp:BoundField>

                                      <asp:BoundField HeaderText="First Name" HeaderStyle-HorizontalAlign="Left" 
                                              DataField="first_name" HeaderStyle-CssClass="grid_tittle" >
                                        <HeaderStyle HorizontalAlign="Left" Width="30%" />
                                      </asp:BoundField>
                                          
                                      <asp:BoundField HeaderText="Agency" HeaderStyle-HorizontalAlign="Left" 
                                              DataField="Agency_id" HeaderStyle-CssClass="grid_tittle" >
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
