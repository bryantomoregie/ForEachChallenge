using System;
using System.Collections.Generic;

namespace ForEachChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> strings = new List<string>();

            strings.Add("Bryant Omoregie");
            strings.Add("Chelsey Omoregie");
            strings.Add("Caydence Omoregie");

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


            Model Bryant = new Model
            {
                firstName = "Bryant",
                lastName = "Omoregie"
            };

            Model Chelsey = new Model
            {
                firstName = "Chelsey",
                lastName = "Omoregie"
            };

            Model Caydence = new Model
            {
                firstName = "Caydence",
                lastName = "Omoregie"
            };



            List<Model> models = new List<Model>();

            models.Add(Bryant);
            models.Add(Chelsey);
            models.Add(Caydence);

            foreach (var item in models)
            {
                Console.WriteLine($"{item.firstName} {item.lastName}");
            }
            Console.ReadLine();


        }
    }

    public class Model 
    {
        public string firstName { get; set; }
        public string  lastName { get; set; }
    }
}

/*
 Create a list of strings
foreach thru that list printing the strings

Create a list of models/objects
And have two properties.
print both strings.
 */
