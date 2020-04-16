using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Computer : Machine
    {
        public int m;
        public bool s;
        public Computer(int m, bool s)
        {
            this.m = m;
            this.s = s;
        }
        public override bool Status()
        {
            return s;
        }
        public override List<int> Memory()
        {
            List<int> Mem = new List<int>();
            return Mem;
        }

        public override void On()
        {
            s = true;
            Console.WriteLine("The Computer Machine is On");
        }
        public override void Off()
        {
            s = false;
            Console.WriteLine("The Computer Machine is Off");
        }
        public void TurnOn(Machine mach)
        {
            mach.On();
        }
        public void TurnOff(Machine mach)
        {
            mach.Off();
        }
    }
}