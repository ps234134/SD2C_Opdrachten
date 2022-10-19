<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

/**
    @class MM
    * @property string TeRaden te raden getal bestaande uit 4 cijfers
    * @property integer Beurt beurtnummer
    * @property array Pogingen bevat de pogingen
    * @property bool OpenSpel keuze of te raden getal zichtbaar is (ontwikkelmodus)
*/

class MM extends Model
{
    public $TeRaden;
    public $Beurt;
    public $Pogingen = array();
    public $OpenSpel = FALSE;

    /**
        * @method NieuwSpel Start nieuw spel.
        * @property Beurt krijgt de waarde 0
        * @property TeRaden krijgt nieuwe waarde
        * @property Pogingen wordt geleegd
        *
        * @param  void
        * @return void
     */
    public function NieuwSpel()
    {
        $this->Beurt = 0;

        $this->TeRaden = "";
        $mogelijkheden = "1234567890";          // deze cijfers mag TeRaden bevatten
        for ($i=0; $i<4; $i++){                 // TeRaden bestaat uit 4 cijfers
            do {
                $x = rand(0,9);
                $teradencijfer = $mogelijkheden[$x];
                $mogelijkheden[$x] = 'x';
                
            } while ($teradencijfer == 'x');    // voorkom dubbelingen in TeRaden
            $this->TeRaden .= $teradencijfer;
        }        
        $this->Pogingen = array();
    }

    /**
        * @method NieuweBeurt Start nieuwe beurt
        * @property Beurt wordt opgehoogd
        * @param  void
        * @return void
     */    
    public function NieuweBeurt()
    {
        $this->Beurt++;
    }
    /**
        * @method PositiesOK Bereken aantal correcte posities van poging in TeRaden.
        * @param string $poging 4 cijfers
        * @return integer aantal correcte posities
     */    

    public function PositiesOK($poging)
    {
        $positiesOK = 0;
        for ($i = 0; $i < 4; $i++) if ( $this->TeRaden[$i] ==  $poging[$i]) $positiesOK++;
        return $positiesOK;
    }
    /**
        * @method AantalOK Bereken aantal correcte cijfers van poging in TeRaden.
        * @param string $poging 4 cijfers
        * @return integer aantal correcte cijfers
     */   

    public function AantalOK($poging)
    {
        $aantalOK = 0;
        $teraden = $this->TeRaden;
        for ($i = 0; $i < 4; $i++)
        {          
            $y = strpos($teraden, $poging[$i]);
            if ($y !== FALSE)
            {
                $aantalOK++;
                $teraden[$y] = 'x';
            }
        }
        return $aantalOK;
    }
}
