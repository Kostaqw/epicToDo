using BLEpicToDo.Model;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel;

namespace BLEpicToDo.controller
{
    
    public class TaskController
    {
        private User User { get; }
        ApContext AC = new ApContext();


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="user">Пользователь</param>
        public TaskController(User user)
        {
            User = user;
        }


        #region Получение данных из БД

        /// <summary>
        /// Получить список всех заданий текущего пользователя
        /// </summary>
        /// <returns>писок всех заданий текущего пользователя</returns>
        public List<EpicToDo.Task> GetTasks()
        {
            var tasks = new List<Task>();
            using (var ApContext = new ApContext())
            {
                tasks = ApContext.Tasks.Where<Task>(o => o.User.UserId == User.UserId).ToList();              
            }

            return tasks;
        }


        /// <summary>
        /// Получить список всех способностей текущего пользователя
        /// </summary>
        /// <returns>Список всех способностей текущего пользователя</returns>
        public List<EpicToDo.Ability> GetAbillites()
        {
            var abilites = new List<Ability>();
            using (var ApContext = new ApContext())
            {
                var abil = from p in ApContext.Abilities
                           where p.User.UserId == User.UserId
                            select p;
                abilites = abil.ToList();
            }

            return abilites;
        }

        /// <summary>
        /// Получить список всех способностей текущего пользователя одного атрибута
        /// </summary>
        /// <returns>Список всех способностей текущего пользователя конкретного атрибута</returns>
        public List<EpicToDo.Ability> GetAbillites(EpicToDo.Attribute attribute)
        {
            var abilites = new List<Ability>();
            using (var ApContext = new ApContext())
            {
                var abil = ApContext.Abilities.Where(o => o.User.UserId == User.UserId && o.attribute == attribute);
                abilites = abil.ToList();
            }

            return abilites;
        }
        #endregion

        public void EditTask(Task task, string name, string description, string ability, Dificults dificults)
        {
            var fTask = AC.Tasks.First(o => o.Id == task.Id);
            if (fTask != null)
            {
                fTask.Name = name;
                fTask.Description = description;
                fTask.Ability = ability;
                fTask.Dificult = dificults;
                AC.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Данной задачи нет в базе данных", nameof(task));
            }
        }

        public void EditTask(Task task, bool isComplite)
        {
            var fTask = AC.Tasks.First(o => o.Id == task.Id);
            if (fTask != null)
            {
                fTask.complite = isComplite;
                AC.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Данной задачи нет в базе данных", nameof(task));
            }
        }

        /// <summary>
        /// Добавляет способность в базу данных для текущего пользователя
        /// </summary>
        /// <param name="abil">способность</param>
        /// <returns>возвращает истину в случае успеха</returns>
        public bool AddAbility(Ability abil)
        {
            if (!FindAbility(abil.Name))
            {
                AC.Abilities.Add(abil);
                AC.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }


        }

        /// <summary>
        /// Добавляет задачи в БД
        /// </summary>
        /// <param name="name">название задачи</param>
        /// <param name="description">описание задачи</param>
        /// <param name="ability">название способности к которой привязана задача может быть пустым</param>
        /// <param name="dificults">сложность</param>
        /// <param name="userId">id пользователя</param>
        /// <returns>возвращает истину в случае успеха</returns>
        public bool TaskAdd(string name, string description, string ability, Dificults dificults, int userId)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"{nameof(name)} не может быть пустым или иметь значение null", nameof(name));
            }

            if (!FindAUser(userId))
            {
                throw new ArgumentException($"пользователь с данным Id: {nameof(userId)} не найден");
            }

            Task task = new Task(name, description, ability, dificults, userId);
            AC.Tasks.Add(task);
            AC.SaveChanges();
            return true;
        }




        /// <summary>
        /// Удаляет задание из базы данных
        /// </summary>
        /// <param name="task">Задание</param>
        public void DeleteTask(Task task)
        {
            if (task is null)
            {
                throw new ArgumentNullException("Задача не может быть bnull", nameof(task));
            }

            AC.Tasks.Remove(task);
            AC.SaveChanges();
        }




        /// <summary>
        /// Коневертирует текстовое значение в название энама атрибута
        /// </summary>
        /// <param name="name">название</param>
        /// <returns>возвращает атрибут типа энам</returns>
        public EpicToDo.Attribute StringToAttribute(string name)
        {
            switch (name)
            {
                case "Сила": return EpicToDo.Attribute.Strength;
                case "Интеллект": return EpicToDo.Attribute.Intelect;
                case "Творчество": return EpicToDo.Attribute.Creative;
                case "Здоровье": return EpicToDo.Attribute.Health;
                default: throw new InvalidEnumArgumentException("Нет такого значения в атрибуте: " + name);
            }    
        }






        /// <summary>
        /// Поиск способности в базе данных
        /// </summary>
        /// <param name="name">название способности</param>
        /// <returns>возращает истину если способность найдена</returns>
        protected bool FindAbility(string name)
        {
            var ability = AC.Abilities.FirstOrDefault(p => p.Name == name);

            if (ability != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Поиск пользователя в базе данных
        /// </summary>
        /// <param userId="Id пользователя">Id пользователя</param>
        /// <returns>возращает истину если пользователь найдена</returns>
        protected bool FindAUser(int userId)
        {
            var user = AC.Users.FirstOrDefault(p => p.UserId == userId);

            if (user != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверка есть ли в базе данных такая задача.
        /// </summary>
        /// <param name="name">название задачи</param>
        /// <returns>возращает истину если задача найдена и не выполнена найдена</returns>
        protected bool CheckTask(string name)
        {
            var task = AC.Tasks.FirstOrDefault(p => p.Name == name && p.complite == false); ;

            if (task != null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Поиск в БД задачи по имени 
        /// </summary>
        /// <param name="name">название задачи</param>
        /// <param name="comlite">искать ли завершенную задачу</param>
        /// <returns>возвращает задачу или null</returns>
        public Task FindTask(string name, bool comlite = false)
        {
            Task task;
            if (!comlite)
            {
                task = AC.Tasks.FirstOrDefault(p => p.Name == name && p.complite == false);
            }
            else
            {
                task = AC.Tasks.FirstOrDefault(p => p.Name == name);
            }
            return task;

        }



    }
}
