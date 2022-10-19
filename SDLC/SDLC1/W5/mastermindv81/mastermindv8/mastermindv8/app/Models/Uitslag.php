<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Uitslag extends Model
{
    public $Poging;
    public $Posities;
    public $Aantal;
    private $beurt;

    public function Uitslag($beurt, $poging, $pos, $aantal)
    {
        $this->beurt = $beurt + 1;
        $this->Poging = $poging;
        $this->Posities = $pos;
        $this->Aantal = $aantal;
    }
    public function ToString()
    {
        return "$this->beurt \t $this->Poging \t\t $this->Posities \t $this->Aantal";
    }
}
