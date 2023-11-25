using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
	public class Orginization
	{
		public int Id { get; set; }
		public string NameOfOrg { get; set; }
		public DateTime DateCreated { get; set; }
		public string Address { get; set; }
		public string Contacts { get; set; }
		public bool IsBlocked { get; set; }= false;
		public List<Client> Clients { get; set; } 
		public List<Employee> Employees { get; set; }
	
	}
}
