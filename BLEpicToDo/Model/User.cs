using BLEpicToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EpicToDo
{
    public enum Attribute
    { 
        Strength,
        Intelect,
        Creative,
        Health
    }
   public class User
    {

        [Key] public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } //TODO: реализовать хэширование
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Strength { get; set; }
        public int Intelect { get; set; }
        public int Creative { get; set; }
        public int Health { get; set; }

        //TODO: параметры для статистики
        //TODO: параметры для кастомизации

        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Daily> Dailies { get; set; }
        
        public virtual ICollection<Ability> Abilities { get; set; }
        public virtual ICollection<Achive> Achives { get; set; }

        public User(string name, string password)
        {
            //TODO: услажнить проверку (пробелы, количество символов)
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Имя не может быть пустым", nameof(name));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Пароль не может быть пустым", nameof(password));
            }

            Name = name;
            Password = password;
        }

        public User()
        {

        }
    }
}
