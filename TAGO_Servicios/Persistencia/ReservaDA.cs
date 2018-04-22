using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TAGO_Servicios.Dominio;
using TAGO_Servicios.Utilitarios;

namespace TAGO_Servicios.Persistencia
{
    public class ReservaDA
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["TAGO"].ConnectionString;

        public Reserva Crear(Reserva entidad)
        {
            Reserva entidadCreada = null;
            int iddevuelto = 0;
            string sql = "INSERT INTO Reserva OUTPUT INSERTED.IdReserva VALUES (@IdCliente, @FechaRecojoCliente, @Origen, @Destino, @Importe, @IdEstadoReserva, @FechaRegistroReserva, @Placa)";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@IdCliente", entidad.IdCliente));
                    cmd.Parameters.Add(new SqlParameter("@FechaRecojoCliente", entidad.FechaRecojoCliente));
                    cmd.Parameters.Add(new SqlParameter("@Origen", entidad.Origen));
                    cmd.Parameters.Add(new SqlParameter("@Destino", entidad.Destino));
                    cmd.Parameters.Add(new SqlParameter("@Importe", entidad.Importe));
                    cmd.Parameters.Add(new SqlParameter("@IdEstadoReserva", entidad.IdEstadoReserva));
                    cmd.Parameters.Add(new SqlParameter("@FechaRegistroReserva", entidad.FechaRegistroReserva));
                    cmd.Parameters.Add(new SqlParameter("@Placa", entidad.Placa));
                    iddevuelto = (int)cmd.ExecuteScalar();
                    cn.Close();
                    
                }
            }

            entidadCreada = Obtener(iddevuelto);
            Cliente cliente = new ClienteDA().Obtener(entidadCreada.IdCliente.ToString());
            SenderSMS.EnviarSMS(cliente.Celular,string.Format("Estimado cliente {0}, su reserva ha sido registrada con exito",cliente.Nombres));
            return entidadCreada;
        }

        public Reserva Obtener(int id)
        {
            Reserva entidadEncontrado = null;
            string sql = "SELECT * FROM Reserva WHERE IdReserva = @IdReserva";
            using (SqlConnection cn = new SqlConnection(cadenaConexion))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.Add(new SqlParameter("@IdReserva", id));
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            entidadEncontrado = new Reserva()
                            {
                                IdReserva=id,
                                IdCliente = (int)rd["IdCliente"],
                                FechaRecojoCliente = rd["FechaRecojoCliente"].ToString(),
                                Origen = rd["Origen"].ToString(),
                                Destino = rd["Destino"].ToString(),
                                Importe = (decimal)rd["Importe"],
                                IdEstadoReserva = (int)rd["IdEstadoReserva"],
                                FechaRegistroReserva = rd["FechaRegistroReserva"].ToString(),
                                Placa = rd["Placa"].ToString()
                            };
                        }
                    }
                }
            }
            return entidadEncontrado;
        }

        //public Reserva Modificar(Reserva entidad)
        //{
        //    Reserva clienteModificado = null;
        //    string sql = "UPDATE Reserva SET Nombres = @Nombres, Apellidos = @Apellidos, Celular = @Celular, Email = @Email, Password = @Password WHERE DNI = @DNI";
        //    using (SqlConnection cn = new SqlConnection(cadenaConexion))
        //    {
        //        cn.Open();
        //        using (SqlCommand cmd = new SqlCommand(sql, cn))
        //        {
        //            cmd.Parameters.Add(new SqlParameter("@DNI", entidad.DNI));
        //            cmd.Parameters.Add(new SqlParameter("@Nombres", entidad.Nombres));
        //            cmd.Parameters.Add(new SqlParameter("@Apellidos", entidad.Apellidos));
        //            cmd.Parameters.Add(new SqlParameter("@Celular", entidad.Celular));
        //            cmd.Parameters.Add(new SqlParameter("@Email", entidad.Email));
        //            cmd.Parameters.Add(new SqlParameter("@Password", entidad.Password));
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    clienteModificado = Obtener(entidad.DNI);
        //    return clienteModificado;
        //}

    }
}