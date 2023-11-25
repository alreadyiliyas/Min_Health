using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
	//1.	Пациент (Фамилия, Имя, Отчество, ИИН)
	public abstract class User
	{
		public int Id { get; set; }
		public string FName { get; set; }
		public string SName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public DateTime CreationDate { get; set; }
		public int OrgId { get; set; }
		public Orginization Orginization { get; set; }
	}
}
