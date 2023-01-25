using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Person firstPerson = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person secondPerson = new Person(2, "Gina", "James", "Green", 18, false);
            Person thirdPerson = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person fourthPerson = new Person(4, "Mary", "Beals", "Yellow", 28, true);
            double ageSum = 0;
            double ageAve ;
            



            //display Gina's info
            Console.WriteLine(secondPerson.DisplayPersonInfo());
            //Display Mike's info as a list
            Console.WriteLine(thirdPerson.ToString());
            //change Ian's Favorite Colour to white
            firstPerson.ChangeFavoriteColour();
            Console.WriteLine(firstPerson.ToString());
            // display mary's age after ten years
            Console.WriteLine("Mary Beals' Age in 10 years is:" + fourthPerson.GetAgeInTenYears());

            // skipped the relationship part and jumped to making a list and using that list to print out:
            // ave age of all the people in the list, who's the youngest and oldest, who has a first name starting with the letter M and who likes the colour blue

            // first make the list
            List<Person> personList = new List<Person>
            {
                firstPerson, secondPerson, thirdPerson, fourthPerson
            };

         

            // set the first person as the base comparison of age FOR NOW; will be changed later as foreach loop occurs
            int ageMin = personList[0].Age;
            int ageMax = personList[0].Age;
            string youngestPerson = "";
            string oldestPerson = "";
           
            //need a storage for names that start with M
            List<string> namesMList = new List<string>();
            // storage for those who like blue
            List<string> likesBlueList = new List<string>();
            
            
            // now do a foreach loop that goes through each person and save/record the desired info
            foreach (Person person in personList)
            {
                //add all the ages to be used for ave. computation later
                ageSum += person.Age;

                // compare the ages of the people, saving only the youngest and olde
                if (person.Age <= ageMin)
                {
                    ageMin = person.Age;
                    youngestPerson = $"{person.FirstName} {person.LastName}";

                }
                else if (person.Age > ageMax)
                {
                    ageMax = person.Age;
                    oldestPerson = $"{person.FirstName} {person.LastName}";
                }

                
                // set the first char to the current person's firstname character each loop
                char firstChar = person.FirstName.ToCharArray()[0];
      
                if (firstChar == 'M')
                {
                    namesMList.Add($"{person.FirstName} {person.LastName}");

                }


                if (person.FavoriteColour == "Blue")
                {
                    likesBlueList.Add($"{person.FirstName} {person.LastName}");
                }



            }// foreach loop ends




            // PRINTING RESULTS
            
            //print average age
            ageAve = ageSum / personList.Count; //[1]
            Console.WriteLine("the average age of the people in the list is " + ageAve.ToString());
     
            // print the oldest and youngest
            Console.WriteLine("The youngest person is " + youngestPerson + " at age " + ageMin);
            Console.WriteLine("The oldest person is " + oldestPerson +  " at age " + ageMax);

            // names of the people whos first name start with M
            foreach(string name in namesMList)
            {
                Console.WriteLine(name + "'s first name starts with the Lettter M.");
            }
            
            // who likes blue
            foreach(string name in likesBlueList)
            {
                Console.WriteLine(name + " likes the colour Blue.");
            }






            //References
            //[1]https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=net-7.0 

        }
    }
}
