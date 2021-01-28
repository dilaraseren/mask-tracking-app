using Business.Concrete;
using Entities.Concrete;
using System;


namespace MaskeTakipUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Dilara";
            person1.LastName = "SEREN";
            person1.NationalIdentity = 1234567952;
            person1.DateOfBirthYear = 2000;

            Person person2 = new Person();
            person2.FirstName = "Serhat";
            person2.LastName = "Seren";
            person2.NationalIdentity = 15445545465;
            person2.DateOfBirthYear = 2003;

       
            

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person2);
            Console.ReadLine();
        }
    }
    
}
