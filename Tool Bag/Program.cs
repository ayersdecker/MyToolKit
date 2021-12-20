using System;
using System.Collections.Generic;
// Decker Ayers December 2021
// Program Class (! Testing Only !)

namespace Tool_Bag
{
    class Program
    {
        static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            while (true)
            {
                Helper.ColorCyan("\n1. Make Person\n2. View People\n3. Exit\n");
                switch (Helper.ValidateNum(1, 3))
                {
                    case 1:
                        MakePerson();
                        break;
                    case 2:
                        ViewPeople();
                        break;
                    case 3:
                        Helper.ExitProgram();
                        break;
                }
            }    
        }
        private static void MakePerson()
        {
            Person person = new Person();
            person.FName  = Helper.GatherString("\nFirst Name: ");
            person.LName  = Helper.GatherString("Last Name: ");
            person.Age    = Helper.GatherInt("Age: ");
            person.Gender = Helper.GatherString("Gender: ");
            person.BankBalance = Helper.GatherDouble("Bank Balance: ");
            people.Add(person);
            System.Threading.Thread.Sleep(500);
            Helper.ColorGreen("\n- - Person Saved - -");
        }
        private static void ViewPeople()
        {
            foreach(Person person in people)
            {
                Helper.ColorGreen(person.ToString());
            }
        }
    }
}
