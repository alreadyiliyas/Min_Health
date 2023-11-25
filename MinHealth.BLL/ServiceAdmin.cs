using MinHealth.DAL;
using MinHealth.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.BLL
{
	public class ServiceAdmin
	{
		private string path = @"C:\\Users\\User\\source\\repos\\Ex2\\MinHealth.DAL\\ConsoleApp.MinHealth\\bin\\Debug\\test.db";
		//1. Создание орг
		public string AddOrg(Orginization orginization)
		{
			Repository<Orginization> repository = new Repository<Orginization>(path);
			bool res = repository.Create(orginization);
			if (res) return "Orginization is created";
			else return "Orginization is not created";
		}
		//2. Создание сотр
		public string AddEmployee(Employee employee)
		{
			Repository<Employee> repository = new Repository<Employee>(path);
			bool res = repository.Create(employee);
			if (res) return "employee is created";
			else return "employee is not created";
		}
		//3. Блок орг
		public string BlockOrg(int Id)
		{
			Repository<Orginization> repository = new Repository<Orginization>(path);
			var org = repository.GetById(Id);
			org.IsBlocked = true;
			bool res = repository.Update(org);
			if (res) return "org is blocked";
			else return "error update";
		}
		//4. Блок сотр
		public string BlockEmp(int Id)
		{
			Repository<Employee> repository= new Repository<Employee>(path);
			var emp = repository.GetById(Id);
			emp.IsBlocked = true;
			bool res = repository.Update(emp);
			if (res) return "emp is blocked";
			else return "error update";
		}
	}
}
