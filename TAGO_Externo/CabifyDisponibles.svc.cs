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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CabifyDisponibles" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CabifyDisponibles.svc o CabifyDisponibles.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CabifyDisponibles : ICabifyDisponibles
    {
        private CabifyDAO cabifyDAO = new CabifyDAO();


        public CabifyDisponible ObtenerCabifyDisponible(string AutoPlaca)
        {
            return cabifyDAO.ObtenerCabifyDisponible(AutoPlaca);
        }

        public List<CabifyDisponible> ListarCabifyDisponibles(string OLatitud, string OLongitud, string DLatitud, string DLongitud)
        {
            return cabifyDAO.ListarCabifyDisponibles(OLatitud, OLongitud, DLatitud, DLongitud);
        }
    }
}
