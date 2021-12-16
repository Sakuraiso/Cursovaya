using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Gruz : Auto
    {
        public Gruz(int Speed, int Massa, int Payload, int Petrol) : base(Speed, Massa, Payload, Petrol) { }
        public override void Print()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Грузовой автомобиль");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Скорость = {0}", Speed);
            Console.WriteLine("Масса = {0}", Massa);
            Console.WriteLine("Грузоподъемность = {0}", Payload);
            Console.WriteLine("Эффективность = {0}", Calc());
            Console.WriteLine("Бензин = {0}", Petrol);
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
