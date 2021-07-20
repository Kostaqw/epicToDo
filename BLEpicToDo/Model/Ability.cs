using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLEpicToDo.Model
{
    public class Ability
    {
        public int AbilityId { get; set; }

        public string Name { get; set; }


        public int TaskId { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public int DailiesId { get; set; }
        public virtual ICollection<Daily> Dailies { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
