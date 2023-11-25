using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace MinHealth.DAL
{
	public class Repository<T> : IRepository<T> 
		where T : class
	{
		private string path = "";
		public Repository(string path)
		{
			this.path = path;
		}
		public bool Create(T data)
		{
			try
			{
				using (LiteDatabase db = new LiteDatabase(path))
				{
					ILiteCollection<T> col = db.GetCollection<T>(typeof(T).Name);
					col.Insert(data);
					return true;
				}

			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool Delete(int id)
		{
			try
			{
				using (LiteDatabase db = new LiteDatabase(path))
				{
					ILiteCollection<T> col = db.GetCollection<T>(typeof(T).Name);
					col.Delete(id);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		public T GetById(int id)
		{
			try
			{
				using (LiteDatabase db = new LiteDatabase(path))
				{
					ILiteCollection<T> col = db.GetCollection<T>(typeof(T).Name);
					return col.FindById(id);
				}

			}
			catch (Exception)
			{
				return null;
			}
		}
		public List<T> GetAll()
		{
			try
			{
				using (LiteDatabase db = new LiteDatabase(path))
				{
					ILiteCollection<T> col = db.GetCollection<T>(typeof(T).Name);
					return col.FindAll().ToList();
				}
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool Update(T data)
		{
			try
			{
				using (LiteDatabase db = new LiteDatabase(path))
				{
					ILiteCollection<T> col = db.GetCollection<T>(typeof(T).Name);
					col.Update(data);
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
