using BLEpicToDo.Model;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.ComponentModel.DataAnnotations;

namespace BLEpicToDo.controller
{
    public class ControllerAutorize
    {
        ApContext context = new ApContext();

        protected User User { get; set; }
 
        private bool Autorization(string login, string pasword)
        {
            var user = context.Users.FirstOrDefault(p => p.Name == login && p.Password == pasword);
            if (user == null)
                return false;
            else
            { 
                User = (User)user;
                return true;
            }
        }

        public User LogIn(string login, string pasword)
        {
            Autorization(login, pasword);
            return User;
        }
        public void LogOut()
        {
            User = null;
        }

        protected bool FindName(string name)
        {
            var user = context.Users.FirstOrDefault(p => p.Name == name);

            if (user != null)
                return true;
            else
                return false;
        }
        public bool Registration(string login, string pasword)
        {
            if (!FindName(login))
            {
                context.Users.Add(new User(login, pasword));
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
