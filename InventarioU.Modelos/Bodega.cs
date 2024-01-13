using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioU.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; init; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60, ErrorMessage ="Nombre debe ser Maximo 60 caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripción es Requerido")]
        [MaxLength(100, ErrorMessage = "Descripción debe ser Maximo 100 caracteres")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }


    }
}
