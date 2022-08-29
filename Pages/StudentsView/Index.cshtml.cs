using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NetRazor.Pages.StudentsView
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;

        public IndexModel(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> Students { get; set; }

        public async Task OnGet()
        {
            Students = await _context.Student.ToListAsync();
        }
    }
}