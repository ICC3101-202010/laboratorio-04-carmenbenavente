using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Machine> list = new List<Machine>();
            Computer computer = new Computer(10, false);
            list.Add(computer);
            Reception reception = new Reception(10, false);
            list.Add(reception);
            Storage storage = new Storage(10, false);
            list.Add(storage);
            Assembly assembly = new Assembly(10, false);
            list.Add(assembly);
            Verification verification = new Verification(10, false); 
            list.Add(verification);
            Packaging packaging = new Packaging(10, false);
            list.Add(packaging);

            int hour = 9;
            Console.WriteLine("The day start");
            while (hour < 19)
            {
                Console.WriteLine(hour + "hrs");
                if (hour == 9)
                {
                    foreach (Machine j in list)
                    {
                        j.On();
                    }
                    hour += 1;
                }
                else if (hour < 18)
                {
                    reception.Restart();
                    storage.Restart();
                    assembly.Restart();
                    verification.Restart();
                    packaging.Restart();
                    hour += 1;
                }
                else if (hour == 18)
                {
                    foreach (Machine j in list)
                    {
                        j.Off();
                    }
                    hour += 1;
                }
            }
            Console.WriteLine("The day is over");
            Console.ReadLine();
        }
    }
}
