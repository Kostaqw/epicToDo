using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace EpicToDo
{
    class SimpleContext : DbContext
    {
        public SimpleContext() : base("DBApplication")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
