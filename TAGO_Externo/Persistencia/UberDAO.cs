using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TAGO_Externo.Dominio;

namespace TAGO_Externo.Persistencia
{
    public class UberDAO
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["DB_TAXI_EXTERNO"].ConnectionString;

        //-------------------------------- OPERACIONES PARA UBERDRIVER
        public List<UberDriver> ListTaxiUber()
        {
            List<UberDriver> UbersFound = new List<UberDriver>();
            UberDriver UberFound = null;

            string strCmd = "SELECT * FROM UberDriver";
            using (SqlConnection sqlCnx = new SqlConnection(cadenaConexion))
            {
                sqlCnx.Open();
                using (SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCnx))
                {
                    using (SqlDataReader sqlDR = sqlCmd.ExecuteReader())
                    {
                        while (sqlDR.Read())
                        {
                            UberFound = new UberDriver()
                            {
                                UPlaca = (int)sqlDR["Placa"],
                                UNombres = (string)sqlDR["Nombres"],
                                UApellidos = (string)sqlDR["Apellidos"],
                                UCelular = (int)sqlDR["Celular"],
                                UModeloAuto = (string)sqlDR["ModeloAuto"],
                                UReputacion = (int)sqlDR["Reputacion"],
                                UFechaIngreso = (DateTime)sqlDR["FechaIngreso"]
                            };
                            UbersFound.Add(UberFound);
                        }
                    }
                }
            }
            return UbersFound;
        }
        public UberDriver GetUberDriver(string placa)
        {
            UberDriver UberFound = null;
            string strCmd = "SELECT * FROM UberDriver WHERE Placa = @placa";

            using (SqlConnection sqlCnx = new SqlConnection(cadenaConexion))
            {
                sqlCnx.Open();
                using (SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCnx))
                {
                    sqlCmd.Parameters.Add(new SqlParameter("@placa", placa));
                    using (SqlDataReader sqlDR = sqlCmd.ExecuteReader())
                    {
                        if (sqlDR.Read())
                        {
                            UberFound = new UberDriver()
                            {
                                UPlaca = (int)sqlDR["Placa"],
                                UNombres = (string)sqlDR["Nombres"],
                                UApellidos = (string)sqlDR["Apellidos"],
                                UCelular = (int)sqlDR["Celular"],
                                UModeloAuto = (string)sqlDR["ModeloAuto"],
                                UReputacion = (int)sqlDR["Reputacion"],
                                UFechaIngreso = (DateTime)sqlDR["FechaIngreso"]
                            };
                        }
                    }
                }
            }
            return UberFound;
        }

        //-------------------------------- OPERACIONES PARA UBERAVAILABLE
        public List<UberAvailable> ListTaxiUberAvailable(string OLatitud, string OLongitud, string DLatitud, string DLongitud)
        {
            List<UberAvailable> UbersAvailableFound = new List<UberAvailable>();
            UberAvailable UberAvailableFound = null;

            string strCmd = "SELECT * FROM UberAvailable WHERE OLatitud = @LatitudOrigen and OLongitud = @LongitudOrigen and DLatitud = @LatitudDestino and  DLongitud = @LongitudDestino";
            using (SqlConnection sqlCnx = new SqlConnection(cadenaConexion))
            {
                sqlCnx.Open();
                using (SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCnx))
                {
                    sqlCmd.Parameters.Add(new SqlParameter("@LatitudOrigen", OLatitud));
                    sqlCmd.Parameters.Add(new SqlParameter("@LongitudOrigen", OLongitud));
                    sqlCmd.Parameters.Add(new SqlParameter("@LatitudDestino", DLatitud));
                    sqlCmd.Parameters.Add(new SqlParameter("@LongitudDestino", DLongitud));
                    using (SqlDataReader sqlDR = sqlCmd.ExecuteReader())
                    {
                        while (sqlDR.Read())
                        {
                            UberAvailableFound = new UberAvailable()
                            {
                                UPlaca = (string)sqlDR["Placa"],
                                UMarcaAuto = (string)sqlDR["MarcaAuto"],
                                UColorAuto = (string)sqlDR["ColorAuto"],
                                UTiempoLlegada =(TimeSpan)sqlDR["TiempoLlegada"],
                                UMontoACobrar = (string)sqlDR["MontoACobrar"],
                                UTiempoViaje = (TimeSpan)sqlDR["TiempoViaje"],
                                ULatitudOrigen = (string)sqlDR["LatitudOrigen"],
                                ULongitudOrigen = (string)sqlDR["LongitudOrigen"],
                                ULatitudDestino = (string)sqlDR["LatitudDestino"],
                                ULongitudDestino = (string)sqlDR["LongitudDestino"]
                            };
                            UbersAvailableFound.Add(UberAvailableFound);
                        }
                    }
                }
            }
            return UbersAvailableFound;
        }
        public UberAvailable GetUberDriverAvailable(string placa)
        {
            UberAvailable UberAvailableFound = null;
            string strCmd = "SELECT * FROM UberDriver WHERE Placa = @placa";

            using (SqlConnection sqlCnx = new SqlConnection(cadenaConexion))
            {
                sqlCnx.Open();
                using (SqlCommand sqlCmd = new SqlCommand(strCmd, sqlCnx))
                {
                    sqlCmd.Parameters.Add(new SqlParameter("@placa", placa));
                    using (SqlDataReader sqlDR = sqlCmd.ExecuteReader())
                    {
                        if (sqlDR.Read())
                        {
                            UberAvailableFound = new UberAvailable()
                            {
                                UPlaca = (string)sqlDR["Placa"],
                                UMarcaAuto = (string)sqlDR["MarcaAuto"],
                                UColorAuto = (string)sqlDR["ColorAuto"],
                                UTiempoLlegada = (TimeSpan)sqlDR["TiempoLlegada"],
                                UMontoACobrar = (string)sqlDR["MontoACobrar"],
                                UTiempoViaje = (TimeSpan)sqlDR["TiempoViaje"],
                                ULatitudOrigen = (string)sqlDR["LatitudOrigen"],
                                ULongitudOrigen = (string)sqlDR["LongitudOrigen"],
                                ULatitudDestino = (string)sqlDR["LatitudDestino"],
                                ULongitudDestino = (string)sqlDR["LongitudDestino"]
                            };
                        }
                    }
                }
            }
            return UberAvailableFound;
        }
    }
}
