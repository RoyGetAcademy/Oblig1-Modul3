using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1Modul3
{
	public class Person
	{
		public int ID { get; set; }
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public int BirthYear { get; set; }
		public int DeathYear { get; set; }

		public Person Father = null;
		public Person Mother = null;

		private static string GetField(string value, string label = "")
        {
            return value == "" ? "" : label + value + " ";
        }

        public string GetDescription()
		{
			var dad = "";
			var mom = "";
			if (Father != null) dad = "Far: " + Father.FirstName + "(ID=" + Father.ID + ") ";
			if (Mother != null) mom = "Mor: " + Mother.FirstName + "(ID=" + Mother.ID + ")";

			return GetField(FirstName) + 
					GetField(LastName) + 
					"(ID=" + ID + ") " + 
					GetField(BirthYear != 0 ? BirthYear.ToString() : "", "Født: ") +
					GetField(DeathYear != 0 ? DeathYear.ToString() : "", "Død: ") +
					dad + 
					mom;
			/*
			string str = "";
			str += FirstName != null ? FirstName + " " : "";
			str += LastName != null ? LastName + " " : "";
			str += Id != 0 ? $"(Id={Id}) " : "";
			str += BirthYear != 0 ? $"Født: {BirthYear} " : "";
			str += DeathYear != 0 ? $"Død: {DeathYear} " : "";
			str += Father != null ? $"Far: {Father.FirstName} (Id={Father.Id}) " : "";
			str += Mother != null ? $"Mor: {Mother.FirstName} (Id={Mother.Id}) " : "";
			return str.Trim();*/
		}
	}
}