﻿using System.ComponentModel.DataAnnotations;

namespace PsychologyTest.ViewModels
{
    public class RootEditUserViewModel
    {
        [StringLength(25, MinimumLength = 4, ErrorMessage = "El nombre debe ser de almenos 4 caracteres y maximo 25")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [EmailAddress]
        [Display(Name = "Correo electronico")]
        public string Email { get; set; }

        [Display(Name = "Tipo de documento")]
        public string TipoDocId { get; set; }

        [StringLength(25, MinimumLength = 4, ErrorMessage = "La identificacion no debe ser menor de 4 caracteres ni mayor de 25")]
        [Display(Name = "Numero de documento")]
        public string DocId { get; set; }

        public string Direccion { get; set; }

        [Display(Name = "Numero de telefono")]
        public string PhoneNumber { get; set; }

        public string Genero { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Rol")]
        public string RolSolicitado { get; set; }
    }
}
