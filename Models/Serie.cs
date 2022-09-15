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

    public int _IdSerie{get; private set;}

    public string _Nombre{get; private set;}

    public int _AñoInicio{get; private set;}


    public string _Sinopsis{get; private set;}

    public string _ImagenSerie{get; private set;}


public Series(){

}

public Series(int IdSerie, string Nombre, int AñoInicio, string Sinopsis, string ImagenSerie){

    _IdSerie = IdSerie;
    _Nombre = Nombre;
    _AñoInicio = AñoInicio;
    _Sinopsis = Sinopsis;
    _ImagenSerie = ImagenSerie;
}

}