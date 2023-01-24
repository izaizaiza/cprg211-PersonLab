using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
            double ageAve;



        //display Gina's info
            Console.WriteLine(secondPerson.DisplayPersonInfo());
            //Display Mike's info as a list
            Console.WriteLine(thirdPerson.ToString());
            //change Ian's Favorite Colour to white
            firstPerson.ChangeFavoriteColour();
            Console.WriteLine(firstPerson.ToString());
            // display mary's age after ten years
            Console.WriteLine("Mary Beals' Age in 10 years is:" + fourthPerson.GetAgeInTenYears());

            // create two relation objects that show Gina and Mary are sisters

            // and that Ian and Mike are brothers.
            // then display both relationships

            //add all person objects to a list, and then use the list to
            List<Person> personList = new List<Person>
            {
                firstPerson, secondPerson, thirdPerson, fourthPerson
            };
            // just checking if the list works
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.DisplayPersonInfo()}");
            }
            // ave age of the people in the list
            foreach (Person person in personList)
            {
               ageSum += person.Age;
            }
            ageAve = ageSum / personList.Count; //[1]
            Console.WriteLine("the average age of the people in the list is "+ageAve.ToString());
            // youngest person and oldest person
            // order them into 

            // names of the people whos first name start with M

            // person info of the person that likes the colour blue



            //References
            //[1]https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.count?view=net-7.0 

        }
    }
}
