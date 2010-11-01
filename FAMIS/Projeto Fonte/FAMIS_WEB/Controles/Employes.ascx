<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Employes.ascx.cs" Inherits="Controles_Employes"  %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<!-- Begin do Controle -->
<head><title></title>
    <link rel="Stylesheet" type="text/css" href="../Css/Controles.css" />
    <style type="text/css">
        .style2
        {
            width: 307px;
            height: 22px;
        }
        .style4
        {
            height: 22px;
        }
        .style5
        {            height: 44px;
        }
        .style7
        {
            height: 34px;
        }
        .style8
        {
        }
        .style10
        {
            width: 908px;
        }
        #gridformEmp {
	        margin:0 auto;
	        width:100%;
	        height:294px;
	        float:left;
        }
        DIV.ContentDivEmp
        { /*** Layout do Tamanho ***/
            height: 98%;
            width: 1018px;
            text-align:left;
            border: 1px solid #00008b; /* #6893CF;*/
            background-color: #F3F8FF;
            overflow: auto;
        }
        Div.DivEmpXX
        {
            margin: 5px;
            padding: 5px;
            border: 1px solid #6893CF;
            background-color: #eaf3ff;
            display: table;
            text-align: center;
	        height: 99%;
        }                        
        .style11
        {
            width: 908px;
            height: 33px;
        }
    </style>
</head>

    <div id="MainDivXX" class="DivEmpXX" >
        <div>
            &nbsp;
            <div id="LeadDiv" class="ContentDivEmp" >
                <div class="Title">
                    Employes<br />
                </div>&nbsp;
                <table id="LeadTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; width: 917px;" border="2"> 
                    <tr>
                        <td align="left" colspan="4" class="style7">
                            </td>
                    </tr> 
                    <tr>
                        <td align="left" class="style4" >
                            Employee ID
                        </td>
                        <td align="left" class="style2" >
                            <asp:TextBox ID="TxtEmployee_id" Enabled="false" runat="server"  Width="100px"></asp:TextBox> 
                        </td>
                        <td align="left" rowspan="4" bgcolor="Black" class="style8" colspan="2">
                            <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                            <asp:Image ID="PicturePhoto" runat="server" 
                                ImageUrl="~/imagens/Pictures/Edinei.JPG" Width="233px" Height="181px" 
                                BorderStyle="Solid" BorderWidth="2px" 
                                style="text-align: center; margin-top: 0px" />
                        </td>
                    </tr>  
                    <tr>
                        <td align="left" class="style4" >
                            First Name </td>
                        <td align="left" class="style2" >
                            <asp:TextBox ID="TxtFirstName" runat="server"  Width="300px"></asp:TextBox> 
                        </td>
                    </tr> 
                    <tr>
                        <td align="left" class="style4"  >
                            Last Name</td>
                        <td align="left" class="style2"  >
                            <asp:TextBox ID="txtLast_name" runat="server" Width="300px"></asp:TextBox>    
                        </td>
                    </tr>                      
                    <tr>
                        <td align="left" class="style4"  >
                            Code</td>
                        <td align="left" class="style2"  >
                            <asp:TextBox ID="TextCode" TextMode="MultiLine" runat="server" Height="37px" 
                                Width="300px"></asp:TextBox> 
                        </td>
                    </tr>                      
                    <tr>
                        <td align="left" class="style4"  >
                            Position
                        </td>
                        <td align="left" class="style2"  >
                            <asp:DropDownList ID="DropDownPosition" Height="22px" Width="300px"  runat="server"></asp:DropDownList>
                        </td>
                        <td align="left" class="style8" colspan="2">
                            <asp:FileUpload ID="FileUploadPhoto" runat="server" Width="218px" />
                        </td>
                    </tr>                    
                    <tr>
                        <td align="left" class="style4"  >
                            Agency
                        </td>
                        <td align="left" class="style2"  >
                            <asp:DropDownList ID="DropDownAgency" Height="22px" Width="300px"  runat="server"></asp:DropDownList>
                        </td>
                        <td align="left" class="style8" colspan="2">
                            <asp:Button ID="UploadPhoto" OnClick="UploadPhoto_Click" Width="90px" Height="23px"  runat="server" Text="Upload" />
                        </td>
                    </tr>                    
                    <tr>
                        <td align="left" class="style4"  >
                            Salary
                            </td>
                        <td align="left" class="style2"  >
                            <asp:TextBox ID="TxtSalary" runat="server" Width="100px"></asp:TextBox> 
                        </td>
                        <td align="left">
                            
                            Hired Date</td>

                        <td align="left">
                            
                            <asp:TextBox ID="txtDateHired" runat="server" Width="90px"></asp:TextBox>
                            <asp:ImageButton ID="ImgCalendar1" runat="server" ImageUrl="~/imagens/Crm/calon.gif" onclick="ImageButton1_Click" />
                            
                        </td>

                    </tr>                    
                    <tr>
                        <td align="left" class="style5" colspan="4"  >
                            <div id="botoesform">
                                <asp:LinkButton ID="lkbSalvar" runat="server" BorderColor="ActiveBorder" 
                                    onclick="lkbSalvar_Click"><asp:Image ID="btnSalvar" runat="server" 
                                    ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" 
                                    ToolTip="Salvar" />Save</asp:LinkButton>
                            </div>
                            </td>
                    </tr>                    
                    </table>
                <table id="GridTable" runat="server" cellpadding="0" cellspacing="3" 
                    style="border-bottom-color: #00008b; height: 360px;" border="2" > 
                    <tr>
                        <td align="left" class="style11" >
                            &nbsp;List
                        </td>
                    </tr> 
                    <tr>
                        <td align="left" class="style10" >
                            <div id="gridformEmp">
                                 <asp:GridView ID="grvEmployee" runat="server" AllowPaging="True" PageSize="5" 
                                    AutoGenerateColumns="False" CellPadding="4" 
                                    GridLines="Horizontal" Width="411px" DataKeyNames="agency_id,name"  
                                    OnPageIndexChanging="grvEmployee_PageIndexChanging" 
                                     onselectedindexchanged="grvEmployee_SelectedIndexChanged">
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