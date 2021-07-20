using BLEpicToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicToDo
{
    public enum Dificults
    { 
        easy,
        midle,
        hard,
        legendary
    }
    public class Taski
    {
        public int TaskiId { get; set; }
        public Dificults Dificult { get; }
        public bool notification { get; set; }
      
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int AbilityId { get; set; }
        public virtual Ability Ability { get; set; }
    }
}
