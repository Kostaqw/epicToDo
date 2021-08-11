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
 
        /// <summary>
        /// Поиск в базе данных пользователя по имени
        /// </summary>
        /// <param name="login">имя пользователя</param>
        /// <param name="pasword">пароль</param>
        /// <returns>возвращает истину если пользователь найден</returns>
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


        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="pasword">пароль</param>
        /// <returns>найденного пользователя</returns>
        public User LogIn(string login, string pasword)
        {
            Autorization(login, pasword);
            return User;
        }
        
        /// <summary>
        /// выход из системы
        /// </summary>
        public void LogOut()
        {
            User = null;
        }


        /// <summary>
        /// поиск пользователя в БД по имени
        /// </summary>
        /// <param name="name">имя</param>
        /// <returns>возвращает булево значение в зависимости от результата</returns>
        protected bool FindName(string name)
        {
            var user = context.Users.FirstOrDefault(p => p.Name == name);

            if (user != null)
                return true;
            else
                return false;
        }


        /// <summary>
        /// регистрация нового пользователя с проверкой на наличие такого пользователя
        /// </summary>
        /// <param name="login">имя</param>
        /// <param name="pasword">пароль</param>
        /// <returns>возвращает булевое значение в зависимости от результата</returns>
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
