﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VgSalud.Models
{
    public class E_Carnet_Sanitario : E_Citas
    {

        public int NroCarnet { get; set; }

        public string Manipulador { get; set; }

        public int TipoCarnet { get; set; }

        public string Campana { get; set; }
        public DateTime FecRecojo { get; set; }
        
        public string EstadoCarnet { get; set; }
        public string Empresa { get; set; }
        public string FotoCarnet { get; set; }
        public string QR { get; set; }
        public DateTime FecVencimiento { get; set; }
        public string Carnet { get; set; }





    }
}