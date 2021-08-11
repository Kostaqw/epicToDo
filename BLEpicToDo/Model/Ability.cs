using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EpicToDo
{
    public class Ability
    {
        [Key] public int AbilityId { get; set; }

        public string Name { get; set; }
        public EpicToDo.Attribute attribute { get; set; }

        public int TaskId { get; set; }
        public virtual ICollection<EpicToDo.Task> Tasks { get; set; }
       
        
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public Ability(string name, Attribute atr)
        {//TODO: Проверка на корректность
            Name = name;
            attribute = atr;
        }

        public Ability()
        {
        }
    }
}
