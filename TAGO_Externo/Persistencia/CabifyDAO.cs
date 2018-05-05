using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TAGO_Externo.Dominio;

namespace TAGO_Externo.Persistencia
{
    public class CabifyDAO
    {
        //Conexion a DB_TAXI_EXTERNO
        private string cdc = "Data Source=(local);Initial Catalog=DB_TAXI_EXTERNO;Integrated Security=SSPI;";


        //OPERACIONES PARA CABIFY CHOFER
        public CabifyChofer ObtenerCabifyChofer(string Codigo)
        {
            CabifyChofer c_Encontrado = null;
            string sql = "SELECT Codigo, Nombres, Apellidos, Celular, Reputacion, CONVERT(VARCHAR(10), fecharegistro, 103) as 'FechaRegistro', AutoPlaca, AutoMarca, AutoModelo FROM CabifyChofer WHERE Codigo=@codigo";
            using (SqlConnection conexion = new SqlConnection(cdc))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@codigo", Codigo));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            c_Encontrado = new CabifyChofer()
                            {
                                codigo = (string)resultado["Codigo"],
                                nombres = (string)resultado["Nombres"],
                                apellidos = (string)resultado["Apellidos"],
                                celular = (string)resultado["Celular"],
                                reputacion = (int)resultado["Reputacion"],
                                fecharegistro = Convert.ToDateTime(resultado["FechaRegistro"]),
                                autoplaca = (string)resultado["AutoPlaca"],
                                automarca = (string)resultado["AutoMarca"],
                                automodelo = (string)resultado["AutoModelo"]
                            };
                        }
                    }
                }
                return c_Encontrado;
            }
        }

        public List<CabifyChofer> ListarCabifyChoferes()
        {
            List<CabifyChofer> c_Encontrados = new List<CabifyChofer>();
            CabifyChofer c_Encontrado = null;
            string sql =
                "SELECT Codigo, Nombres, Apellidos, Celular, Reputacion, CONVERT(VARCHAR(10), fecharegistro, 103) as 'FechaRegistro', AutoPlaca, AutoMarca, AutoModelo FROM CabifyChofer ";
            using (SqlConnection conexion = new SqlConnection(cdc))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            c_Encontrado = new CabifyChofer()
                            {
                                codigo = (string)resultado["Codigo"],
                                nombres = (string)resultado["Nombres"],
                                apellidos = (string)resultado["Apellidos"],
                                celular = (string)resultado["Celular"],
                                reputacion = (int)resultado["Reputacion"],
                                fecharegistro = Convert.ToDateTime(resultado["FechaRegistro"]),
                                autoplaca = (string)resultado["AutoPlaca"],
                                automarca = (string)resultado["AutoMarca"],
                                automodelo = (string)resultado["AutoModelo"]
                            };
                            c_Encontrados.Add(c_Encontrado);
                        }
                    }
                }
                return c_Encontrados;
            }
        }

        //OPERACIONES PARA CABIFY DISPONIBLE

        public CabifyDisponible ObtenerCabifyDisponible(string AutoPlaca)
        {
            CabifyDisponible d_Encontrado = null;
            string sql = "SELECT  AutoPlaca, TiempoLlegada, TiempoViaje, Monto FROM CabifyDisponible WHERE AutoPlaca=@AutoPlaca";
            using (SqlConnection conexion = new SqlConnection(cdc))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@AutoPlaca", AutoPlaca));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            d_Encontrado = new CabifyDisponible()
                            {
                                AutoPlaca = (string)resultado["AutoPlaca"],
                                TiempoLlegada = (TimeSpan)resultado["TiempoLlegada"],
                                TiempoViaje = (TimeSpan)resultado["TiempoViaje"],
                                Monto = (string)resultado["Monto"]

                            };
                        }
                    }
                }
                return d_Encontrado;
            }
        }

        public List<CabifyDisponible> ListarCabifyDisponibles(string OLatitud, string OLongitud, string DLatitud, string DLongitud)
        {
            List<CabifyDisponible> d_Encontrados = new List<CabifyDisponible>();
            CabifyDisponible d_Encontrado = null;
            string sql = "SELECT  AutoPlaca, TiempoLlegada, TiempoViaje, Monto, OLatitud, OLongitud, DLatitud, DLongitud FROM CabifyDisponible WHERE OLatitud = @OLatitud and OLongitud = @OLongitud and DLatitud = @DLatitud and  DLongitud = @DLongitud";
            using (SqlConnection conexion = new SqlConnection(cdc))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@OLatitud", OLatitud));
                    comando.Parameters.Add(new SqlParameter("@OLongitud", OLongitud));
                    comando.Parameters.Add(new SqlParameter("@DLatitud", DLatitud));
                    comando.Parameters.Add(new SqlParameter("@DLongitud", DLongitud));
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            d_Encontrado = new CabifyDisponible()
                            {
                                AutoPlaca = (string)resultado["AutoPlaca"],
                                TiempoLlegada = (TimeSpan)resultado["TiempoLlegada"],
                                TiempoViaje = (TimeSpan)resultado["TiempoViaje"],
                                Monto = (string)resultado["Monto"],
                                OLatitud = (string)resultado["OLatitud"],
                                OLongitud = (string)resultado["OLongitud"],
                                DLatitud = (string)resultado["DLatitud"],
                                DLongitud = (string)resultado["DLongitud"]
                            };
                            d_Encontrados.Add(d_Encontrado);
                        }
                    }
                }
                return d_Encontrados;
            }
        }

    }
}