function VerInfoSerie(IDS) 
{
    $.ajax({
        url: '/Home/VerSeriesAjax',
        data: {IdSerie : IDS},
        type: 'POST',
        dataType: 'JSON',
        success:
            function(response)
            {
                $("#DescripcionSerie").html(response.nombre + "<p>Año Inicio: </p>"+ response.añoInicio + "<br/>"+ response.sinopsis);

            }
    
    })
}

function VerActores(IDS) 
{
    $.ajax({
        url: '/Home/VerActoresAjax',
        data: {IdSerie : IDS},
        type: 'POST',
        dataType: 'JSON',
        success:
            function(response)
            {
                let datos = "";
                response.forEach(element => {
                    
                    datos += element.nombre + "</br>";
                });
                $("#NombreActor").html();
            }
    
    })
}

function VerTemporadas(IDS) 
{
    $.ajax({
        url: '/Home/VerTemporadasAjax',
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






