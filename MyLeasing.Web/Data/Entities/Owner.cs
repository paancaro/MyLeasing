using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "El campo {0} no debe tener mas de {1} caracteres.")]
        [Display(Name = "Documento")]
        public string Document { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Primer Nombre")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Display(Name = "Telefono Fijo")]
        public string FixedPhone { get; set; }

        [MaxLength(20)]
        [Display(Name = "Telefono Celular")]
        public string CellPhone { get; set; }

        [MaxLength(200)]
        [Display(Name = "Direccion")]
        public string Address { get; set; }
        
        [Display(Name = "Nombre Completo")]
   
        public string FullName => $"{FirstName} {LastName}";
        [Display(Name = "Nombre Completo")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }


    }
}
