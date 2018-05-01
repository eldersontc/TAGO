using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TAGO_VISANET.Domino;

namespace TAGO_VISANET.Persistencia
{
    public class OperacionesTarjetaDAO
    {
        private OperacionesTarjeta OperacionesTarjeta { get; set; }

        public OperacionesTarjetaDAO(OperacionesTarjeta objOperacion)
        {
            this.OperacionesTarjeta = objOperacion;
        }

        public int Insertar()
        {
            this.OperacionesTarjeta.IdOperacion = DataAccess.getInstance().ExecuteStoreProcedureInsertUpdateDelete("Usp_Botica_Tb_OperacionesTarjeta_Insert",
                this.OperacionesTarjeta.Numero,
                this.OperacionesTarjeta.Vencimiento,
                this.OperacionesTarjeta.CodigoVerificacion,
                this.OperacionesTarjeta.Nombre,
                this.OperacionesTarjeta.Apellido,
                this.OperacionesTarjeta.CorreoElectronico,
                this.OperacionesTarjeta.ImporteOperacion);
            return this.OperacionesTarjeta.IdOperacion;
        }
    }
}