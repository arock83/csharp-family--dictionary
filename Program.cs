using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Define a Dictionary that contains information about several 
            //members of your family. Use the following example as a template.

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("mother", new Dictionary<string, string>(){ 
                {"name", "Suzy"},
                {"age", "63"}
            });
            myFamily.Add("father", new Dictionary<string, string>()
            {
                {"name", "Chuck"},
                {"age", "65"}
            });
            myFamily.Add("wife", new Dictionary<string, string>()
            {
                {"name", "Shannon"},
                {"age", "30"}
            });

            //Next, iterate over each item in myFamily and produce the following output.
            //Krista is my sister and is 42 years old
            
            foreach(KeyValuePair<string, Dictionary<string, string>> member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }

        }
    }
}
