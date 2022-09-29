<?php
declare(strict_types =1);

class Chauffeur{
    public int $personeelnummer;
    public string $naam;

    public function __construct(string $naam)
    {
        
    } 

class CarRent{
    private array $chauffeurs;
    private array $autos;
    public string $naam;

    public function verhuurAuto(Auto $auto, DateTime $date): bool{return true;}
    public function verhuurChauffeur(Chauffeur $chauffeur, DateTime $date): bool{return true;}

    public function retourneerAuto(Auto $auto):bool{return true;}

    public function retourneerChauffeur(Chauffeur $chauffeur):bool{return true;}
}

abstract class Auto{
    private string $kenteken;
    public function getKenteken(){
        return $this -> kenteken;
    }
    private string $model;
    public function getModel(){
        return $this -> model;
    }

    public bool $inzetbaar;

}

class Standaard extends Auto{
    public bool $trekhaakAanwezig;

    public function __construct(string $kenteken, string $model, bool $trekhaakAanwezig){

    }
}

class Limousine extends Auto{
    public bool $minibarAanwezig;

    public function __construct(string $kenteken, string $model, bool $minibarAanwezig)
    {
        
    }
}

class _4WD extends Auto{
    public function __construct(string $kenteken, string $model)
    {
        
    }
}

class Vrachtwagen extends Auto{
    public int $laadvermogen;

    public function __construct(string $kenteken, string $model, int $laadvermogen)
    {
        
    }
}