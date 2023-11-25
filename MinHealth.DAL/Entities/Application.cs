using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL.Entities
{
	public class Application
	{
		public int Id { get; set; }
		public DateTime DateCreatedApp { get; set; }
		public int State { get; set; }
		public Client Author { get; set; }	
		public int ClientId { get; set; }
		public Orginization Orginization { get; set; }
		public int OrgId { get; set; }

	}
}
