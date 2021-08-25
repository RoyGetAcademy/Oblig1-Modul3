using System;
using System.Collections.Generic;

namespace Oblig1_Modul3
{
    class Program
    {
		static void Main()
		{
			int i;
			int j=0;
			List<Person> F = new List<Person>(); 

			F.Add(new Person { ID = 101, FirstName= "Bert", LastName = "Verin", BirthYear = "1900", DeathYear = "1960" });
			F.Add(new Person { ID = 102, FirstName = "Misha", LastName = "Verin", BirthYear = "1900", DeathYear = "1960" });
			F.Add(new Person { ID = 103, FirstName = "Potter", LastName = "Verin", BirthYear = "1920", DeathYear = "1950" });
			F.Add(new Person { ID = 104, FirstName = "Vladi", LastName = "Verin", BirthYear = "1920", DeathYear = "1980" });
			F.Add(new Person { ID = 105, FirstName = "Petrosh", LastName = "Verin", BirthYear = "1920", DeathYear = "1994" });
			F.Add(new Person { ID = 106});
			F.Add(new Person { ID = 107, LastName = "Test" });
			F[2].Mother = "Misha";
			F[2].Father = "Bert";
			F[3].Mother = "Misha";
			F[3].Father = "Bert";

			while (j < F.Count)
            {
				if (F[j].ID == 0)
				{
					return;
				}
				else
				{
					F[j].printInfo();
					j++;
				}
			}
		}
	}
}