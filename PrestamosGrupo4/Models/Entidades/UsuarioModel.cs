using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PrestamosGrupo4.Models.Entidades
{
    public class UsuarioModel
    {
        public int idUsuario { get; set; }

        [Display(Name = "Nombres")]
        public string? nombres { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [PasswordPropertyText]
        [Compare("passwordConfirm")]
        [RegularExpression("^(?=\\w*\\d)(?=\\w*[A - Z])(?=\\w*[a - z])\\S{8,16}$}", ErrorMessage = "La contraseña debe tener al entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula y al menos una mayúscula.")]
        public string? password { get; set; }

        [Required]
        [Display(Name = "Confirme contraseña")]
        [PasswordPropertyText]
        public string? passwordConfirm { get; set; }

        [Display(Name = "Fecha de registro")]
        public DateTime fechaRegistro { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime fechaNacimiento { get; set; }

        public int estado { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string? email { get; set; }

        [Required]
        [Display(Name = "Apellido paterno")]
        public string? aPaterno { get; set; }

        [Required]
        [Display(Name = "Apellido materno")]
        public string? aMaterno { get; set; }

        [Required]
        [Display(Name = "DNI")]
        [RegularExpression("[0-9]{8}", ErrorMessage = "Ingrese un DNI válido")]
        public string? numeroDocumento { get; set; }

        [Required]
        [Display(Name = "Teléfono")]
        [RegularExpression("9[0-9]{8}", ErrorMessage = "Ingrese un número de celular válido")]
        public string? telefono { get; set; }

    }
}
