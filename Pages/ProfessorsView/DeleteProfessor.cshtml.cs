using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.ProfessorsView
{
    public class DeleteProfessorModel : PageModel
    {
        private readonly AppDBContext _context;
        public DeleteProfessorModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Professor Professor { get; set; }

        [TempData]
        public string Message { get; set; }

        public async void OnGet(int Id)
        {
            Professor = await _context.Professor.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ProfessorDelete = await _context.Professor.FindAsync(Professor.Id);

                if (ProfessorDelete == null)
                {
                    return NotFound();
                }

                ProfessorDelete.is_eliminated = true;
                Message = "El registro se eliminó correctamente";
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
