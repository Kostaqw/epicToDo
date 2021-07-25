using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BLEpicToDo.Model
{
    public class Achive
    {
        [Key ]public int AchiveId { get; set; }
        public string Name { get;  }

        public string Describe { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
