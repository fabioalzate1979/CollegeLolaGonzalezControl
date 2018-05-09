using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLolaGonzalezControl.DomainEntities.QualificationManager
{
    public class User
    {

        #region Atributos

        [Key]
        [StringLength(100)]
        public string UserId { get; set; } 

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [Required]
        public int UserProfileId { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        #endregion
    }
}
