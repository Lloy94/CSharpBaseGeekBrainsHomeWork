using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace CsvToXml

//Тимофеев
//Написать программу-преобразователь из CSV в XML-файл с информацией о студентах
{
    class Program
    {
        static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentInfo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Преобразование csv в xml");

            Converter();

            Console.WriteLine("Преобразование окончено");
            Console.ReadLine();
        }
    }
}