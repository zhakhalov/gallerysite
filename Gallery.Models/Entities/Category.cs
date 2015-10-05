using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Entities.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public string Slug { get; set; }
        public string ImagePath { get; set; }
        public string ImageUrl { get; set; }
    }
}
