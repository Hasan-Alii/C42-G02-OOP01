using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP01
{
	enum SecPriv
	{
        guest = 1, 
		Developer = 2, 
		secretary = 3,
		DBA = 4,
		securityOfficer = 5
    }
    internal class Employee
    {
		private int id;
		private string name = "";
		private SecPriv priv;
		private double salary;
		private HireDate hireDate;
		private bool isMale;

		public bool IsMale
		{
			get { return isMale; }
			set { isMale = value; }
		}

		public HireDate HireDate
		{
			get { return hireDate; }
			set { hireDate = value; }
		}

		public double Salary
		{
			get { return salary; }
			set { if(value > 0)salary = value; }
		}

		public SecPriv Priv
		{
			get { return priv; }
			set { priv = value; }
		}

		public string Name
		{
			get { return name; }
			set { if(value.Length > 0)name = value; }
		}

		public int Id
		{
			get { return id; }
			set { 
				if(value > int.MinValue && value < int.MaxValue)
					id = value; 
			}
		}

		public Employee(int id, string name, SecPriv priv, double salary, HireDate hireDate, bool isMale)
		{
			Id = id;
			Name = name;
			Priv = priv;
			Salary = salary;
			HireDate = hireDate;
			IsMale = isMale;
		}

        public override string ToString()
        {
            return $"employee id: {id}, name: {name}, priv: {priv}, hire: {hireDate.ToString()}, ismale: {isMale} & salary is {salary:C}";
        }
    }
}
