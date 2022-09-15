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
    public int _IdActor{get; private set;}
    public int  _IdSerie{get; private set;}
    public string _Nombre{get; private set;}


public Actores(){

}

public Actores (int IdActor, int IdSerie, string Nombre){
    _IdActor = IdActor;
    _IdSerie = IdSerie;
    _Nombre = Nombre;    
}

}