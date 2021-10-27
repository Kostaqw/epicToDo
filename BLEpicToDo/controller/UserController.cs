using BLEpicToDo.Model;
using EpicToDo;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private ApContext AC = new ApContext();

        ImageConverter converter = new ImageConverter();

        public delegate void NewLvl(Action action, string message);
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

        #region Добавление опыта
        public void AddExpUser(int exp)
        {
            User = AC.Users.FirstOrDefault(c => c.UserId == User.UserId);
            User.Exp += exp;
            if (User.Exp > User.MaxExp)
            {
                while (User.Exp >= User.MaxExp)
                {
                    int delta = User.MaxExp - User.Exp;
                    User.Level++;
                    User.MaxExp += 100 * User.Level;
                    User.Exp = exp - delta;
                }
                newLvl.Invoke(Action.newUserLvl, "Пользователь");
            }
            AC.SaveChanges();
        }

        public void AddExpAbility(int exp, Ability abil)
        {
            Ability Abbil;
            Abbil = AC.Abilities.FirstOrDefault(c => c.AbilityId == abil.AbilityId);
            
            Abbil.Exp += exp;
            if (Abbil.Exp >= Abbil.MaxExp)
            {
                while (Abbil.Exp >= Abbil.MaxExp)
                {
                    int delta = Abbil.MaxExp - Abbil.Exp;
                    Abbil.Level++;
                    Abbil.MaxExp += 100 * Abbil.Level;
                    Abbil.Exp = exp - delta;
                    newLvl.Invoke(Action.newAbilityLvl, Abbil.Name);
                }
            }
            AC.SaveChanges();

        }

        public void AddExpAttribut(int exp, EpicToDo.Attribute atr)
        {
            User = AC.Users.FirstOrDefault(c => c.UserId == User.UserId);

            switch (atr)
            {
                case EpicToDo.Attribute.Intelect:
                    {
                        User.IntelExp += exp;
                        if (User.IntelExp >= User.MaxIntelExp)
                        {
                            while (User.IntelExp >= User.MaxIntelExp)
                            {
                                int delta = User.MaxIntelExp - User.IntelExp;
                                User.Intelect++;
                                User.MaxIntelExp += 2 * User.Intelect;
                                User.IntelExp = exp - delta;
                                newLvl.Invoke(Action.newAtributeLvl, "Интилект");
                            }
                        }
                        break;
                    }
                case EpicToDo.Attribute.Strength:
                    {
                        User.StrengthExp += exp;
                        if (User.StrengthExp >= User.MaxStrengthExp)
                        {
                            while (User.StrengthExp >= User.MaxStrengthExp)
                            {
                                int delta = User.MaxStrengthExp - User.StrengthExp;
                                User.Strength++;
                                User.MaxStrengthExp += 2 * User.Strength;
                                User.StrengthExp = exp - delta;
                                newLvl.Invoke(Action.newAtributeLvl, "Сила");
                            }
                        }

                        break;
                    }
                case EpicToDo.Attribute.Health:
                    {
                        User.HealthExp += exp;
                        if (User.HealthExp >= User.MaxHealthExp)
                        {
                            while (User.HealthExp >= User.MaxHealthExp)
                            {
                                int delta = User.MaxHealthExp - User.HealthExp;
                                User.Health++;
                                User.MaxHealthExp += 2 * User.Health;
                                User.HealthExp = exp - delta;
                                newLvl.Invoke(Action.newAtributeLvl, "Здоровье");
                            }
                        }

                        break;
                    }
                case EpicToDo.Attribute.Creative:
                    {
                        User.CreativeExp += exp;
                        if (User.CreativeExp >= User.MaxCreativeExp)
                        {
                            while (User.CreativeExp >= User.MaxCreativeExp)
                            {
                                int delta = User.MaxCreativeExp - User.CreativeExp;
                                User.Creative++;
                                User.MaxCreativeExp += 2 * User.Creative;
                                User.CreativeExp = exp - delta;
                                newLvl.Invoke(Action.newAtributeLvl, "Творчество");
                            }
                        }

                        break;
                    }
            }
            AC.SaveChanges();
        }



        #endregion
        public void UploadImage(Bitmap photo)
        {
            //TODO: Проверка корректности
            byte[] bytePhoto;
            bytePhoto = (byte[])converter.ConvertTo(photo, typeof(byte[]));
            var LoadPhoto = AC.Users.FirstOrDefault(c => c.UserId==User.UserId);
            LoadPhoto.photo = bytePhoto;
            AC.SaveChanges();
        }

        public Bitmap Download()
        {
            Bitmap image = (Bitmap)converter.ConvertFrom(User.photo);
            return image;
        }

        public User UpdateUserInfo(User user)
        { 
            //TODO: Проверка на существоване данного пользователя;
            return AC.Users.FirstOrDefault(c => c.UserId == User.UserId);
        }

        public Ability FindAbility(string name)
        { 
            Ability abil = AC.Abilities.FirstOrDefault(c => c.Name == name);
            return abil;
        }

    }
}
