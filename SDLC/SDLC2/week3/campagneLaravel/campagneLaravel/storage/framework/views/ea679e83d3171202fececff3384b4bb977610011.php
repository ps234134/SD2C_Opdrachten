<!DOCTYPE html>
<html lang="nl"> 
  <head>
    <link rel="stylesheet" href="styles/opmaak.css">
    <title>De Campagne</title>
  </head>

  <body>
  <main>
	<img id="logo" src="img/logo.jpg" /> 
	<nav> &nbsp; </nav>
	<article>
		<?php if($ingelogd): ?> 
		<h2 >Welkom <?php echo e($personeelsNaam); ?></h2> 
			<form method="post" action="blog">	
				<?php echo csrf_field(); ?>
				<p>Schrijf uw blog</p>
				<div>Title:   </div><textarea cols="50" rows="1" name="titel" autofocus ></textarea><br/>
				<div>Article: </div><textarea cols="50" rows="8" name="artikel"></textarea><br/><br/>
				<button type="submit">OK</button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button formaction="<?php echo e(url('/')); ?>" type="submit">Annuleren</button><br/><br/>
			</form>	
			<form method="post" action="bestand" enctype="multipart/form-data">
				<?php echo csrf_field(); ?>
				<p>Upload een afbeelding</p>
				<br/> <input type="file" name="bestand" /><br/><br/>
				<button  type="submit">Uploaden</button> 
			</form>	
			<br/>
		<?php else: ?>    
		<h2 >Welkom </h2> 
			<form method="post" action="login">	
				<?php echo csrf_field(); ?>              
				<p>Meld u aan om een blog te schrijven</p>
				<div>gebruikersnaam:</div><input type="text"  name="gebruikersnaam" autofocus /><br/>
				<div>wachtwoord: </div><input type="password" name="wachtwoord" /><br/><br/>
				<button type="submit">OK</button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button formaction="" type="submit">Annuleren</button><br/><br/>
			</form>
		<?php endif; ?>  
    </article>
	<div class="clearboth"></div>
	<footer>&copy; 2021 De Campagne</footer>
  </main>
  </body>
</html><?php /**PATH C:\Users\tutai\OneDrive\Bureaublad\Summa\SD2C\SDLC\SDLC2\week3\campagneLaravel\campagneLaravel\resources\views/blog.blade.php ENDPATH**/ ?>