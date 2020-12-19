using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
        //getter y setter (getter devolver un valor) setter cambiar el valor del campo
        public class Materia
        {
            public String CodMateria { get; set; }
            public String NombreMateria { get; set; }
            public int Nivel { get; set; }
            public String Carrera { get; set; }
            public DateTime FechaCreacion { get; set; }
        }
    
}
