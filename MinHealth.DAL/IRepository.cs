using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL
{
	public interface IRepository<T> where T : class
	{
		bool Create(T data);
		T GetById(int id);
		List<T> GetAll();
		bool Delete(int id);
		bool Update(T data);
	}
}
