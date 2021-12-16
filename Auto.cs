using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Auto : Transport 
    {
        protected int Petrol;

        public Auto(int Speed, int Massa, int Payload, int Petrol) : base(Speed, Massa, Payload)
        {
            this.Petrol = Petrol;
        }
        public override void Print() { }
        public override double Calc()
        {
            return (double)Payload / (double)Petrol;
        }

    }
}
