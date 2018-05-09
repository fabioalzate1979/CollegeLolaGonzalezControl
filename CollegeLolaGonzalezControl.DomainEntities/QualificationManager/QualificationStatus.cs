using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeLolaGonzalezControl.DomainEntities.QualificationManager
{
    public class QualificationStatus
    {

        #region Atributos
        [Key]
        public int QualificationStatusId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } 
        #endregion
    }
}
