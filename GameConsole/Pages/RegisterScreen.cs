using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
	internal class RegisterScreen : Screen
	{
		public RegisterScreen() : base("Register Page")
		{
		}
		public override void Show()
		{
			base.Show();
			CenterText("Enter Your Name");
			string name=Console.ReadLine();
            CenterText("Enter Your UserName");
            string username = Console.ReadLine();
            CenterText("Enter Your password");
            string pass = Console.ReadLine();
			UserDb.RegisterUser(name, username, pass);
        }
	}
}
