using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract
{

    public static class Program
    {
        static void Main(string[] args)
        {
            Transport[] Trans;
            Trans = new Transport[6];
            Trans[0] = new Taxi(250, 1, 1, 50);
            Trans[1] = new Gruz(120, 5, 3, 70);
            Trans[2] = new Tram(80, 4, 3, 3300);
            Trans[3] = new Tram(100, 3, 2, 3000);
            Trans[4] = new Troll(80, 4, 3, 3000);
            Trans[5] = new Troll(90, 4, 4, 4000);


            bool reload = true;
            while (reload)
            {
                reload = false;
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("1. Выбрать легковой автомобиль");
                Console.WriteLine("2. Выбрать грузовой автомобиль");
                Console.WriteLine("3. Список всех автомобилей");
                Console.WriteLine("4. Удалить автомобиль");
                Console.WriteLine("-------------------------------------------------------");
                string value = Console.ReadLine();
                if (value == "1")
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("1. Auto");
                    Trans[0].Print();
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Спасибо, вы выбрали легковой автомобиль!");
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                    value = Console.ReadLine();
                    if (value == "0")
                    {
                        reload = true;
                    }

                }
                else if (value == "2")
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("1. Выбрать автомобиль на бензине");
                    Console.WriteLine("2. Выбрать автомобиль на электричестве");
                    Console.WriteLine("-------------------------------------------------------");
                    value = Console.ReadLine();
                    if (value == "1")
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("2. Auto");
                        Trans[1].Print();
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Спасибо, вы выбрали грузовой автомобиль на бензине!");
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                        value = Console.ReadLine();
                        if (value == "0")
                        {
                            reload = true;
                        }
                    }
                    else if (value == "2")
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("1. Выбрать трамвай");
                        Console.WriteLine("2. Выбрать троллейбус");
                        Console.WriteLine("-------------------------------------------------------");
                        value = Console.ReadLine();
                        if (value == "1")
                        {
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("3. Auto");
                            Trans[2].Print();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("4. Auto");
                            Trans[3].Print();
                            Console.WriteLine("-------------------------------------------------------");
                            value = Console.ReadLine();
                            if (value == "3")
                            {
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("3. Auto");
                                Trans[2].Print();
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Спасибо, вы выбрали трамвай!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                            else if (value == "4")
                            {
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("4. Auto");
                                Trans[3].Print();
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Спасибо, вы выбрали трамвай!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                        }
                        else if (value == "2")
                        {
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("5. Auto");
                            Trans[4].Print();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("6. Auto");
                            Trans[5].Print();
                            Console.WriteLine("-------------------------------------------------------");
                            value = Console.ReadLine();
                            if (value == "5")
                            {
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("5. Auto");
                                Trans[4].Print();
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Спасибо, вы выбрали троллейбус!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                            else if (value == "6")
                            {
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("6. Auto");
                                Trans[5].Print();
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Спасибо, вы выбрали троллейбус!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                        }
                    }
                }
                else if (value == "3")
                {
                    foreach (Transport T in Trans)
                    {
                        T.Print();
                        Console.WriteLine();
                    }
                    Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                    value = Console.ReadLine();
                    if (value == "0")
                    {
                        reload = true;
                    }
                }
                else if (value == "4")
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine("1. Удалить автомобиль на бензине");
                    Console.WriteLine("2. Удалить автомобиль на электричестве");
                    Console.WriteLine("-------------------------------------------------------");
                    value = Console.ReadLine();
                    if (value == "1")
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("1. Удалить легковой автомобиль");
                        Console.WriteLine("2. Удалить грузовой автомобиль");
                        Console.WriteLine("-------------------------------------------------------");
                        value = Console.ReadLine();
                        if (value == "1")
                        {
                            Trans[0] = new Taxi(0, 0, 0, 0);
                            Console.WriteLine("Вы успешно удалили легковой автомобиль!");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                            value = Console.ReadLine();
                            if (value == "0")
                            {
                                reload = true;
                            }

                        }
                        else if (value == "2")
                        {
                            Trans[1] = new Taxi(0, 0, 0, 0);
                            Console.WriteLine("Вы успешно удалили грузовой автомобиль!");
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                            value = Console.ReadLine();
                            if (value == "0")
                            {
                                reload = true;
                            }
                        }

                    }
                    else if (value == "2")
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("1. Удалить трамвай");
                        Console.WriteLine("2. Удалить троллейбус");
                        Console.WriteLine("-------------------------------------------------------");
                        value = Console.ReadLine();
                        if (value == "1")
                        {
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("1 трамвай");
                            Trans[2].Print();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("2 трамвай");
                            Trans[3].Print();
                            Console.WriteLine("1. Удалить 1 трамвай");
                            Console.WriteLine("2. Удалить 2 трамвай");
                            Console.WriteLine("-------------------------------------------------------");
                            value = Console.ReadLine();
                            if (value == "1")
                            {
                                Trans[2] = new Taxi(0, 0, 0, 0);
                                Console.WriteLine("Вы успешно удалили 1 трамвай!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                            else if (value == "2")
                            {
                                Trans[3] = new Taxi(0, 0, 0, 0);
                                Console.WriteLine("Вы успешно удалили 2 трамвай!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                        }
                        else if (value == "2")
                        {
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("1 траллейбус");
                            Trans[4].Print();
                            Console.WriteLine("-------------------------------------------------------");
                            Console.WriteLine("2 траллейбус");
                            Trans[5].Print();
                            Console.WriteLine("1. Удалить 1 траллейбус");
                            Console.WriteLine("2. Удалить 2 траллейбус");
                            Console.WriteLine("-------------------------------------------------------");
                            value = Console.ReadLine();
                            if (value == "1")
                            {
                                Trans[4] = new Taxi(0, 0, 0, 0);
                                Console.WriteLine("Вы успешно удалили 1 траллейбус!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                            else if (value == "2")
                            {
                                Trans[5] = new Taxi(0, 0, 0, 0);
                                Console.WriteLine("Вы успешно удалили 2 траллейбус!");
                                Console.WriteLine("-------------------------------------------------------");
                                Console.WriteLine("Введите 0 чтобы вернуться на первую страницу");
                                value = Console.ReadLine();
                                if (value == "0")
                                {
                                    reload = true;
                                }
                            }
                        }
                    }

                }

            }
        }
    }
}