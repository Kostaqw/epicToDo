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
            if (User.Exp + exp > User.MaxExp)
            {
                int delta = User.MaxExp - User.Exp;
                User.Level++;
                User.MaxExp += 100 * User.Level;
                User.Exp = exp - delta;
                newLvl.Invoke(Action.newUserLvl, "Пользователь");
            }
            AC.SaveChanges();
        }

        public void AddExpAbility(int exp, Ability abil)
        {
            Ability Abbil;
            Abbil = AC.Abilities.FirstOrDefault(c => c.AbilityId == abil.AbilityId);
            
            Abbil.Exp += exp;
            if (Abbil.Exp + exp > Abbil.MaxExp)
            {
                int delta = Abbil.MaxExp - Abbil.Exp;
                Abbil.Level++;
                Abbil.MaxExp += 100 * Abbil.Level;
                Abbil.Exp = exp - delta;
                newLvl.Invoke(Action.newAbilityLvl, Abbil.Name);
            }
            AC.SaveChanges();

        }

        public void AddExpIntelect(int exp)
        {
            User = AC.Users.FirstOrDefault(c => c.UserId == User.UserId);
            User.IntelExp += exp;
            if (User.IntelExp + exp > User.MaxIntelExp)
            {
                int delta = User.MaxIntelExp - User.IntelExp;
                User.Intelect++;
                User.MaxIntelExp += 2 * User.Intelect;
                User.IntelExp = exp - delta;
                newLvl.Invoke(Action.newAtributeLvl, "Интилект");
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
