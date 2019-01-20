using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class RecordFeature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int RecordId { get; set; }

        public int FeatureId { get; set; }


        public virtual Record Record { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
