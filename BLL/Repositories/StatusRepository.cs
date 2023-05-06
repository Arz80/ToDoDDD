using DAL.Datas;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class StatusRepository : Repository<Status>
    {
        private AppDbContext _db;
        public StatusRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
