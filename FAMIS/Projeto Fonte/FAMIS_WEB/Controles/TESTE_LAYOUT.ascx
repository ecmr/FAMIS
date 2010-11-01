<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TESTE_LAYOUT.ascx.cs" Inherits="Controles_TESTE_LAYOUT" %>
<style type="text/css">
    .style1
    {
    }
    .style3
    {
    }
    .style4
    {
        width: 147px;
    }
    </style>
<table style="width:100%;">
    <tr>
        <td class="style4">
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td rowspan="8">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Client Id</td>
        <td>
            Code</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            Local Name</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style1" colspan="2">
            <asp:TextBox ID="TextBox3" runat="server" Width="467px"></asp:TextBox>
        </td>
        <td class="style1" colspan="2">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            Intl Name</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style3" colspan="2">
            <asp:TextBox ID="TextBox4" runat="server" Width="467px"></asp:TextBox>
        </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td class="style4">
            Active
            <asp:RadioButton ID="RadioButton1" Text="True" runat="server" />
            <asp:RadioButton ID="RadioButton2" Text="False" runat="server" />
        </td>
        <td>
            Multinational 
            <asp:RadioButton ID="RadioButton3" Text="True" runat="server" />
            <asp:RadioButton ID="RadioButton4" Text="False" runat="server" />
         </td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
