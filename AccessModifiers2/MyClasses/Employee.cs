using System;
using System.Collections.Generic;
using System.Text;

namespace MyClasses
{
    public class Employee
    {
        private string _name;
        private string _surname;
        public double Salary { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (CheckNames(value))
                    this._name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (CheckNames(value))
                    this._surname = value;
            }
        }
        public bool CheckNames(string name)
        {
            int count = 0;
            foreach (var item in name)
            {
                if (!char.IsLetter(item))
                    count++;                   
            }
            if (count == 0 && char.IsUpper(name[0]))
                return true;

            Console.WriteLine("Boyuk herfle baslamali ve yalniz herflerden ibaret olamlidir. ");
            return false;
       }

    }
}
