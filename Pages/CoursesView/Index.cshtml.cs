using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NetRazor.Pages.CoursesView
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;

        public IndexModel(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> Courses { get; set; } 

        [TempData]
        public string Message { get; set; }

        public async Task OnGet()
        {
            Courses = await _context.Course.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int Id)
        {
            if (ModelState.IsValid)
            {
                var CourseDelete = await _context.Course.FindAsync(Id);
                if (CourseDelete == null)
                {
                    return NotFound();
                }
                _context.Course.Remove(CourseDelete);
                await _context.SaveChangesAsync();
                Message = "El registro se eliminó correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
