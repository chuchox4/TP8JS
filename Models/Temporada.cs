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

public class Temporadas{
    public int _IdTemporada{get; private set;}
    public int  _IdSerie{get; private set;}
    public string _NumeroTemporada{get; private set;}

    public string _TituloTemporada{get; private set;}


public Temporadas(){

}

public Temporadas (int IdTemporada, int IdSerie, string NumeroTemporada, string TituloTemporada){
    _IdTemporada = IdTemporada;
    _IdSerie = IdSerie;
    _NumeroTemporada = NumeroTemporada;
    _TituloTemporada = TituloTemporada;    
}

}