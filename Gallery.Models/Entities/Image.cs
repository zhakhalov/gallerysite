using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Entities.Entities
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(64)]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}
