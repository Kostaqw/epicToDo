using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDo
{
    public enum Skils
    { 
        Strength,
        Intelect,
        Creative,
        Health
    }
   public class User
    {
        public int IdUser { get; }
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

        public virtual List<Task> Tasks { get; set; }

    }
}
