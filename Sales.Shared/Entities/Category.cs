using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Display(Name = "Category")]
        [Required(ErrorMessage = "El Campo {0} es Obligatorio")]
        public string Name { get; set; } = null!;

    }
}
