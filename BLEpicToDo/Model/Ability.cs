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
       
        public int Level { get; set; }

        public int Exp { get; set; }

        public int MaxExp { get; set; }
        
        public EpicToDo.Attribute attribute { get; set; }

       
        public User User { get; set; }



        public Ability(string name, Attribute atr)
        {//TODO: Проверка на корректность
            Name = name;
            attribute = atr;
            MaxExp = 100;
        }

        public Ability()
        {
            MaxExp = 100;
        }
    }
}
