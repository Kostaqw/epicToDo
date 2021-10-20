using BLEpicToDo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

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
        #region параметры
        [Key] public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } //TODO: реализовать хэширование
        public int Age { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int MaxExp { get; set; }

        public int Strength { get; set; }
        public int StrengthExp { get; set; }
        public int MaxStrengthExp { get; set; }

        
        public int Intelect { get; set; }
        public int IntelExp { get; set; }
        public int MaxIntelExp { get; set; }

        public int Creative { get; set; }
        public int CreativeExp { get; set; }
        public int MaxCreativeExp { get; set; }

        public int Health { get; set; }
        public int HealthExp { get; set; }
        public int MaxHealthExp { get; set; }


        public byte[] photo { get; set; }
        
        //TODO: параметры для статистики
        //TODO: параметры для кастомизации

        public List<Task> Tasks { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Daily> Dailies { get; set; }
        #endregion
        public User(string name, string password, int age): base()
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
            Age = age;
        }

        public User()
        {
            MaxExp = 100;
            MaxHealthExp = 3;
            MaxIntelExp = 3;
            MaxCreativeExp = 3;
            MaxStrengthExp = 3;
            
        }
    }
}
