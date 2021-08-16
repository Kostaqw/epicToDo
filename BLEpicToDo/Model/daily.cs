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
       
        public Dificults Dificult { get; }
        public DateTime DateCreate { get; set; }
        public bool notification { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}
