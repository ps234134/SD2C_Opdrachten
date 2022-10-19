<!doctype html>
<html lang="nl">
    <head>
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
		<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css">
        <title>MasterMind</title>

        <style>
            button {width:100%; margin-top:20px; margin-bottom:20px;}
            .container {width:20%; min-width:300px;}
            h1 {margin-top:40px; margin-bottom:20px;}
        </style>
    </head>
    <body>
    <div class="container">
        <h1>Speelveld</h1>
       
        <table class="table">
            <tr><th>Poging</th><th>Posities</th><th>Aantal</th></tr>
            @foreach ($mm->Pogingen as $p)
                <tr>
                <td> {{ $p   }} </td>
                <td> {{ $mm->PositiesOK($p) }}  </td>
                <td> {{ $mm->AantalOK($p) }}  </td>
                </tr>
            @endforeach
        </table>

        <form action="Open" method="get">
            <div class="form-group">
                <input type="checkbox" class="form-check-inline" onclick="submit()"/>Open Spel: 
                @if ($mm->OpenSpel) {{ $mm->TeRaden }} @endif
            </div>
        </form>
        <form action="Start" method="get">
            <div class="form-group">
                <button class="btn btn-primary" >Start</button>
            </div>
        </form>
        <form action="OK" method="post">
            @csrf
            <div class="form-group">
                <input name="poging" class="form-control" maxlength="4" />
                <button class="btn btn-primary" >OK</button>
            </div>
        </form>
    </div>
    </body>
</html>
