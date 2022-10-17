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

        public async Task<IActionResult> OnPostDelete(int Id)
        {
            if (ModelState.IsValid)
            {
                var ProfessorDelete = await _context.Professor.FindAsync(Id);
                if(ProfessorDelete == null)
                {
                    return NotFound();
                }

                _context.Remove(ProfessorDelete);
                await _context.SaveChangesAsync();
                Message = "El registro se eliminó correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
