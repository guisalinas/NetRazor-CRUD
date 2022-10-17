using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.ProfessorsView
{
    public class CreateProfessorModel : PageModel
    {
        private readonly AppDBContext _context;

        public CreateProfessorModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Professor Professor { get; set; }
        [TempData]
        public string Message { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Add(Professor);
            await _context.SaveChangesAsync();
            Message = "Bien! Registro creado correctamente";
            return RedirectToPage("Index");

        }
        public void OnGet()
        {
        }
    }
}
