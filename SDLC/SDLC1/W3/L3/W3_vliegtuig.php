<?php

declare (strict_types=1);


enum Ervaring
{
    case Basis;
    case Ervaren;
    case Excellent;
 
}

class Bemanningslid{
public int $iD;
public string $naam;

}

class Piloot extends Bemanningslid{
    public Ervaring $ervaringsniveau;
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

    public function begin(){}
    public function beeindig(){}
    public function stelBemmaningOp(){}

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