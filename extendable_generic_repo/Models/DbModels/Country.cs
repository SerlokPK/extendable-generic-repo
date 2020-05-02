using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace extendable_generic_repo.Models.DbModels
{
    public class Country : Entity<int>
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
