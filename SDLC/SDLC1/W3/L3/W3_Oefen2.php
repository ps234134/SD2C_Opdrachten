<?php

declare(strict_types =1);

class Speelveld{
    private array $batje;
    private Bal $bal;

    public int $hoogte;
    public int $breedte;
    
    public function balGeraakt(): Batje {return new Batje();}

}

class Batje{
    private Speler $speler;
    private int $x;
    public function getX(){
        return $this -> x;
    }

    private int $y;
    public function getY(){
        return $this -> y;
    }

    public function nieuwePositie(int $x, int $y)
    {
        
    }
}

class bal{
    public int $x;
    public int $y;
    public int $richting;
    
    public function nieuwRichting(): void{}
}

class Speler{
    private Batje $batje;
    public string $naam;
    private int $score;
    public function getScore(){
        return $this -> score;
    }

    public function verhoogScore(): void{}
}

class Mens extends Speler{
    private int $levens;
    public function getLevens(){
        return $this -> levens;
    }

    public function __construct(string $naam, int $levens)
    {
        
    }

    public function verlaagLevens(): void{}
}

class Robot extends Speler{
        public int $niveau;
        public function __construct(string $naam, int $niveau)
        {
            
        }

}