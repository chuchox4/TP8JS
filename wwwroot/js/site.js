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
                $("#Titulo").html("Info: ")
                $("#DescripcionSerie").html(response.nombre + "<br/>"+ "Año Inicio: "+ response.añoInicio + "<br/>"+ response.sinopsis);

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
                $("#Titulo").html("Actores: ")
                $("#DescripcionSerie").html(datos);
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
                var temp = "";
                response.forEach(element => {
                temp += element.numeroTemporada + " " + element.tituloTemporada + "<br/>";
      });
                $("#Titulo").html("Temporadas: ");
                $("#DescripcionSerie").html(temp);

            }
    
    })
}






