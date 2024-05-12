using System.Globalization;
/*
 Доповнити проєкт з попереднього домашнього завдання можливістю
виконувати перевірку коректності вхідних даних при введені значення
максимальної швидкості автомобіля. Генерувати виняткову ситуацію якщо
вводиться від’ємне значення швидкості або якщо значення швидкості
перевищує 300 км/год.
 */
namespace EpamHW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Automobile> cars = new List<Automobile>();
                cars.Add(new Automobile("Toyota", 150));
                cars.Add(new Automobile("BMW", 200));
                cars.Add(new Automobile("Skoda", 400));
                    foreach (Automobile car in cars) // виняткова ситуація 
                    {
                        if (car.MaxSpeed <= 0 || car.MaxSpeed > 300)
                        {
                            string s = String.Format("Недопустима швидкiсть");
                            throw new Exception(s);
                        }
                    }
            
                foreach (Automobile car in cars)
                {
                    Console.WriteLine($"Машина {car.Name} має швидкiсть {car.MaxSpeed}");
                }
                static Automobile FindFastestcar(List<Automobile> array)
                {
                    Automobile max = array[0];
                    foreach (Automobile car in array)
                    {
                        if (car.MaxSpeed >= max.MaxSpeed)
                        {
                            max = car;
                        }
                    }
                    return max;
                }
                Automobile a = FindFastestcar(cars);
                Console.WriteLine("Найшвидша машина " + a.Name + " зi швидкiстю " + a.MaxSpeed);
            }
            catch (Exception e) // перевірка коректності
            {
                Console.WriteLine("Помилка: {0} ", e.Message);
            }

        }
    }
}