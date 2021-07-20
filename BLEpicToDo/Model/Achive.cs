using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLEpicToDo.Model
{
    public class Achive
    {
        public int AchiveId { get; }
        public string Name { get;  }

        public string Describe { get; }
        public int UserId { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
