using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace extendable_generic_repo.Models.DbModels
{
    public class User : AuditableEntity<int>
    {
        public int CountryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string State { get; set; }


        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
