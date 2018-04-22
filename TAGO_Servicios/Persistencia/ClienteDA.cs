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
            string sql = "INSERT INTO Cliente VALUES (@DNI, @Nombres, @Apellidos, @Celular, @Email, @Password)";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@DNI", cliente.DNI));
                    cmd.Parameters.Add(new SqlParameter("@Nombres", cliente.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", cliente.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Celular", cliente.Celular));
                    cmd.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", cliente.Password));
                    cmd.ExecuteNonQuery();
                }
            }
            clienteCreado = Obtener(cliente.DNI);
            return clienteCreado;
        }

        public Cliente Obtener(string dni)
        {
            Cliente clienteEncontrado = null;
            string sql = "SELECT * FROM Cliente WHERE DNI = @DNI";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@DNI", dni));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                DNI = rd["DNI"].ToString(),
                                Nombres = rd["Nombres"].ToString(),
                                Apellidos = rd["Apellidos"].ToString(),
                                Celular = rd["Celular"].ToString(),
                                Email = rd["Email"].ToString(),
                                Password = rd["Password"].ToString()
                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        public Cliente ObtenerxEmail(string email)
        {
            Cliente clienteEncontrado = null;
            string sql = "SELECT * FROM Cliente WHERE Email = @Email";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@Email", email));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            clienteEncontrado = new Cliente()
                            {
                                DNI = rd["DNI"].ToString(),
                                Nombres = rd["Nombres"].ToString(),
                                Apellidos = rd["Apellidos"].ToString(),
                                Celular = rd["Celular"].ToString(),
                                Email = rd["Email"].ToString(),
                                Password = rd["Password"].ToString()
                            };
                        }
                    }
                }
            }
            return clienteEncontrado;
        }

        public Cliente Modificar(Cliente cliente)
        {
            Cliente clienteModificado = null;
            string sql = "UPDATE Cliente SET Nombres = @Nombres, Apellidos = @Apellidos, Celular = @Celular, Email = @Email, Password = @Password WHERE DNI = @DNI";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@DNI", cliente.DNI));
                    cmd.Parameters.Add(new SqlParameter("@Nombres", cliente.Nombres));
                    cmd.Parameters.Add(new SqlParameter("@Apellidos", cliente.Apellidos));
                    cmd.Parameters.Add(new SqlParameter("@Celular", cliente.Celular));
                    cmd.Parameters.Add(new SqlParameter("@Email", cliente.Email));
                    cmd.Parameters.Add(new SqlParameter("@Password", cliente.Password));
                    cmd.ExecuteNonQuery();
                }
            }
            clienteModificado = Obtener(cliente.DNI);
            return clienteModificado;
        }
    }
}