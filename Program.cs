using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
   

    class Bus
    {

        public override bool Equals(Object obj)
        {
                return base.Equals(obj);
        }

        public override int GetHashCode()
        {
           return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Bus: " + base.ToString() + " \tBrand: " + brand + " \tYear: " + year + " \tDriver: " + surname;
        }
        public static uint BusCount { get; private set; }

        public string surname;
        public int busnumber;
        public int  routenumber;
        public int year;
        public static int traveled;

        public partial class Part
        { int a; }

        static void Method() //статический метод
        {
            Console.WriteLine(traveled);
        }

        


        public Bus() //конструктор по умолчанию
        {
            busnumber = GetHashCode();
            
        }

        private Bus(int rn, string name, int bn) : this() //закрытый конструктор
        {
            this.routenumber = rn;
            this.surname = name;
            this.busnumber = bn;
            BusCount++;

        }
        static Bus() //статистический конструктор
        {
            Console.WriteLine("Статический конструктор (cоздание первого объекта)\n");
            BusCount = 0;
        }
        public Bus(int routeNumber, string sname, int bnum, int yr, int trav, string bd)
        {
            routenumber = routeNumber;
            surname= sname;
            busnumber = bnum;
            year = yr;
            traveled = trav;
            brand = bd;
        }
       
        public string brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        private string _brand = "";
        public int term
        {
            get { return busnumber; }
            set
            {
                if (value > 0)
                    busnumber = value;
                else Console.WriteLine("Error");

            }
        }
        public Bus(string a)
        {
            a = surname;
            Console.WriteLine("Имя: {0}\n", surname);
        }
   }

    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus();
            //Console.ReadKey();
            int x = 10;
            ref int xRef = ref x;
            Bus[] arr = new Bus[10];
            arr[0] = new Bus(14, "Petrov", 24, 1999, 200000, "Fiat");
            arr[1] = new Bus(11, "Topalov", 25, 2000, 200100, "Ford");
            arr[2] = new Bus(12, "Ropar", 26, 1998, 150000, "Lada");
            arr[3] = new Bus(9, "Kol", 27, 1997, 190200, "Gaz");
            arr[4] = new Bus(85, "Pol", 28, 1999, 220050, "BMW");
            arr[5] = new Bus(23, "Ulkil", 29, 2000, 180070, "Mers");
            arr[6] = new Bus(14, "Wilop", 30, 1987, 200500, "Fiat");
            arr[7] = new Bus(7, "Aliik", 31, 1979, 230080, "Ciat");
            arr[8] = new Bus(14, "Doplik", 32, 2001, 200700, "Gaz");
            arr[9] = new Bus(10, "Willoc", 33, 1999, 199000, "Fiat");
            
            foreach(var el in arr)
            {
                Console.WriteLine(el);
            }

            BusList(arr);
            BusList_Date(arr);


            Console.ReadKey();
        }
        //список автобусов для заданного номера маршрута;
        static void BusList(Bus[] arr)
        {
            Console.WriteLine("\nСписок автобусов:\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].routenumber==14)
                { Console.WriteLine(arr[i] + "\n"); }
            }
        }

        //список автобусов, которые эксплуатируются больше заданного срока;
        
        static void BusList_Date(Bus[] arr)
        {
            Console.WriteLine("Список автобусов (До 2001 г.в.):\n");
            for (int i = 0; i < arr.Length; i++)
            {
                
                    if (arr[i].year < 2001)
                    { Console.WriteLine(arr[i] + "\n"); }
                
            }
        }

    }


}
