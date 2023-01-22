﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Person
    {   
        //fields
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        //properties
        public int PersonId 
        { 
            get { return this.personId; } 
            set { this.personId = value; } 
        }
        
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName;}
            set { this.lastName = value;}
        }

        public string FavoriteColour
        {
            get { return favoriteColour;}
            set { favoriteColour = value;}
        }
        public int Age
        {
            get { return age; }
            set { age = value;}
        }
        public bool IsWorking
        {
            get { return isWorking; }
            set { isWorking = value;}
     
        }

        //constructors
        public Person() { }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            IsWorking = isWorking;
        }



        //methods
        public string DisplayPersonInfo()
        {
            return this.PersonId + ":" + this.FirstName + " " + this.LastName + "'s favorite color is " + this.FavoriteColour;
        }

        public void ChangeFavoriteColour()
        {
            this.FavoriteColour = "white";
        }

        public int GetAgeInTenYears()
        {
            return (this.age + 10);
        }

        public override string ToString()
        {
            string format = "";
            format += "PersonId:" + this.PersonId + "\n";
            format += "FirstName:" + this.FirstName + "\n";
            format += "LastName:" +this.LastName+"\n";
            format += "FavoriteColour:" + this.FavoriteColour+"\n";
            format += "Age:" +this.Age +"\n";
            format += "IsWorking:" + this.IsWorking +"\n";

            return format;
        }


    }
}
