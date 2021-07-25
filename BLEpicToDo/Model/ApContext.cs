using EpicToDo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLEpicToDo.Model
{
    public class ApContext:DbContext
    {
        public ApContext():base("DBApplication") { }

        public DbSet<User> Users { get; set; }
        public DbSet<EpicToDo.Task> Tasks { get; set; }
        public DbSet<Daily> Dailies { get; set; }
        public DbSet<Ability> Abilities { get; set; }
    }
}
