<%@ Control Language="C#" AutoEventWireup="true" CodeFile="NewModel.ascx.cs" Inherits="Controles_NewModel" %>
<head>
  <title></title>
  <meta http-equiv="content-type" content="text/html; charset=utf-8" />
  <style type="text/css" media="all">
  	@import "../Css/Css.css";
   </style>
  <!--[if lte IE 7]>

  <style type="text/css" media="all">
  	@import "../Css/fieldset-background-image-ie.css";
      #header
      {
          width: 597px;
      }
  </style>

  <![endif]-->
</head>
<body>
	<div id="page">
		<div id="header">
			<h1>
				Modelo
			</h1>
		</div> <!-- END #header -->
		<div class="contentFilho">
			<form class="formFilho" action="">
				<fieldset class="fieldset">
					<legend>
						Contact Details
					</legend>
					<ol>
						<li>
							<label for="name">
								Agency ID:
							</label>
                            <asp:TextBox ID="txtAgencyId" CssClass="text" Enabled="false" runat="server"/>
						</li>
						<li>
							<label for="email">
								Agency Name:
							</label>
                            <asp:TextBox ID="txtAgencyName" CssClass="text" runat="server"/>
						</li>
						<li>
							<label for="phone">
								Telephone:
							</label>
							<input id="phone" name="phone" class="text" type="text" />
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldset">
					<legend>
						Delivery Address
					</legend>
					<ol>
						<li>
							<label for="address1">
								Address 1:
							</label>
							<input id="address1" name="address1" class="text" type="text" />
						</li>
						<li>
							<label for="address2">
								Address 2:
							</label>
							<input id="address2" name="address2" class="text" type="text" />
						</li>
						<li>
							<label for="suburb">
								Suburb/Town:
							</label>
							<input id="suburb" name="suburb" class="text" type="text" />
						</li>
						<li>
							<label for="postcode">
								Postcode:
							</label>
							<input id="postcode" name="postcode" class="text textSmall" type="text" />
						</li>
						<li>
							<label for="country">
								Country:
							</label>
							<input id="country" name="country" class="text" type="text" />
						</li>
					</ol>
				</fieldset>
				<fieldset class="fieldsetSubmit" >
					<input class="submit" type="submit" value="Begin download" />
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
</body>