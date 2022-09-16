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
namespace TP8JS.Models;

public static class BD
{
    
    private static string _connectionString = @"Server=A-phz2-cidi-053;DataBase=BDSeries;Trusted_Connection=True;";
    
private static  List<Series> _ListaSeries = new List<Series>();
 public static List<Series> ListarSeries()
   {
    using(SqlConnection db =  new  SqlConnection(_connectionString)){
        string sql = "Select *  FROM Series";
        _ListaSeries= db.Query<Series>(sql).ToList();
    }
    return _ListaSeries;
   }

public static Series ListarSeriesPorID(int IdSerie)
   {

    using(SqlConnection db =  new  SqlConnection(_connectionString)){
        string sql = "Select *  FROM Series Where IdSerie = @IdSerie";
        return db.QueryFirstOfDefault<Series>;(sql,new{@IdSerie = IdSerie});
    }
    }

private static List<Actores> _ListaActores = new List<Actores>();
   public static List<Actores> ListarActores(int IdSerie)
   {
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "Select * FROM Actores where IdSerie = @IdSerie";
        _ListaActores = db.Query<Actores>(sql,new{@IdSerie = IdSerie}).ToList();
        
    }
    return _ListaActores;
   }

   private static List<Temporadas> _ListaTemporadas = new List<Temporadas>();
   public static List<Temporadas> ListarTemoporadas(int IdSerie)
   {
    using(SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "Select * FROM Temporadas where IdSerie = @IdSerie";
        _ListaTemporadas = db.Query<Temporadas>(sql,new{@IdSerie = IdSerie}).ToList();
        
    }
    return _ListaTemporadas;
   }
}



