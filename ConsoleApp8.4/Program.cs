using Newtonsoft.Json;
using System;
using System.IO;

namespace ConsoleApp8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "data.json";

            string fullName = "";
            string street = "";
            string houseNumber = "";
            int flatNumber = 0;
            string mobilePhone = "";
            string flatPhone = "";

            Console.WriteLine("фио");
            fullName = Console.ReadLine();
            Console.WriteLine("Улица");
            street = Console.ReadLine();
            Console.WriteLine("Номер дома");
            houseNumber = Console.ReadLine();
            Console.WriteLine("Номер квартиры");
            int.TryParse(Console.ReadLine(),out flatNumber);
            Console.WriteLine("Мобильный телефон");
            mobilePhone = Console.ReadLine();
            Console.WriteLine("Домашний телефон");
            flatPhone = Console.ReadLine();

            Contact contact = new Contact(fullName,street,houseNumber,flatNumber,mobilePhone,flatPhone);

            string json1 = JsonConvert.SerializeObject(contact);

            File.WriteAllText(fileName, json1);
        }
    }
}
