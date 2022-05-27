using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EpicToDo
{
    public class Daily
    {
        [Key]public int DailyId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Dificults Dificult { get; set; }
        public bool[] DayOfWeak { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateComplete { get; set; }
        public string Ability { get; set; }
        public bool notification { get; set; }

        public bool complete { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        #region Конструкторы
        public Daily()
        {

        }

        public Daily(string name, Dificults dificults)
        {
            Name = name;
            Dificult = dificults;
        }

        public Daily(string name, string description, Dificults dificults):this(name, dificults)
        {
            Description = description;
        }

        public Daily(string name, string description, Dificults dificults, string abil = "") : this(name, description, dificults)
        {
            Dificult = dificults;
            Ability = abil;

        }

        public Daily(string name, string description, Dificults dificults, bool[] dayOfweek, User user, string abil = null) : this(name, description, dificults, abil)
        {
            User = user;
            UserId = user.UserId;
            DateCreate = DateTime.Now;
            DateComplete = DateTime.Now;
        }
        #endregion

    }
}
