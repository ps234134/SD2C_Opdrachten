<?php
declare(strict_types =1);

class AdministratieED{
    private array $abonnee;
    public float $abonnementsprijs;

    public function NieuweAbonnee(Abonnee $abonnee): void{}

    public function StopAbonnement(Abonnee $abonnee): void{}
}

class Abonnee extends Persoon{
    private AdministratieED $administratieED;
    private string $bankrekening;
    public function getBankrekening(){
        return $this -> bankrekening;
    }

    private DateTime $einddatum;
    public function getEinddatum(){
        return $this -> einddatum;
    }

    public function __construct(string $naam, string $adres, string $woonplaats, string $bankrekenign){

    }
    
    public function Verlenging(DateTime $einddatum): bool {return true;}


}

class Persoon{
    public string $naam;
    public string $adres;
    public string $woonplaats;



}






