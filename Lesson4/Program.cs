using System;

namespace OOP2.Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new();
            building.SetParams();
            building.PrintInfo();
        }
    }
}
