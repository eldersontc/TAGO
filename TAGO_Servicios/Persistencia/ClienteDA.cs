using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TAGO_Servicios.Dominio;

namespace TAGO_Servicios.Persistencia
{
    public class ClienteDA
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["TAGO"].ConnectionString;

        public Cliente Crear(Cliente cliente)
        {
            Cliente clienteCreado = null;
            string sql = "INSERT INTO Cliente VALUES (@Nombres, @Apellidos, @Celular, @Email, @Password); SELECT SCOPE_IDENTITY();";
            int Codigo = 0;
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Nombres", cliente.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", cliente.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Celular", cliente.Celular));
                    cmd.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", cliente.Password));
                    Codigo = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            clienteCreado = Obtener("Codigo", Codigo);
            return clienteCreado;
        }

        public Cliente Obtener(string campo, object valor)
        {
            Cliente clienteEncontrado = null;
            string sql = string.Format("SELECT * FROM Cliente WHERE {0} = '{1}'", campo, valor);
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                Codigo = (int)rd["Codigo"],
                                Nombres = rd["Nombres"].ToString(),
                                Apellidos = rd["Apellidos"].ToString(),
                                Celular = rd["Celular"].ToString(),
                                Email = rd["Email"].ToString(),
                                Password = rd["Password"].ToString()
                            };
                        }
                    }
                }

                if (clienteEncontrado != null)
                {

                    string sqlTarjeta = "SELECT * FROM Tarjeta WHERE Cliente = @Cliente";

                    clienteEncontrado.Tarjetas = new List<Tarjeta>();

                    using (SqlCommand cmd = new SqlCommand(sqlTarjeta, cn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Cliente", clienteEncontrado.Codigo));
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                clienteEncontrado.Tarjetas.Add(new Tarjeta()
                                {
                                    Codigo = (int)rd["Codigo"],
                                    Numero = rd["Numero"].ToString(),
                                    FechaVencimiento = rd["FechaVencimiento"].ToString(),
                                    CVV = rd["CVV"].ToString()
                                });
                            }
                        }
                    }

                }
            }
            return clienteEncontrado;
        }

        public Cliente Modificar(Cliente cliente)
        {
            Cliente clienteModificado = null;
            string sql = "UPDATE Cliente SET Nombres = @Nombres, Apellidos = @Apellidos, Celular = @Celular, Email = @Email, Password = @Password WHERE Codigo = @Codigo";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Codigo", cliente.Codigo));
                    cmd.Parameters.Add(new SqlParameter("@Nombres", cliente.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", cliente.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Celular", cliente.Celular));
                    cmd.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", cliente.Password));
                    cmd.ExecuteNonQuery();
                }
            }
            clienteModificado = Obtener("Codigo", cliente.Codigo);
            return clienteModificado;
        }
    }
}