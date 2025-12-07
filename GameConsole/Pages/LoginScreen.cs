using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
	internal class LoginScreen : Screen
	{
		public LoginScreen() : base("Login Page")
		{
		}
		public override void Show()
		{
			base.Show();
			CenterText("Enter Your UserName");
			string username = Console.ReadLine();
			CenterText("Enter Your password");
			string pass = Console.ReadLine();
			Models.User u=UserDb.Login(username, pass);
			if (u != null)
			{
				CenterText("there is no user with that info");
				Console.ReadKey();
				Screen next1 = new MainMenu();
				next1.Show();
			}
            CenterText("you are loged in");
            Console.ReadKey();
            Screen next = new GameMenu();
            next.Show();
        }
	}
}
