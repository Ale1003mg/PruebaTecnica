using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_Vista_Clases.Models
{
   
        public class Personas
        {
            public int id { get; set; }
            public int ID_Usuario { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }

        }
    
}