using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Start.Models;
using System.Threading;
using System.IO;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
           // var p = Person.GenerateListOfPeople();

            //Write all devs to text file 

            //Console.WriteLine("Getting all developers");
            //var allDevelopers = p.Where(x => x.Occupation.ToLower() == "developer");

            //string textToWrite = "";

            //Console.WriteLine("Building file content");
            //foreach (var dev in allDevelopers)
            //{
            //    textToWrite += $"Name: {dev.FirstName} {dev.LastName} Age: {dev.Age}" + Environment.NewLine + "_________________________________________" + Environment.NewLine;
            //}

            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) ;

            ////Console.WriteLine(docPath + @"\Developers.txt");

            //Console.WriteLine($"Writing to file at location: {docPath}" + @"\Developers.txt");
            //File.WriteAllText(docPath + @"\Developers.txt", textToWrite);

            string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string docPath = location + @"\fresh.txt";

            try
            {
                using (StreamReader sr = new StreamReader(docPath))
                {
                    string prince = sr.ReadToEnd();

                    foreach (char c in prince)
                    {
                        Console.Write(c);
                        Thread.Sleep(80);

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You done goofed");
                Console.WriteLine(e.Message);
            }


        }
    }
}
