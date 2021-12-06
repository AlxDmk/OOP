using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Lesson4
{
    public class Building {
        static int count = 1;
        private int _idOfBuilding;

        private double _height;
        private int _countOfFloors;
        private int _countOfApartments;
        private int _countOfEntrences;

        public Building()
        {
            GetNumberOfBuilding();
        }

        public void SetParams()
        {
            SetHeight();
            SetCountOfFloors();
            SetCountOfApartments();
            SetCountOfEntrences();
           
        }

       double SetHeight()
        {            
            Console.WriteLine("Высота здания:");
            try
            {
                return _height = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return _height;
            }            

        }
        int SetCountOfFloors()
        {
            Console.WriteLine("Введите количество этажей");
            try
            {
                return _countOfFloors = Convert.ToInt32(Console.ReadLine());
    
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return _countOfFloors;
            }
        }

        int SetCountOfApartments()
        {
            Console.WriteLine("Введите количество квартир");
            try
            {
                return _countOfApartments = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return _countOfApartments;
            }
        }

        int SetCountOfEntrences()
        {
            Console.WriteLine("Введите количество подъездов:");
            try
            {
                return _countOfEntrences = Convert.ToInt32(Console.ReadLine());

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return _countOfEntrences;
            }
        }

        (int, int, double) GetInfo()        {

            int CountOfAppartmentsPerEntrance = _countOfApartments / _countOfEntrences;
            int CountApartmentsPerFloor = CountOfAppartmentsPerEntrance / _countOfFloors;
            double HeightOfFloor = _height / _countOfFloors;
            return (CountOfAppartmentsPerEntrance, CountOfAppartmentsPerEntrance, HeightOfFloor);
        }
       
        public void PrintInfo()
        {
            Console.WriteLine(GetInfo());
           
        }
        


        



        private void GetNumberOfBuilding()
        {
            _idOfBuilding = count;
            count++;
        }

    }
}
