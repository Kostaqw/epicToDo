using BLEpicToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDo
{
    public enum Attribute
    { 
        Strength,
        Intelect,
        Creative,
        Health
    }
   public class User
    {
        public int UserId { get; }
        public string Name { get; }
        public string Password { get; } //TODO: реализовать хэширование
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Strength { get; set; }
        public int Intelect { get; set; }
        public int Creative { get; set; }
        public int Health { get; set; }

        //TODO: параметры для статистики
        //TODO: параметры для кастомизации

        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Daily> Dailies { get; set; }
        
        public virtual ICollection<Ability> Abilities { get; set; }
        public virtual ICollection<Achive> Achives { get; set; }
    }
}
