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

        public async Task OnGet()
        {
            Courses = await _context.Course.ToListAsync();
        }

        public async Task OnPostDelete(int Id)
        {

        }
    }
}
