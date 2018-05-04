using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TAGO_VISANET.Domino;

namespace TAGO_VISANET.Persistencia
{
    public class TarjetaDAO
    {
        private Tarjeta Tarjeta { get; set; }

        public TarjetaDAO(Tarjeta objTarjeta)
        {
            this.Tarjeta = objTarjeta;
        }

        public Tarjeta Seleccionar()
        {
            DataTable objDataTable = DataAccess.getInstance().ExecuteStoreProcedureSelect("Usp_Botica_Tb_Tarjeta_Select", this.Tarjeta.Numero);
            this.Tarjeta = new Tarjeta();
            foreach (DataRow objDataRow in objDataTable.Rows)
            {
                this.Tarjeta.Numero = (string)objDataRow["Numero"];
                this.Tarjeta.Vencimiento = (string)objDataRow["Vencimiento"];
                this.Tarjeta.CodigoVerificacion = (string)objDataRow["CodigoVerificacion"];
                this.Tarjeta.Nombre = (string)objDataRow["Nombre"];
                this.Tarjeta.Apellido = (string)objDataRow["Apellido"];
                this.Tarjeta.CorreoElectronico = (string)objDataRow["CorreoElectronico"];
                this.Tarjeta.ImporteSaldo = (decimal)objDataRow["ImporteSaldo"];
            }
            return this.Tarjeta;
        }
    }
}