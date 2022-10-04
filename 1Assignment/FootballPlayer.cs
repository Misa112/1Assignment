using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Assignment
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }        
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + ShirtNumber;
        }
        
        public void ValidateName()
        {
            if (Name == null) 
                throw new ArgumentNullException("name is null"); 
            if (Name.Length < 2) 
                throw new ArgumentException("name must be at least 2 characters: " + Name);
        }        

        public void ValidateAge()
        {            
            if (Age <= 1)
                throw new ArgumentOutOfRangeException("age must be more than 1: " + Age);            
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber == null)
                throw new ArgumentNullException();
            if (ShirtNumber < 1 || ShirtNumber > 99)
                throw new ArgumentOutOfRangeException("Shirt number is out of range (1-99): " + ShirtNumber);
        }

        public void Validate()
        {
            ValidateName();
            ValidateAge();
            ValidateShirtNumber();
        }
    }
}
