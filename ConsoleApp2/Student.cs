using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Student
    {
        public string Name { get; set; }
        public int Score { get; set;}

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
