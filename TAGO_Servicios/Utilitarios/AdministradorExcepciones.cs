﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TAGO_Servicios.Utilitarios
{
    [DataContract]
    public class AdministradorExcepciones
    {        
            [DataMember]
            public string Codigo { get; set; }

            [DataMember]
            public string Descripcion { get; set; }
     
    }
}