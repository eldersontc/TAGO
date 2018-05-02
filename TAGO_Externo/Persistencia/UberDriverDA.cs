using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TAGO_Externo.Dominio;

namespace TAGO_Externo.Persistencia
{
    public class UberDriverDA
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["TAGO"].ConnectionString;

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
    }
}