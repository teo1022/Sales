using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "El Campo Es {0} Obligatorio")]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public State? State { get; set; }

        public int StateId { get; set; }

    }
}
