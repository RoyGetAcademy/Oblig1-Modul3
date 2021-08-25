using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1_Modul3
{
    class Person
    {
		public int myID = 100;
		public int ID { get; set; } = 0;
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public string BirthYear { get; set; } = "";
		public string DeathYear { get; set; } = "";
		public string Father { get; set; } = "";
		public string Mother { get; set; } = "";

		public void printInfo()
		{
			Console.WriteLine("\tID        : " + ID);
			if (FirstName != "")Console.WriteLine("\tFirst name: " + FirstName);
			if (LastName != "") Console.WriteLine("\tLast name : " + LastName);
			if (BirthYear != "") Console.WriteLine("\tBirth     : " + BirthYear);
			if (DeathYear != "") Console.WriteLine("\tDeath     : " + DeathYear);
			if (Father != "") Console.WriteLine("\tFather    : " + Father);
			if (Mother != "") Console.WriteLine("\tMother    : " + Mother);
		}
	}
}
