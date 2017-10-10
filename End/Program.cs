using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using End.Models;
using System.Threading;

namespace End
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p = Person.GenerateListOfPeople();


            //Write all developers to txt file file 
            //var allDevelopers = p.Where(x => x.Occupation.ToLower() == "developer");

            //string textToWrite = "";

            //foreach (var dev in allDevelopers)
            //{
            //    textToWrite += $"Name: {dev.FirstName} {dev.LastName} Age: {dev.Age} " + Environment.NewLine + "____________________________________" + Environment.NewLine; 
            //}

            ////Console.WriteLine(textToWrite);
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //File.WriteAllText(docPath + @"\Developers.txt", textToWrite);



            //Make a program that writes all accountants over the age of 35 to a txt file

            //var allAccountantsOver35 = p.Where(x => x.Age >= 30 &&  x.Occupation.ToLower() == "accountant");

            //string textToWrite = "";

            //foreach (var acc in allAccountantsOver35)
            //{
            //    textToWrite += $"Name: {acc.FirstName} {acc.LastName} Age: {acc.Age} " + Environment.NewLine + "____________________________________" + Environment.NewLine;
            //}

            ////Console.WriteLine(textToWrite);
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //File.WriteAllText(docPath + @"\Accountants.txt", textToWrite);



            //Read from a text file 

            //string location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //string docPath = location + @"\fresh.txt";

            ////Console.WriteLine(docPath);

            //try
            //{
            //    using (StreamReader sr = new StreamReader(docPath))
            //    {
            //        string prince = sr.ReadToEnd();

            //        foreach (char c in prince)
            //        {
            //            Console.Write(c);
            //            Thread.Sleep(80);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("You done goofed; could not read file");
            //    Console.WriteLine(e.Message);
            //}


        }
    }
}
