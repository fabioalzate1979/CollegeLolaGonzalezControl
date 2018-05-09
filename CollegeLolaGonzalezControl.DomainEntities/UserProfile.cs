using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLolaGonzalezControl.DomainEntities
{
    public class UserProfile
    {
        [Key]
        public int UserProfileId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
