<%@ control language="C#" autoeventwireup="true" inherits="Grade, App_Web_wegg2lxr" %>
<strong><em><span style="text-decoration: underline">
Categoria:</span></em></strong><asp:Label ID="lblCategoria" runat="server" Text="Label" Font-Bold="True" ForeColor="Blue"></asp:Label>
<asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        		Produto: <asp:Label ID="lblProduto" 
        		Runat="server" 
       			Text='<%# Eval("ProductName") %>'>
				</asp:Label>
		       	<br/>
			Unidades no estoque: <asp:Label ID="lblQuantidade" 
       			Runat="server" 
	        	Text='<%# Eval("UnitsInStock") %>'>
        			</asp:Label>
		       	<br/>
		       	Preço unitário: <asp:Label ID="lblValor" 
       			Runat="server" 
	      		Text='<%# Eval("UnitPrice") %>'>
      					</asp:Label>
       			<p/>
    </ItemTemplate>
</asp:DataList>
