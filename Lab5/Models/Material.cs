using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab5.Models
{
    public class Material
    {
        public int Id { get; set; }
        [Required]
        public string Name_Material { get; set; }
        [Required]
        public int Sum { get; set; }
        public virtual Order Order { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
