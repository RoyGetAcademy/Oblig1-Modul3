using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1Modul3
{
	public class Person
	{
		public int myID = 100;
		public int ID { get; set; } = 0;
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public int BirthYear { get; set; } = 0;
		public int DeathYear { get; set; } = 0;

		public Person Father = null;
		public Person Mother = null;

		public string GetDescription()
		{
			var id = "";
			var first = "";
			var last = "";
			var birth = "";
			var death = "";
			var dad = "";
			var mom = "";
			if (FirstName != "") first = FirstName + " ";
			if (LastName != "") last = LastName + " ";
			if (FirstName != "") first = FirstName + " ";
			if (ID != 0) id = "(ID=" + ID + ") ";
			if (BirthYear != 0) birth = "Født: " + BirthYear + " ";
			if (DeathYear != 0) death = "Død: " + DeathYear + " ";
			if (Father != null) dad = "Far: " + Father.FirstName + "(ID=" + Father.ID + ") ";
			if (Mother != null) mom = "Mor: " + Mother.FirstName + "(ID=" + Mother.ID + ")";
			return (first + last + id + birth + death + dad + mom);
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
