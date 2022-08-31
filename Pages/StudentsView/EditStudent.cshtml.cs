using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.StudentsView
{
    public class EditStudentModel : PageModel
    {
        private readonly AppDBContext _context;
        public EditStudentModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

        public async void OnGet(int Id)
        {
            Student = await _context.Student.FindAsync(Id);
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var StudentDB = await _context.Student.FindAsync(Student.Id);

                StudentDB.Name = Student.Name;
                StudentDB.Date_birth = Student.Date_birth;
                StudentDB.number_of_courses = Student.number_of_courses;
                StudentDB.Admission_hour = Student.Admission_hour;
                StudentDB.Admission_date = Student.Admission_date;
                StudentDB.Eggres_date = Student.Eggres_date;
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
