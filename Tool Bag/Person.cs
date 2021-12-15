using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Bag
{
    class Person
    {

        private string fName;
        private string lName;
        private int age;
        private string gender;
        private double bankBalance;
        
        public string FName {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string LName {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public double BankBalance
        {
            get
            {
                return bankBalance;
            }
            set
            {
                bankBalance = value;
            }
        }
        public Person()
        {

        }
        public Person(string _fName, string _lName, int _age, string _gender, double _bankBalance)
        {
            FName = _fName;
            LName = _lName;
            Age = _age;
            Gender = _gender;
            BankBalance = _bankBalance;
        }

        public override string ToString()
        {
            return $"\nName: {fName} {lName}\nAge: {age}\nGender: {gender}\nBank Balance: {bankBalance:C}";
        }
    }
}
