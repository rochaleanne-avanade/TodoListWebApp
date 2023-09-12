using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using TodoListWebApp.Models;
using TodoListWebApp.Services;

namespace TodoListWebApp.Pages
{
    public class ListModel : PageModel
    {
        private readonly ToDoService toDoService;
        public List<ToDo> ToDoSet { get; set; }
        public ListModel(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }
        public async Task OnGet()
        {
            ToDoSet = await toDoService.GetToDosAsync();
        }
    }
}
