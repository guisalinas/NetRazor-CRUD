using System.ComponentModel.DataAnnotations;

namespace CRUD_NetRazor.Models
{
    public class Student
    {   
        [Key, Display(Name = "Clave")]
        public int Id { get; set; }

        [MaxLength(100), Required, Display(Name = "Nombre")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50), Required, Display(Name = "Apellido")]
        public string Surname { get; set; } = string.Empty;

        [Required, Display(Name = "Fecha de Nacimiento"), DisplayFormat(DataFormatString = "{0: dd/mm/yyyy }")]
        public DateTime Date_birth { get; set; }
        public int number_of_courses { get; set; }

        [Required, Display(Name = "Fecha de Ingreso"), DisplayFormat(DataFormatString = "{0: yyyy-mm-dd }")]
        public DateTime Admission_date { get; set; }

        [Required, Display(Name = "Hora de ingreso"), DisplayFormat(DataFormatString = "{0: hh:mm:ss }")]
        public DateTime Admission_hour { get; set; }

        [Display(Name ="Fecha de Egreso"), DisplayFormat(DataFormatString = "{0: yyyy/mm/dd }")]
        public DateTime Eggres_date { get; set; }


    }
}
