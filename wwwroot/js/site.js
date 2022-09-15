function VerInfoSerie(IDS) 
{
    $.ajax({
        URL: '/Home/VerSeriesAjax',
        data: {IdSerie : IDS},
        type: 'POST',
        dataType: 'JSON',
        success:
            function(response)
            {
                $("#DescripcionSerie").html(response.nombre + response.añoInicio + response.sinopsis);

            }
    
    })
}

function VerActores(IDS) 
{
    $.ajax({
        URL: '/Home/VerActoresAjax',
        data: {IdSerie : IDS},
        type: 'POST',
        dataType: 'JSON',
        success:
            function(response)
            {
                $("#NombreActor").html(response.nombre);

            }
    
    })
}

function VerTemporadas(IDS) 
{
    $.ajax({
        URL: '/Home/VerTemporadasAjax',
        data: {IdSerie : IDS},
        type: 'POST',
        dataType: 'JSON',
        success:
            function(response)
            {
                $("#NumeroActor").html(response.numeroTemporada);
                $("#TituloTemporada").html(response.tituloTemporada);

            }
    
    })
}






