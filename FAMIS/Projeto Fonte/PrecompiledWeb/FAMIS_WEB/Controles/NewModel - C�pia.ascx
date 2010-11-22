<%@ control language="C#" autoeventwireup="true" inherits="Controles_NewModel, App_Web_oribna0w" %>
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
				Agencies
			</h1>
		</div> <!-- END #header -->
		<div id="content">
			<form action="">
				<fieldset>
					<legend>
						Contact Details
					</legend>
					<ol>
						<li>
							<label for="name">
								Name:
							</label>
							<input id="name" name="name" class="text" type="text" />
						</li>
						<li>
							<label for="email">
								Email address:
							</label>
							<input id="email" name="email" class="text" type="text" />
						</li>
						<li>
							<label for="phone">
								Telephone:
							</label>
							<input id="phone" name="phone" class="text" type="text" />
						</li>
					</ol>
				</fieldset>
				<fieldset class="alt">
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
				<fieldset class="submit">
					<input class="submit" type="submit" value="Begin download" />
				</fieldset>
			</form>
		</div><!-- END #content -->
	</div> <!-- END #page -->
</body>