using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Intarfaces
{
    internal interface IToDoTaskRepository : IRepository<ToDoTask>, IDisposable
    {
    }
}
