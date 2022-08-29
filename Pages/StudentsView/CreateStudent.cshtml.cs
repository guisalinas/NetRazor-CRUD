using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.StudentsView
{
    public class CreateStudentModel : PageModel
    {
        private readonly AppDBContext _context;

        public CreateStudentModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");

        }
        public void OnGet()
        {
        }
    }
}
