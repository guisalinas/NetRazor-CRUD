using CRUD_NetRazor.DBContext;
using CRUD_NetRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_NetRazor.Pages.CoursesView
{
    public class EditCourseModel : PageModel
    {
        private readonly AppDBContext _context;

        public EditCourseModel(AppDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async void OnGet(int Id)
        {
            Course = await _context.Course.FindAsync(Id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CourseDB = await _context.Course.FindAsync(Course.Id);

                CourseDB.Course_name = Course.Course_name;
                CourseDB.Number_of_classes = Course.Number_of_classes;
                CourseDB.Price = Course.Price;
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage("");
        }
    }
}
