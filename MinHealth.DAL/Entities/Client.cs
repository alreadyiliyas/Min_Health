using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
	//1.	Пациент (Фамилия, Имя, Отчество, ИИН)
	public class Client : User
	{
		public string IIN { get; set; }
		public string PhoneNumber { get; set; }
		public int Sex { get; set; }
		public string Address { get; set; }	
		public DateTime DateofBirthDay { get; set; }
		
	}
}
