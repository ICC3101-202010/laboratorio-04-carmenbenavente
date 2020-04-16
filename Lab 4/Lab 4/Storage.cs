using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Storage : Machine, IRestart
    {
        public int m;
        public bool s;
        public Storage(int m, bool s)
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
            List<int> Mem = new List<int>(m);
            return Mem;
        }
        public override void On()
        {
            s = true;
            Console.WriteLine("The Storage Machine is On");
        }
        public override void Off()
        {
            s = false;
            Console.WriteLine("The Storage Machine is Off");
        }
        public void Restart()
        {
            Memory().Clear();
        }
    }
}