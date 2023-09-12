using System.ComponentModel.DataAnnotations;

namespace TodoListWebApp.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
        public DateTime DateAdded { get; set; }
        public Status Status { get; set; } = Status.Created;

    }
}
