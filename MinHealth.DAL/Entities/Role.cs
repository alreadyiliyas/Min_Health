using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
	public class Role
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Employee> Employees { get; set; }	
	}
}
