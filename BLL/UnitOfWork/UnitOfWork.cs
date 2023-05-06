using BLL.Repositories;
using DAL.Datas;

namespace BLL.UnitOfWork;

public class UnitOfWork : IDisposable
{
    private AppDbContext context;

    public UnitOfWork(AppDbContext _context)
    {
        context = _context;

    }

    private PriorityRepository? priorityRepository;
    private StatusRepository? statusRepository;
    private ToDoTaskRepository? toDoTaskRepository;

    public PriorityRepository PriorityRepository
    {
        get
        {
            if (priorityRepository == null)
            {
                priorityRepository = new PriorityRepository(context);
            }
            return priorityRepository;
        }
    }
    public StatusRepository StatusRepository
    {
        get
        {
            if (statusRepository == null)
            {
                statusRepository = new StatusRepository(context);
            }
            return statusRepository;
        }
    }

    public ToDoTaskRepository ToDoTaskRepository
    {
        get
        {
            if (toDoTaskRepository == null)
            {
                toDoTaskRepository = new ToDoTaskRepository(context);
            }
            return toDoTaskRepository;
        }
    }

    public void Save()
    {
        context.SaveChanges();
    }
    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
