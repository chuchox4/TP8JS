using System.Net.Mime;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Data;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System;
using TP8JS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace TP8JS;

public class Series{

    private int _IdSerie;

    private string _Nombre;

    private int _AñoInicio;


    private string _Sinopsis;

    private string _ImagenSerie;


public Series(){

}

public Series(int IdSerie, string Nombre, int AñoInicio, string Sinopsis, string ImagenSerie){

    _IdSerie = IdSerie;
    _Nombre = Nombre;
    _AñoInicio = AñoInicio;
    _Sinopsis = Sinopsis;
    _ImagenSerie = ImagenSerie;
}

public int IdSerie
{
    set{_IdSerie = value;}
    get{return _IdSerie;}
}

public string Nombre
{
    set{_Nombre = value;}
    get{return _Nombre;}
}

public int AñoInicio
{
    set{_AñoInicio = value;}
    get{return _AñoInicio;}
}

public string Sinopsis
{
    set{_Sinopsis = value;}
    get{return _Sinopsis;}
}

public string ImagenSerie
{
    set{_ImagenSerie = value;}
    get{return _ImagenSerie;}
}

}