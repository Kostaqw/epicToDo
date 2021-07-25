﻿using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BLEpicToDo.Model
{
    public class Ability
    {
        public int AbilityId { get; set; }

        public string Name { get; set; }


        [Key] public int TaskId { get; set; }
        public virtual ICollection<EpicToDo.Task> Tasks { get; set; }
        public int DailiesId { get; set; }
        public virtual ICollection<Daily> Dailies { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}