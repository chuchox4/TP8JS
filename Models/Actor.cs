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

public class Actores{
    private int _IdActor;
    private int  _IdSerie;
    private string _Nombre;


public Actores(){

}

public Actores (int IdActor, int IdSerie, string Nombre){
    _IdActor = IdActor;
    _IdSerie = IdSerie;
    _Nombre = Nombre;    
}
public int IdActor
{
    set{_IdActor = value;}
    get{return _IdActor;}
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

}