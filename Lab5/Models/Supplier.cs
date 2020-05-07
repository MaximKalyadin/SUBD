using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab5.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required]
        public string Name_Organization { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int Phone_Number { get; set; }
        [ForeignKey("SupplierId")]
        public virtual List<Material> Material { get; set; }
    }
}
