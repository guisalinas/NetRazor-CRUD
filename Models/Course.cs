using System.ComponentModel.DataAnnotations;

namespace CRUD_NetRazor.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Nombre")]
        public string Course_name { get; set; } = string.Empty;
        [Display(Name = "Cantidad de Clases")]
        public int Number_of_classes { get; set; }
        [Display(Name = "Precio")]
        [Required]
        public double Price { get; set; }
        [Display(Name = "Fecha de Creación")]
        public DateTime Creation_date { get; set; }

    }
}
