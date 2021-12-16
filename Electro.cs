using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Electro : Transport 
    {
        protected int Voltage;

        public Electro(int Speed, int Massa, int Payload, int Voltage) : base(Speed, Massa, Payload)
        {
            this.Voltage = Voltage;
        }
        public override void Print() { }
        public override double Calc()
        {
            return (double)Payload / (double)Voltage;
        }
    }
}
