<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\BeurtController;

Route::get('/', [BeurtController::class, 'getIndex']);
Route::get('Start', [BeurtController::class, 'getIndex']);
Route::post('OK', [BeurtController::class, 'postOK']);
Route::get('Open', [BeurtController::class, 'getOpen']);


