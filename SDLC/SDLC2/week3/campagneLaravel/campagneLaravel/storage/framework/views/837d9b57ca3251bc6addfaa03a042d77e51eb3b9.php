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
<main>
    <img id="logo" src="img/logo.jpg" />  
    <nav><br/>
    <?php $__currentLoopData = $nieuws; $__env->addLoop($__currentLoopData); foreach($__currentLoopData as $n): $__env->incrementLoopIndices(); $loop = $__env->getLastLoop(); ?>
        <?php if($ingelogd): ?>
            <a href='verwijder/<?php echo e($n->ID); ?>'><button>Verwijder</button></a>&nbsp;&nbsp;&nbsp;
        <?php endif; ?>
        <a href='<?php echo e($n->ID); ?>'><?php echo e($n->titel); ?></a>
        <br><br>
    <?php endforeach; $__env->popLoop(); $loop = $__env->getLastLoop(); ?>
    <a href="blog">Nieuwe blog</a>
    <?php if($ingelogd): ?>
        <form><button formaction='logout' type='submit'><?php echo e($personeelsNaam); ?> afmelden</button></form><br/> 
    <?php endif; ?>
    </nav>
    <article>
    <h2 id="titel"><?php echo e($item->titel); ?></h2>
    <p> <?php echo $item->inhoud; ?> </p>
    </article>
    <div class="clearboth"></div>
    <footer>	  
        Auteur: <?php echo e($auteur->voorletter); ?> <?php echo e($auteur->naam); ?> &nbsp; &copy; 2021 De Campagne
    </footer>
</main>  
</body>
</html><?php /**PATH C:\Users\amje\Desktop\Zooi\campagneLaravel\campagneLaravel\resources\views/nieuws.blade.php ENDPATH**/ ?>