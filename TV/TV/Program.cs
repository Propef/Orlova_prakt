using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.IO;

using Microsoft.Win32;

using System.Security.Permissions;

namespace TV

{

    class TV

    {

        List<Channel> mas = new List<Channel>()

        {

            new Channel(1, "Союз"),

            new Channel(2, "Спас"),

            new Channel(3, "СТС"),

        };

        public void Start()

        {

            while (true)

            {

                Console.WriteLine("Выберите первоначальный канал (от 1 до 3 включительно)");

                int Num = int.Parse(Console.ReadLine());

                if (Num >= 4 || Num <= 0)

                {

                    Console.WriteLine("Дружище, ну сказано же от 1 до 3");

                }

                else

                {

                    Console.WriteLine(mas[Num - 1].ToString());

                    Console.WriteLine(@"Нажмите W для перехода на след канал,

Нажмите S для перехода к предыдущему каналу

или просто выберите канал цифрой");

                    while (true)

                    {

                        string Nimb = Console.ReadLine();

                        if (Nimb == "w" || Nimb == "W")

                        {

                            Num++;

                            if (Num > 3)

                            {

                                Num = 1;

                            }

                            Console.WriteLine("Вы на канале " + mas[Num - 1].ToString());

                        }

                        else if (Nimb == "s" || Nimb == "S")

                        {

                            Num--;

                            if (Num < 1)

                            {

                                Num = 3;

                            }

                            Console.WriteLine("Вы на канале " + mas[Num - 1].ToString());

                        }

                        else if (int.Parse(Nimb) <= 3 && int.Parse(Nimb) >= 1)

                        {

                            Console.WriteLine("Вы на канале " + mas[int.Parse(Nimb) - 1].ToString());

                        }

                        else

                        {

                            Console.WriteLine("Ну типа ошибочка вышла");

                        }

                    }

                }

            }

        }

    }

    class Channel

    {

        public int Now;

        public string Nazv;

        public Channel(int now, string nazv)

        {

            Now = now;

            Nazv = nazv;

        }

        public override string ToString()

        {

            return string.Format("{0} : {1}", Now, Nazv);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            TV dsa = new TV();

            dsa.Start();

            Console.ReadLine();

        }

    }

}
