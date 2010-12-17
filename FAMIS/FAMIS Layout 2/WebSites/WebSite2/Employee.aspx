<%@ Page Title="Employee" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Employee.aspx.cs" Inherits="Employee" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            width: 650px;
        }
        .style2
        {
            height: 340px;
        }
        .style3
        {
            height: 340px;
        }
        .style4
        {
            height: 319px;
        }
    </style>
    </asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <h2>
        Employee&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="lkbSalvar" runat="server" CssClass="BotoesMenu" BorderColor="ActiveBorder" onclick="lkbSalvar_Click" ><asp:Image ID="btnSalvar" runat="server" ToolTip="Salvar" ImageAlign="AbsMiddle" ImageUrl="~/imagens/Crm/btn_on_down.gif" />Save</asp:LinkButton>
    </h2>
    <div id="divMaster">
        <table style="width: 100%;">
                <tr>
                    <td class="style1">
                        <table>
                            <tr>
                                <td class="style4">
                                   <fieldset class="fieldsetEmployee">
					            <legend>
						            Employee Details
					            </legend>
					            <ol style="height: 239px; width: 100%;">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
						            <li style="height: 30px; width: 100%;">
							            <label for="name">
								            Employee ID:
							            </label>
                                        <asp:TextBox ID="TxtEmployee_id" CssClass="text" Enabled="false" runat="server" Width="100px"/>
						            </li>
						            <li style="height: 30px; width: 100%;">
							            <label for="email">
								            First Name:
							            </label>
                                        <asp:TextBox ID="TxtFirstName" CssClass="text" runat="server" Width="200px"/>
                                        <asp:Label ID="lblMsgFn" runat="server" ></asp:Label>
						            </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="lastName">
                                            Last Name:
                                        </label>
                                        <asp:TextBox ID="txtLast_name" runat="server" Width="200px"></asp:TextBox>
                                        <asp:Label ID="lblMsgLn" runat="server"></asp:Label>
                                    </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="code">
                                            Code:
                                        </label>
                                        <asp:TextBox ID="TxtCode" runat="server" Height="22px" 
                                            Width="200px"></asp:TextBox>
                                    </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="Position">
                                            Position:
                                        </label>
                                        <asp:DropDownList ID="DropDownPosition" Height="22px" Width="200px" 
                                            runat="server"></asp:DropDownList>
                                    </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="Position">
                                            Agency:
                                        </label>
                                        <asp:DropDownList ID="DropDownAgencies" Height="22px" Width="200px" 
                                            runat="server"></asp:DropDownList>
                                    </li>
                                    <li style="height: 30px; width: 100%;">
                                        <label for="Salary">
                                            Salary:
                                        </label>
                                        <asp:TextBox ID="TxtSalary" runat="server" Width="100px"></asp:TextBox> 
                                    </li>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                                    <li class="LIEmployeeColA">
                                        <label for="code">
                                            Hired Date:
                                        </label>
                                    <asp:TextBox ID="txtDateHired" runat="server" Width="100px"></asp:TextBox>
                                    <asp:Image ID="ImgCalendar" ImageUrl="~/imagens/Crm/calon.gif" runat="server" />
                                    <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="txtDateHired" PopupButtonID="ImgCalendar" Format="yyyy-MM-dd" runat="server">
                                    </asp:CalendarExtender>
                                    </li>
					            </ol>
				            </fieldset>
                                </td>
                            </tr>                       
                        </table>
                    </td>
                    <td style="width: 30%;">
                        <table class="style3" >
                            <tr>
                                <td class="style2">
                                    <fieldset class="fieldsetEmployeeB">
					                    <legend>
						                    Employee Photo
					                    </legend>
                                        &nbsp;&nbsp;<asp:Image ID="PicturePhoto" runat="server" 
                                            ImageUrl="~/imagens/Pictures/Edinei.JPG" Width="220px" Height="175px" 
                                            BorderStyle="Solid" BorderWidth="2px" style="margin-top: 0px; top: 0;" 
                                            ImageAlign="Top" />
                                            <br />
                                        <br />
                                            <asp:FileUpload ID="FileUploadPhoto" runat="server" EnableViewState="false" />
                                            <br />
                                        <br />
                                            <asp:Button ID="UploadPhoto" OnClick="UploadPhoto_Click" Width="90px" Height="23px"  runat="server" Text="Upload" />
                                     </fieldset>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td >
                        <asp:GridView ID="grvEmployee" runat="server" AllowPaging="True" PageSize="3" 
                        AutoGenerateColumns="False" CellPadding="4" 
                        GridLines="Horizontal" Width="98%" DataKeyNames="employee_id,first_name,date_hired,salary"  
                        OnPageIndexChanging="grvEmployee_PageIndexChanging" 
                            onselectedindexchanged="grvEmployee_SelectedIndexChanged" Height="199px">
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
                    <td style="width:30%;></td>
                </tr>
                </table>
    </div>

</asp:Content>