using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public static class DataBase
    {
        static private List<Kullanıcı> _users;

        static DataBase()
        {
            _users = new List<Kullanıcı>()
            {
                new Kullanıcı(){Username="Cagatay",Password="1502"},
                new Kullanıcı(){Username="Serkan",Password="1373"}
            };
        }
        public static List<Kullanıcı> user
        {
            get { return _users; }
        }
        public static string GirisKontrol(Kullanıcı kullanıcı)
        {
            bool username_control = false;
            bool password_control = false;
            foreach(Kullanıcı items in _users)
            {
                if (items.Username == kullanıcı.Username)
                {
                    username_control = true;

                    if (items.Password == kullanıcı.Password)
                    {
                        password_control = true;
                    }
                }
            }
            if (username_control==true && password_control == true) 
            { 
                return "Giriş Yapıldı!!!"; 
            }
            else if(username_control==false && password_control == false)
            {
                return "Kullanıcı Adınız Ve Şifreniz Yanlış!!!";
            }
            else if (password_control == false)
            {
                return "Şifreniz Yanlış";
            }
            else 
            {
                return "Kullanıcı Adınız Yanlış";
            }
        }

    }
}