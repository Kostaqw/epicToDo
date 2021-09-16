using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLEpicToDo.controller
{
    public enum Action
    {
        newAbilityLvl,
        newAtributeLvl,
        newUserLvl
    }
    public class UserController
    {
        protected User User { get; set; }

        public delegate void NewLvl(Action action);
        public event NewLvl newLvl;

        public UserController(User user)
        {
            if (user is null)
            {
                throw new ArgumentNullException("Пользователь не может быть null", nameof(user));
            }
            else
            {
                User = user;
            }
        }

        public void AddExpUser(int exp)
        {
            User.Exp += exp;
            if (User.Exp + exp > User.MaxExp)
            {
                int delta = User.MaxExp - User.Exp;
                User.Level++;
                User.MaxExp += 100 * User.Level;
                User.Exp = exp - delta;
                newLvl.Invoke(Action.newUserLvl);
            }
        }
    }
}
