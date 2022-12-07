<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styles/opmaak.css">
    <title>De Campagne</title>
</head>
<body>
    <form method="post" action="login">	  
        <?php echo csrf_field(); ?>;             
            <p>Meld u aan om een blog te schrijven</p>
            <div>gebruikersnaam:</div><input type="text"  name="gebruikersnaam" autofocus /><br/>
            <div>wachtwoord: </div><input type="password" name="wachtwoord" /><br/><br/>
            <button type="submit">OK</button>
		</form>    
        <form method="get" action="">	               
            <button type="submit">Annuleren</button><br/><br/>
		</form>    
</body>
</html><?php /**PATH C:\Users\amje\Bibliotheek\SDLC2\week 3\campagneLaravel\resources\views/login.blade.php ENDPATH**/ ?>