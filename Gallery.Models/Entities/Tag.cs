using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Entities.Entities
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        [Required]
        [MaxLength(32)]
        public string Title { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}
