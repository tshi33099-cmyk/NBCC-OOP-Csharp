using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Name: Tiantian Shi
// Date: 2026-01-15
// Description: A class o define a pet with name , age ,type

namespace Shi_lab1_Petapp
{

    
    public class Pet
    {
        //fields to store data
        private string _name;
        private int _age;
        private string _type;
        
        //properties to access date safely
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        //Default constructor: Sets default values when no data is provided
        public Pet()
        {
            _name = "spot";
            _age = 3;
            _type = "Dog";
            
        }
        //parameterized constructor: Creates a pet using specific data provided by the user
        public Pet(string name, int age, string type)
        {
            _type = type;
            _name = name;
            _age = age;
        }
        //return a  formmatted string describing the pet
        public string DisplayPet()
        {
            return $"{_name} is {_age} year(s) old and a {_type}";

        }

    }
}
