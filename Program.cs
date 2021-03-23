using System;
using System.IO;

namespace Trying_HTML_Page
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            //build html string
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc; font-size: 9pt; font-family:arial'>";

            //adding header row
            html += "<tr>";
            html += "</th style='background-color: red; border: 1px solid #ccc'>Name</th>";
            html += "</tr>";

            //Adding DataRow
            html += "<tr>";
            html += "<td style='width:1120px; border: 1px solid #ccc'>" + name + "</td>";
            html += "</tr>";

            //table end
            html += "</table>";

            //now creating html file
            File.WriteAllText(@"C:\Users\james\Desktop\devCodeCamp\Try_html\console.htm", html);
            Console.WriteLine("Html file created");
            Console.ReadLine();

            

        }
    }
}
