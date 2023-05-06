using DAL.Datas;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories;

internal class ToDoTaskRepository : Repository<ToDoTask>
{
    private AppDbContext _db;
    public ToDoTaskRepository(AppDbContext db) : base(db)
    {
        _db = db;
    }

    public ToDoTask GetByName(string goalName)
    {
        ToDoTask goal = _db.ToDoTasks.FirstOrDefault(x => x.Name == goalName);
        return goal;
    }
    public void ChangeStatus(Guid id)
    {
        var goal = _db.ToDoTasks.Find(id);
        Status stat = _db.Statuses.FirstOrDefault(a => a.Id == goal.StatusId);
        if (stat.Name == "Новая")
        {
            Status st = _db.Statuses.FirstOrDefault(a => a.Name == "Открыта");
            goal.StatusId = st.Id;
        }
        else if (stat.Name == "Открыта")
        {
            Status st = _db.Statuses.FirstOrDefault(a => a.Name == "Закрыта");
            goal.StatusId = st.Id;
        }
        _db.ToDoTasks.Update(goal);
        _db.SaveChanges();
    }
}
