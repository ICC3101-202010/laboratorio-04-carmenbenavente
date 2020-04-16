using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public abstract class Machine
    {
        public abstract bool Status();
        public abstract List<int> Memory();
        public abstract void On();
        public abstract void Off();
    }
}
