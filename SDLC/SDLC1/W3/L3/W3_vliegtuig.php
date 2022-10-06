<?php

declare (strict_types=1);


enum Ervaring : int
{
    case Basis = 0;
    case Ervaren = 1;
    case Excellent = 2;
 
}

class Bemanningslid{
public int $iD;
public string $naam;

}

class Piloot extends Bemanningslid{
    public Ervaring $ervaringsniveau;
    public function __construct(string $naam)
    {
   
    }
}

class Navigator extends Bemanningslid{}


class Vlucht{

    private array $bemanningsleden;
    private Vliegtuig $vliegtuig;
    private Luchthaven $vertrekLocatie;
    private Luchthaven $aankomstLocatie;

    public int $iD;
    public DateTime $vertrekTijd;
    public DateTime $aankomst;

    public function __construct(int $id,  Luchthaven $vertrekLocatie, Luchthaven $aankomstLocatie, DateTime $vertrekTijd, DateTime $aankomstTijd){}

    public function begin():void{}
    public function beeindig():void{}
    public function stelBemmaningOp():void{}

}

class Vliegtuig{

    public int $iD;
    public string $naam;

    public function __construct(int $iD, string $type){}
}

class Luchthaven{
    public int $iD;
    public string $naam;

    public function __construct(int $iD, string $naam){} 
}