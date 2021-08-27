using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1Modul3
{
    public class FamilyApp
    {
        public List<Person> _person = new List<Person>();
        public string WelcomeMessage = "Heisann og velkommen.";
        public string CommandPrompt = "Skriv Hjelp for hjelp.\nSkriv Liste for full liste av slekt\nSkriv vis <id> for en spesifik id.\nEks 'Vis 15'\n\n";
        int i;
        public FamilyApp(params Person[] values)
        {
            if(values.Length >=1)
            {
                while (i < (values.Length))
                {
                    _person.Add(values[i]);
                    Console.Write($"Test fail in {values[0].Father.FirstName} \n");
                    i++;
                }
            }
        }
        string PrintStuff(int num)
        {
            var t = _person[num];
            var id = "";
            var first = "";
            var last = "";
            var birth = "";
            var death = "";
            var dad = "";
            var mom = "";
            if (t.FirstName != "") first = t.FirstName + " ";
            if (t.LastName != "") last = t.LastName + " ";
            if (t.FirstName != "") first = t.FirstName + " ";
            if (t.ID != 0) id = "(ID=" + t.ID + ") ";
            if (t.BirthYear != 0) birth = "Født: " + t.BirthYear + " ";
            if (t.DeathYear != 0) death = "Død: " + t.DeathYear + " ";
            if (t.Father != null) dad = "Far: " + t.Father.FirstName + "(ID=" + t.Father.ID + ") ";
            if (t.Mother != null) mom = "Mor: " + t.Mother.FirstName + "(ID=" + t.Mother.ID + ")";
            return (first + last + id + birth + death + dad + mom);
        }
        public string HandleCommand(string value)
        {
            if (value == "Hjelp")
            {
                Console.Clear();
                return CommandPrompt;
            }
            else if (value == "Liste")
            {
                int i = 0;
                while (i < _person.Count)
                {
                    PrintStuff(i);
                    i++;
                }
                return "";
            }
            else
            {
                string[] words = value.Split(' ');
                words[0].ToLower();
                if (words.Length <= 1) return "That is not valid";//Check to make sure there is even 2 words (if so go on to show the list
                int number;
                bool isParsable = Int32.TryParse(words[1], out number);
                if (number == 0 || number > (_person.Count+1)) return "That is not valid"; ;
                if (isParsable)
                {
                    if (words[0] == "vis")
                    {
                        Console.WriteLine($"\n\nThis is your number {number}\n\n");
                        var t = _person[(number-1)];
                        var id = "";
                        var first = "";
                        var last = "";
                        var birth = "";
                        var death = "";
                        var dad = "";
                        var mom = "";
                        if (t.FirstName != "") first = t.FirstName + " ";
                        if (t.LastName != "") last = t.LastName + " ";
                        if (t.FirstName != "") first = t.FirstName + " ";
                        if (t.ID != 0) id = "(ID=" + t.ID + ") ";
                        if (t.BirthYear != 0) birth = "Født: " + t.BirthYear + " ";
                        if (t.DeathYear != 0) death = "Død: " + t.DeathYear + " ";
                        if (t.Father != null) dad = "Far: " + t.Father.FirstName + "(ID=" + t.Father.ID + ") ";
                        if (t.Mother != null) mom = "Mor: " + t.Mother.FirstName + "(ID=" + t.Mother.ID + ")";
                        return (first + last + id + birth + death + dad + mom);
                    }
                    else return "That is not valid";
                }
                else return "That is not valid";
            }
        }
    }
}
