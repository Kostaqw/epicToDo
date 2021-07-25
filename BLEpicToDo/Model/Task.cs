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
        easy,
        midle,
        hard,
        legendary
    }
    public class Task
    {
        [Key]public int Id { get; set; }
        public Dificults Dificult { get; set; }
        public bool notification { get; set; }
      
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int AbilityId { get; set; }
        public virtual Ability Ability { get; set; }
    }
}
