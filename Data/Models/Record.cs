using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Record
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int ModelId { get; set; }

        public DateTime ManufactureDate { get; set; }

        [Required]
        public int Distance { get; set; }

        public EmissionStandard EmissionStandard { get; set; }

        public FuelType Fuel { get; set; }

        public GearBoxType GearBox { get; set; }

        public int EngineSize { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }


        public virtual Model Model { get; set; }
        public virtual ICollection<RecordFeature> RecordsFeatures { get; set; }
    }
}
