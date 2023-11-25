using MinHealth.BLL;
using MinHealth.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.MinHealth
{
	internal class Program
	{
		static void Main(string[] args)
		{

			
			Console.WriteLine("1: Auth");
			Console.WriteLine("2: Reg");
			Console.Write("Choise: ");
			int choise = Convert.ToInt32(Console.ReadLine());
			if(choise == 1 ) 
			{
				Console.Write("Login");
				string Login = Console.ReadLine();
				Console.Write("Password");
				string Password = Console.ReadLine();
				if(Login == "admin" && Password == "admin")
				{
					Console.WriteLine("1: Create org ");
					Console.WriteLine("2: Create employee ");

					choise = Convert.ToInt32(Console.ReadLine());
					if(choise == 1 )
					{
						ServiceAdmin serviceAdmin = new ServiceAdmin();
						Orginization orginization = new Orginization();

						Console.Write("NameOfOrg: ");
						orginization.NameOfOrg = Console.ReadLine();
						Console.Write("Address: ");
						orginization.Address = Console.ReadLine();
						Console.Write("Contacts: ");
						orginization.Contacts = Console.ReadLine();
						orginization.DateCreated = DateTime.Now;
						string res = serviceAdmin.AddOrg(orginization);
						Console.WriteLine(res);
					}


				}
			}
			else if (choise == 2)
			{
				
			}
		}
	}
}
