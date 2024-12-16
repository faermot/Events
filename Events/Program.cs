using Events.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        public static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задание №1/2/3\n");

            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);

            publisher.Notify += OnNotify;


            publisher.TriggerEvent("Произошло событие");

            subscriber.Notify += OnNotify;


            Console.WriteLine("-----------------");
            subscriber.TriggerEvent("Пупупупу");

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Выберите задание: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Task1();
                        }
                        break;

                    case "2":
                        {
                            Task1();
                        }
                        break;

                    case "3":
                        {
                            Task1();
                        }
                        break;


                    default:
                        Console.WriteLine("\nВыберите корректное задание!");
                        Thread.Sleep(3000);
                        break;
                }
            }
        }

        private static void OnNotify(object sender, EventArgs e, string message)
        {
            Console.WriteLine(message);
        }
    }
}
