<!DOCTYPE html>
<html>

<head>
	<meta charset="UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<link rel="stylesheet" href="index.css">
	<script src="./index.js">
		defer
	</script>
	<title>Ajax_Jeux</title>
</head>

<body>
	

	<main id="boxes">


	<div class="Personnage" id="Personnage"></div>	

	<!-- Tableau debut -->
	<table id="Table" class="Table">
		<tr>
			<th>ID</th>
			<th>name</th>
			<th>level</th>
			<th>description</th>
			<th>power</th>
			<th>attack</th>
			<th>armor</th>
			<th>damage</th>
			<th>mitigation</th>
			<th>played</th>
			<th>victory</th>
			<th>defeat</th>
			<th>draw</th>
		</tr>
	</table>
	
	</main>
	<!-- Tableau fin -->
	<br>
	<form id="form">
 
	<input type="text" placeholder="Who's the player with the..." readonly="true">
  <input type="button" id="power" value="Best power" />
  <input type="button" id="played" value="Most Games Played" />
  <input type="button" id="armor" value="Best armor" />
  <input type="button" id="victory" value="Most Victories" />
  <input type="submit" id="reset" value="Dont push">
</form>

</body>

</html>