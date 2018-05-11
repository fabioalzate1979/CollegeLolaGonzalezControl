using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollegeLolaGonzalezControl.Models.Security
{
    public class LoginInputModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, ErrorMessage = "El campo {0} no puede superar 50 caracteres")]
        [Display(Name = "Usuario de red")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Clave de red")]
        public string Password { get; set; }
    }
}