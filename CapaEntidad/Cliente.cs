﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
        public  class Cliente
    {
        public int idCliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string correo { get; set; }
        public string Telefono { get; set; }
        public bool estado { get; set; }
        public string Fecha_Registro { get; set; }
    }
}
