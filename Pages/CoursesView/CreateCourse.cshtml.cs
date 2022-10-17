using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.CoursesView
{
    public class CreateCourseModel : PageModel
    {
        private readonly AppDBContext _context;

        public CreateCourseModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Course Course { get; set; }
        [TempData]
        public string Message { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Course.Creation_date = DateTime.Now;

            _context.Add(Course);
            await _context.SaveChangesAsync();
            Message = "Registro creado correctamente";
            return RedirectToPage("Index");

        }

        public void OnGet()
        {

        }
    }
}
