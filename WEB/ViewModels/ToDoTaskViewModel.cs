using DAL.Entities;

namespace WEB.ViewModels;

public class ToDoTaskViewModel
{
    public List<ToDoTask>? ToDoTasks { get; set; }
    public List<Status>? Statuses { get; set; }
    public List<Priority>? Priorities { get; set; }
}
