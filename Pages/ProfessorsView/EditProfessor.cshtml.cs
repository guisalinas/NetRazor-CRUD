using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.ProfessorsView
{
    public class EditProfessorModel : PageModel
    {
        private readonly AppDBContext _context;

        public EditProfessorModel(AppDBContext context)
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
                var ProfessorDB = await _context.Professor.FindAsync(Professor.Id);

                ProfessorDB.Name = Professor.Name;
                ProfessorDB.Surname = Professor.Surname;
                ProfessorDB.Date_birth = Professor.Date_birth;
                ProfessorDB.Specialty = Professor.Specialty;
                await _context.SaveChangesAsync();
                Message = "Bien! El registro se modificó con éxito!";
                return RedirectToPage("Index");
            }
            return RedirectToPage("");
        }
    }
}
