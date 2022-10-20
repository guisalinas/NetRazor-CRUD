using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.StudentsView
{
    public class DeleteStudentPageModel : PageModel
    {
        private readonly AppDBContext _context;
        public DeleteStudentPageModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }

        [TempData]
        public string Message { get; set; }

        public async void OnGet(int Id)
        {
            Student = await _context.Student.FindAsync(Id);
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var StudentDelete = await _context.Student.FindAsync(Student.Id);

                if (StudentDelete == null)
                {
                    return NotFound();
                }

                StudentDelete.is_eliminated = true;
                
                await _context.SaveChangesAsync();
                Message = "El registro se eliminó correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
