using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroLibro.Entidades
{
    public class Libros //public para que sea visible
    {
    [Key]
        public int LibrosId { get; set; }
        public string Descripcion { get; set; }
        public string Siglas { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public Libros()
        {
            LibrosId = 0;
            Descripcion = string.Empty;
            Siglas = string.Empty;
            Tipo = string.Empty;
            Fecha = DateTime.Now;
        }
    }
}
