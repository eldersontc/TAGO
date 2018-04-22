using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TAGO_Servicios.Dominio;

namespace TAGO_Servicios.Persistencia
{
    public class TarjetaDA
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["TAGO"].ConnectionString;

        public Tarjeta Crear(Tarjeta tarjeta)
        {
            Tarjeta tarjetaCreada = null;
            string sql = "INSERT INTO Tarjeta VALUES (@Cliente, @Numero, @FechaVencimiento, @CVV)";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Cliente", tarjeta.Cliente));
                    cmd.Parameters.Add(new SqlParameter("@Numero", tarjeta.Numero));
                    cmd.Parameters.Add(new SqlParameter("@FechaVencimiento", tarjeta.FechaVencimiento));
                    cmd.Parameters.Add(new SqlParameter("@CVV", tarjeta.CVV));
                    cmd.ExecuteNonQuery();
                }
            }
            tarjetaCreada = Obtener(tarjeta.Numero);
            return tarjetaCreada;
        }

        public Tarjeta Obtener(string numero)
        {
            Tarjeta tarjetaEncontrada = null;
            string sql = "SELECT * FROM Tarjeta WHERE Numero = @Numero";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Numero", numero));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            tarjetaEncontrada = new Tarjeta()
                            {
                                Cliente = rd["Cliente"].ToString(),
                                Numero = rd["Numero"].ToString(),
                                FechaVencimiento = rd["FechaVencimiento"].ToString(),
                                CVV = rd["CVV"].ToString()
                            };
                        }
                    }
                }
            }
            return tarjetaEncontrada;
        }

        public List<Tarjeta> ListarxCliente(string cliente)
        {
            List<Tarjeta> tarjetasEncontradas = new List<Tarjeta>();
            string sql = "SELECT * FROM Tarjeta WHERE Cliente = @Cliente";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Cliente", cliente));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            tarjetasEncontradas.Add(new Tarjeta()
                            {
                                Numero = rd["Numero"].ToString(),
                                FechaVencimiento = rd["FechaVencimiento"].ToString(),
                                CVV = rd["CVV"].ToString()
                            });
                        }
                    }
                }
            }
            return tarjetasEncontradas;
        }

        public Tarjeta Modificar(Tarjeta tarjeta)
        {
            Tarjeta tarjetaModificado = null;
            string sql = "UPDATE Tarjeta SET FechaVencimiento = @FechaVencimiento, CVV = @CVV WHERE Numero = @Numero";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Numero", tarjeta.Numero));
                    cmd.Parameters.Add(new SqlParameter("@FechaVencimiento", tarjeta.FechaVencimiento));
                    cmd.Parameters.Add(new SqlParameter("@CVV", tarjeta.CVV));
                    cmd.ExecuteNonQuery();
                }
            }
            tarjetaModificado = Obtener(tarjeta.Numero);
            return tarjetaModificado;
        }

        public int Eliminar(string numero)
        {
            string sql = "DELETE Tarjeta WHERE Numero = @Numero";
            int filasAfectadas = 0;
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Numero", numero));
                    filasAfectadas = cmd.ExecuteNonQuery();
                }
            }
            return filasAfectadas;
        }
    }
}