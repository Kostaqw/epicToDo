using BLEpicToDo.Model;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace BLEpicToDo.controller
{
    
    public class TaskController
    {
        private User User { get; }
        ApContext AC = new ApContext();

        public TaskController(User user)
        {
            User = user;
        }

        public List<EpicToDo.Task> GetTasks()
        {
            var Taskef = new List<Task>();
            using (var ApContext = new ApContext())
            {
                var Taske = from p in ApContext.Tasks
                            where p.User == User
                            select p;
                Taskef = Taske.ToList();
            }

            return Taskef;
        }

        public List<EpicToDo.Ability> GetAbillites()
        {
            var abilites = new List<Ability>();
            using (var ApContext = new ApContext())
            {
                var Taske = from p in ApContext.Abilities
                            where p.Users == User
                            select p;
                abilites = Taske.ToList();
            }

            return abilites;
        }

    }
}
