using BLEpicToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EpicToDo
{
    public enum Dificults
    { 
        Легкий,
        Средний,
        Сложный,
        Легендарный
    }
    public class Task
    {
        [Key]public int Id { get; set; }
        public Dificults Dificult { get; set; }
        public bool notification { get; set; }
      
        public bool complite { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Ability { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public Task()
        {
           
        }

        public Task(string name, string description, string ablity, Dificults dificults, int userId)
        {
            Name = name;
            Description = description;
            Dificult = dificults;
            UserId = userId;
            Ability = ablity;
            complite = false;
        }
    }
}
