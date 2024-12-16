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
        public static void TaskOneAndTwo()
        {
            Console.Clear();
            Console.WriteLine("Задание №1/2");

            Publisher publisher = new Publisher();


            publisher.Notify += OnNotify;

            Console.ReadKey();

            publisher.TriggerEvent("Произошло событие");

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
                            TaskOneAndTwo();
                        }
                        break;

                    case "2":
                        {
                            TaskOneAndTwo();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №3");
                            Publisher publisher = new Publisher();

                            Subscriber subscriber = new Subscriber(publisher);

                            publisher.TriggerEvent("тегаем подписчика");

                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №4");

                            Publisher publisher = new Publisher();
                            Subscriber subscriber = new Subscriber(publisher);

                            publisher.TriggerEvent("Тегаем");

                            subscriber.Unsubscribe(publisher);

                            publisher.TriggerEvent("Снова тегаем но ниче не будет");

                            Console.ReadKey();
                        }
                        break;

                    case "5":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №5");

                            Publisher publisher = new Publisher();

                            Subscriber subscriber1 = new Subscriber("Подписчик 1", publisher);
                            Subscriber subscriber2 = new Subscriber("Подписчик 2", publisher);

                            // Вызываем событие
                            publisher.TriggerEvent("Уведомление!");

                            Console.ReadKey();
                        }
                        break;

                    case "6":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание №6");

                            Console.WriteLine("Реализовано ранее");

                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        {

                            Console.Clear();
                            Console.WriteLine("Задание №7");

                            Console.WriteLine("Да ну типа сделано так же в третьем, прост там string а не int :/");
                            Console.WriteLine("Либо просто тип поменять либо ещё добавить, но это надо менять тест 3- го задания");
                            Console.WriteLine("Ну а мен лень");

                            Console.ReadKey();
                        }
                        break;

                    case "8":
                        {
                            Console.Clear();
                            Console.WriteLine("Задание 8");

                            Console.WriteLine("Как же лень было это делать, мега просто, но лень...");

                            PublisherTwo publisherTwo = new PublisherTwo();

                            void OnNotify(object sender, EventArgs e)
                            {
                                Console.WriteLine("Событие с использованием EventHandler!...");
                            }

                            publisherTwo.Notify += OnNotify;

                            publisherTwo.TriggerEvent();

                            Console.ReadKey();
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
