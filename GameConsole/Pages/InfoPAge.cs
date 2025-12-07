using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class InfoPAge: Base.Screen
    {
       private string username;
        private string pass;
        private string name;
        public InfoPAge(string u, string p, string n) : base("User Info Page")
        {
   
        }
        public override void Show()
        { 
            base.Show();
            User u = App.ConsoleGameApp.user;
            CenterText($"Name: {u.name}");
            CenterText($"Username: {u.username}");
            CenterText($"Password: {u.password}");
            Console.ReadKey();
        }
    }
}
