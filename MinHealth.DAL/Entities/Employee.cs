using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
	public class Employee : User
	{
		public string Position { get; set; }
		public bool IsBlocked { get; set; } = false;
		public Role Role { get; set; }
		public int RoleId { get; set; }
	}
}
