<%@ Page Title="Employee" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Employee" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 650px;
        }
    </style>
    </asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <h2>
        Employee
    </h2>
    <div id="divMaster">
        <p>
            <table style="width: 100%;">
                <tr>
                    <td class="style1">
                        <table style="width: 643px">
                            <tr>
                                <td class="divX">
                                    <label>Employee Id:</label> 
                                    <asp:TextBox ID="TxtEmployee_id" CssClass="text" Enabled="false" runat="server" Width="100px"/>
                                </td>            
                            </tr>
                            <tr>
                                <td class="divX">
                                    <label>First Name:</label>
                                    <asp:TextBox ID="TxtFirstName" CssClass="text" runat="server" Width="200px"/>
                                    <asp:Label ID="lblMsgFn" runat="server" ></asp:Label>
                                </td>            
                            </tr>
                            <tr>
                                <td  class="divX">
                                <label>Last Name:</label>
                                    <asp:TextBox ID="txtLast_name" runat="server" Width="200px"></asp:TextBox>
                                    <asp:Label ID="lblMsgLn" runat="server"></asp:Label>
                                </td>            
                            </tr>
                            <tr>
                                <td class="divX">
                                    <label>Code:</label>
                                    <asp:TextBox ID="TxtCode" runat="server" Height="22px" Width="200px"></asp:TextBox>
                                </td>            
                            </tr>
                            <tr>
                                <td class="divX">
                                <label>Agency:</label>
                                    <asp:DropDownList ID="DropDownAgencies" Height="22px" Width="229px" runat="server"></asp:DropDownList>
                                </td>            
                            </tr>
                            <tr>
                                <td class="divX">
                                    <label>Position:</label>
                                    <asp:DropDownList ID="DropDownPosition" Height="22px" Width="229px" runat="server"></asp:DropDownList>
                                </td>            
                            </tr>
                            <tr>
                                <td class="divX">
                                    <label>Salary:</label>
                                    <asp:TextBox ID="TxtSalary" runat="server" Width="100px"></asp:TextBox> 
                                </td>            
                            </tr>
                            <tr>
                                <td class="divX">
                                    <label>Hired Date:</label>
                                    <asp:TextBox ID="txtDateHired" runat="server" Width="100px"></asp:TextBox>
                                    <asp:Image ID="ImgCalendar" ImageUrl="~/imagens/Crm/calon.gif" runat="server" />
                                    <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDateHired" PopupButtonID="ImgCalendar" Format="yyyy-MM-dd" runat="server">
                                    </asp:CalendarExtender>
                                </td>            
                            </tr>                        
                        </table>
                    </td>
                    <td>
                        <table >
                            <tr>
                                <td>
                                    <asp:Image ID="PicturePhoto" runat="server" 
                                        ImageUrl="~/imagens/Pictures/Edinei.JPG" Width="233px" Height="181px" 
                                        BorderStyle="Solid" BorderWidth="2px" style="margin-top: 0px" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:FileUpload ID="FileUploadPhoto" runat="server" EnableViewState="false" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="UploadPhoto" OnClick="UploadPhoto_Click" Width="90px" Height="23px"  runat="server" Text="Upload" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="grvEmployee" runat="server" AllowPaging="True" PageSize="5" 
                        AutoGenerateColumns="False" CellPadding="4" 
                        GridLines="Horizontal" Width="100%" DataKeyNames="employee_id,first_name,date_hired,salary"  
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
                                    DataField="employee_id" HeaderStyle-CssClass="grid_tittle_div" 
                                    HeaderStyle-Width="20%">
                            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            </asp:BoundField>
                            <asp:BoundField HeaderText="First Name" HeaderStyle-HorizontalAlign="Center" 
                                    DataField="first_name" HeaderStyle-CssClass="grid_tittle" 
                                    HeaderStyle-Width="40%">
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            </asp:BoundField>
                            <asp:BoundField HeaderText="Hired date" HeaderStyle-HorizontalAlign="Center" 
                                    DataField="date_hired"  HeaderStyle-CssClass="grid_tittle" 
                                    HeaderStyle-Width="40%" HtmlEncode="False">
                                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                            </asp:BoundField>
                                <asp:BoundField DataField="salary" HeaderText="Salary" />
                            </Columns>
                        <pagerstyle backcolor="LightBlue"/>                
                        <FooterStyle />
                        <RowStyle CssClass="grid_line_01" />
                        <HeaderStyle />
                        <AlternatingRowStyle CssClass="grid_line_02" />
                    </asp:GridView>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;<asp:LinkButton ID="lkbSalvar" runat="server" CssClass="BotoesMenu" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
                    </td>
                    <td></td>
                </tr>
        </table>
        </p>
    </div>

</asp:Content>