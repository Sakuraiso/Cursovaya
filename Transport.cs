using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Transport : Interface
    {
        protected int Speed;
        protected int Massa;
        protected int Payload;

        public Transport(int Speed, int Massa, int Payload)
        {
            this.Speed = Speed;
            this.Massa = Massa;
            this.Payload = Payload;
        }
        public virtual void Print() { }
        public virtual double Calc() { return 0.0; }
    }
}
