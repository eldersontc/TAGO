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
            Tarjeta tarjetaCreado = null;
            string sql = "INSERT INTO Tarjeta VALUES (@Cliente, @Numero, @FechaVencimiento, @CVV); SELECT SCOPE_IDENTITY();";
            int codigo = 0;
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Cliente", tarjeta.Cliente));
                    cmd.Parameters.Add(new SqlParameter("@Numero", tarjeta.Numero));
                    cmd.Parameters.Add(new SqlParameter("@FechaVencimiento", tarjeta.FechaVencimiento));
                    cmd.Parameters.Add(new SqlParameter("@CVV", tarjeta.CVV));
                    codigo = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            tarjetaCreado = Obtener(codigo);
            return tarjetaCreado;
        }

        public Tarjeta Obtener(int codigo)
        {
            Tarjeta tarjetaEncontrado = null;
            string sql = "SELECT * FROM Tarjeta WHERE Codigo = @Codigo";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Codigo", codigo));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            tarjetaEncontrado = new Tarjeta()
                            {
                                Codigo = (int)rd["Codigo"],
                                Cliente = (int)rd["Cliente"],
                                Numero = rd["Numero"].ToString(),
                                FechaVencimiento = rd["FechaVencimiento"].ToString(),
                                CVV = rd["CVV"].ToString()
                            };
                        }
                    }
                }
            }
            return tarjetaEncontrado;
        }

        public Tarjeta Modificar(Tarjeta tarjeta)
        {
            Tarjeta tarjetaModificado = null;
            string sql = "UPDATE Tarjeta SET Numero = @Numero, FechaVencimiento = @FechaVencimiento, CVV = @CVV WHERE Codigo = @Codigo";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Codigo", tarjeta.Codigo));
                    cmd.Parameters.Add(new SqlParameter("@Numero", tarjeta.Numero));
                    cmd.Parameters.Add(new SqlParameter("@FechaVencimiento", tarjeta.FechaVencimiento));
                    cmd.Parameters.Add(new SqlParameter("@CVV", tarjeta.CVV));
                    cmd.ExecuteNonQuery();
                }
            }
            tarjetaModificado = Obtener(tarjeta.Codigo);
            return tarjetaModificado;
        }

        public int Eliminar(int codigo)
        {
            string sql = "DELETE Tarjeta WHERE Codigo = @Codigo";
            int filasAfectadas = 0;
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Codigo", codigo));
                    filasAfectadas = cmd.ExecuteNonQuery();
                }
            }
            return filasAfectadas;
        }
    }
}