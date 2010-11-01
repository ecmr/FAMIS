<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimeSheet.aspx.cs" Inherits="TimeSheet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Timers</title>
    <style type="text/css">
        .style1
        {
            height: 33px;
        }
        .style2
        {
            height: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
    <br />
    <div style="width: 362px; height: 391px;">
        <table cellpadding="1" border="1" style="width: 369px; height: 136px;">
            <tr>
                <td class="style17">
                    <asp:Label ID="lblDaysWeek" runat="server" Font-Bold="True" Font-Size="16px" Width="100%" 
                        Text="Sunday 09/21" style="text-align: center; font-size: large;"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style21">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="UpdateTimer" EventName="Tick" />
                        </Triggers>
                        <ContentTemplate>
                            <asp:Label ID="lblTime" Width="354px" runat="server" Text="00:00:00" Font-Bold="True"
                                Font-Size="36px" Style="text-align: center"></asp:Label>
                            <asp:Timer ID="UpdateTimer" runat="server" Enabled="False" Interval="1000" OnTick="UpdateTimer_Tick" />
                            <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="100" OnTick="Timer1_Tick1">
                            </asp:Timer>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Label ID="LblUser" runat="server"  Font-Bold="True" Font-Size="16px" Style="text-align:left"
                        Text="User: " Width="100%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:Label ID="lblWorkingFor" runat="server" Font-Bold="True" Font-Size="16px" Style="text-align: center"
                        Text="WORKING FOR:" Width="100%"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style22">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownCliPro" runat="server" Height="43px" Width="99%" Font-Bold="True"
                                Font-Size="Medium">
                                <asp:ListItem>Client A - Project 4</asp:ListItem>
                                <asp:ListItem>Client C - Project 2</asp:ListItem>
                                <asp:ListItem>Client X - Project 8</asp:ListItem>
                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td class="style18">
                    <div id="start">
                        <table style="height: 79px">
                            <tr>
                                <td>
                                    <asp:ImageButton ID="imgStart" runat="server" ImageUrl="~/imagens/TimeSheet/play.jpg"
                                        Style="width: 74px; height: 73px; text-align: center" OnClick="imgStart_Click" />
                                    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp; <b>PLAY</b>
                                </td>
                                <td>
                                    <asp:ImageButton ID="imgStop" runat="server" ImageUrl="~/imagens/TimeSheet/stop.jpg"
                                        Style="width: 74px; height: 73px; text-align: center" OnClick="imgStop_Click" />
                                    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp; <b>STOP</b>
                                </td>
                                <td>
                                    <img alt="Client" src="imagens/TimeSheet/client.png" style="width: 74px; height: 73px;
                                        text-align: justify" /><br />
&nbsp; <b>CLIENT</b>
                                </td>
                                <td class="style23">
                                    <asp:ImageButton ID="imgComent" runat="server" ImageUrl="~/imagens/TimeSheet/comment.jpg"
                                        Style="width: 74px; height: 73px; text-align: center;" 
                                        OnClick="imgComent_Click" /><br />
                                    <b>COMMENT</b>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div visible="false" id="coment">
                        <asp:TextBox ID="txtcoment" Visible="false" TextMode="MultiLine" runat="server" Height="73px"
                            Width="356px"></asp:TextBox><br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnComentSend" Visible="false" Text="Send" runat="server" Height="22px"
                            Width="69px" OnClick="btnComentSend_Click" />
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <asp:UpdatePanel runat="server" ID="TimedPanel" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="UpdateTimer" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
    </form>
</body>
</html>
