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
    private int _IdTemporada;
    private int  _IdSerie;
    private int _NumeroTemporada;

    private string _TituloTemporada;


public Temporadas(){

}

public Temporadas (int IdTemporada, int IdSerie, int NumeroTemporada, string TituloTemporada){
    _IdTemporada = IdTemporada;
    _IdSerie = IdSerie;
    _NumeroTemporada = NumeroTemporada;
    _TituloTemporada = TituloTemporada;    
}

public int IdTemporada
{
    set{_IdTemporada = value;}
    get{return _IdTemporada;}
}

public int IdSerie
{
    set{_IdSerie = value;}
    get{return _IdSerie;}
}
public int NumeroTemporada
{
    set{_NumeroTemporada = value;}
    get{return _NumeroTemporada;}
}
public string TituloTemporada
{
    set{_TituloTemporada = value;}
    get{return _TituloTemporada;}
}


}