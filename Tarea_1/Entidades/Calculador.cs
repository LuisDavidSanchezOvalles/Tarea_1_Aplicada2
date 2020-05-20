using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_1.Entidades
{
    public class Calculador
    {
        [Required(ErrorMessage = "No debe de Permanecer Vacío")]
        public int Numero1 { get; set; }

        [Required(ErrorMessage = "No debe de Permanecer Vacío")]
        public int Numero2 { get; set; }

        public int Suma { get; set; }
        public int Resta { get; set; }
        public int Multiplicacion { get; set; }

        public Calculador()
        {
            Numero1 = 0;
            Numero2 = 0;
            Suma = 0;
            Resta = 0;
            Multiplicacion = 0;
        }
    }
}
