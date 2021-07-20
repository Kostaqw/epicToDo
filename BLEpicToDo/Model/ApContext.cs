using EpicToDo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLEpicToDo.Model
{
    class ApContext:DbContext
    {
        public ApContext():base("DBApplication") { }

        public DbSet<User> Users;
        public DbSet<Taski> Tasks;
        public DbSet<Daily> Dailies;
        public DbSet<Ability> Abilities;
    }
}
