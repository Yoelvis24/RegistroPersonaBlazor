using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroBlazor.Models
{
    public class Prestamos
    {
       
        [Key]
        public int PrestamoId { get; set; }
        public int PersonaId { get; set; } 
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
        
        public Prestamos()
        {
            PrestamoId = 0;
            PersonaId = 0;
            Fecha = DateTime.Now;
            Concepto = string.Empty;
            Monto = 0;
            Balance = 0;
        }
        public virtual Personas Persona { get; set; }
    }
}
