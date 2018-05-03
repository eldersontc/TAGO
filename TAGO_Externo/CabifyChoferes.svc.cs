using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TAGO_Externo.Persistencia;
using TAGO_Externo.Dominio;

namespace TAGO_Externo
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CabifyChoferes" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CabifyChoferes.svc o CabifyChoferes.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CabifyChoferes : ICabifyChoferes
    {
        private CabifyDAO cabifyDAO = new CabifyDAO();


        public CabifyChofer ObtenerCabifyChofer(string Codigo)
        {
            return cabifyDAO.ObtenerCabifyChofer(Codigo);
        }

        public List<CabifyChofer> ListarCabifyChoferes()
        {
            return cabifyDAO.ListarCabifyChoferes();
        }


    }
}