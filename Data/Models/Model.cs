using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Model
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int BrandId { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }


        public virtual Brand Brand { get; set; }
        public virtual ICollection<Record> Records { get; set; }
    }
}
