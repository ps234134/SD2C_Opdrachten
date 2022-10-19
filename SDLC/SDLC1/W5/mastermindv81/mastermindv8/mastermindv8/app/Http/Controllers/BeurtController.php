<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\MM;


class BeurtController extends Controller
{
    public function getIndex(Request $request)
    {
        $request->session()->forget('Pogingen');

        $mm = new MM();
        $mm->NieuwSpel();

        session(['Beurt' => $mm->Beurt]);
        session(['TeRaden' => $mm->TeRaden]);
        session(['OpenSpel' => $mm->OpenSpel]);
        session(['Pogingen' => $mm->Pogingen]);

        return view('speelveld', array('mm'=>$mm));
    }
    public function getOpen(Request $request)
    {
        $mm = new MM();
        $mm->Beurt = session('Beurt');
        $mm->TeRaden = session('TeRaden');
        $mm->Pogingen = session('Pogingen');
        $mm->OpenSpel = !session('OpenSpel');

        //var_dump($mm->OpenSpel);
        session(['OpenSpel' => $mm->OpenSpel]);

        return view('speelveld', array('mm'=>$mm));
    }
    public function postOK(Request $request)
    {
        $mm = new MM();
        $mm->Beurt = session('Beurt');
        $mm->TeRaden = session('TeRaden');
        $mm->Pogingen = session('Pogingen');
        $mm->OpenSpel = session('OpenSpel');

        $poging = $request->input('poging');
        $request->session()->push('Pogingen', $poging);
        $mm->Pogingen = session('Pogingen');

        return view('speelveld', array('mm'=>$mm));
    }
}
