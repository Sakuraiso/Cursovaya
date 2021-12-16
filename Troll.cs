using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{
    internal class Troll : Electro
    {
        public Troll(int Speed, int Massa, int Payload, int Voltage) : base(Speed, Massa, Payload, Voltage) { }
        public override void Print()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Троллейбус");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Скорость = {0}", Speed);
            Console.WriteLine("Масса = {0}", Massa);
            Console.WriteLine("Грузоподъемность = {0}", Payload);
            Console.WriteLine("Эффективность = {0}", Calc());
            Console.WriteLine("Напряжение = {0}", Voltage);
            Console.WriteLine("-------------------------------------------------------");
        }

    }
}
