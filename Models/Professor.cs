using System.ComponentModel.DataAnnotations;

namespace CRUD_NetRazor.Models
{
    public class Professor
    {
        [Key, Display(Name = "Clave")]
        public int Id { get; set; }

        [MaxLength(100), Required, Display(Name = "Nombre")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50), Required, Display(Name = "Apellido")]
        public string Surname { get; set; } = string.Empty;

        [Required, Display(Name = "Fecha de Nacimiento"), DisplayFormat(DataFormatString ="{0: dd-mm-yyyy }")]
        public DateTime Date_birth { get; set; }

        [Required, Display(Name = "Especialidad")]
        public int Specialty { get; set; }

        [Required, Display(Name = "Fecha de Ingreso"), DisplayFormat(DataFormatString = "{0: yyyy-mm-dd }")]
        public DateTime Admission_date { get; set; }

        [Required]
        public bool is_eliminated { get; set; }
    }
}
