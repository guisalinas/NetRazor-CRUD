using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_NetRazor.Pages.ProfessorsView
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _context;

        public IndexModel(AppDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Professor> Professors { get; set; }

        [TempData]
        public string Message { get; set; }

        public async Task OnGet()
        {
            Professors = await _context.Professor.ToListAsync();
        }

    }
}
