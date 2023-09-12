using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TodoListWebApp.Models;
using TodoListWebApp.Services;

namespace TodoListWebApp.Pages
{
    public class NewModel : PageModel
    {
        private readonly ToDoService toDoService;
        [BindProperty]
        public ToDo ToDo { get; set; }

        public NewModel(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await toDoService.AddAsync(ToDo);
            return LocalRedirect("/list");
        }
    }
}
