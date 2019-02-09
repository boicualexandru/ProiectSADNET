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
        
        public int? ModelId { get; set; }

        public DateTime ManufactureDate { get; set; }

        [Required]
        public int Distance { get; set; }

        public EmissionStandard? EmissionStandard { get; set; }

        public FuelType? Fuel { get; set; }

        public GearBoxType? GearBox { get; set; }

        public int? EngineSize { get; set; }

        public int? Power { get; set; }

        public BodyType? Body { get; set; }

        public string Transmission { get; set; }

        public int? DoorsNo { get; set; }

        public string Color { get; set; }

        public string CountryOfOrigin { get; set; }

        public bool? Registered { get; set; }

        public ConditionType? Condition { get; set; }

        public SellerType? Seller { get; set; }

        public string VIN { get; set; }

        [Required]
        public int Price { get; set; }


        public virtual Model Model { get; set; }
        public virtual ICollection<RecordFeature> RecordsFeatures { get; set; }
    }
}
