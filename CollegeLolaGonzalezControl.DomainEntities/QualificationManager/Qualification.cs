using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//libreria para notacion de Entity Framework
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLolaGonzalezControl.DomainEntities.QualificationManager
{
    public class Qualification
    {
        #region atributos

        [Key]
        [StringLength(100)]
        public string QualificactionId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public DateTime LastStatusDate { get; set; }

        [Required]
        public int QualificationStatusId { get; set; }
        public virtual QualificationStatus QualificationStatus { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public string Message { get; set; }

        #endregion



    }
}
