using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP01
{
    internal class HireDate
    {
		private int year;
		private int month;
		private int day;

		public int Day
		{
			get { return day; }
			set { if(value >= 1 && value <= 31)day = value; }
		}
		public int Month
		{
			get { return month; }
			set { if(value >= 1 && value <= 12)month = value; }
		}
		public int Year
		{
			get { return year; }
			set { if(value > 1900 && value <= 2024)year = value; }
		}
		public HireDate(int year, int month, int day)
		{
			Year = year;
			Month = month;
			Day = day;
		}

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
