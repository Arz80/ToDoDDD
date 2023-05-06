using DAL.Entities;

namespace DAL.Intarfaces;

public interface IToDoTaskRepository : IRepository<ToDoTask>, IDisposable
{
}
