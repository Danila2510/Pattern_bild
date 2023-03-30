using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Venchile
    {
        public string Body_count { get; set; }
        public int Body_Power { get; set; }
        public int Wheels { get; set; }
        public string Transfer { get; set; }
        public Venchile() { }
        public Venchile(string body_count, int body_power, int wheels, string trans)
        {
            Body_count = body_count;
            Body_Power = body_power;
            Wheels = wheels;
            Transfer = trans;
        }
        public override string ToString()
        {
            return $"Тело{Body_count}\nСила{Body_Power}\nКоляска{Wheels}\nТрансмисия{Transfer}";
        }
    }

    interface Venchile_Builder
    {
        void Body_Build();
        void Power_Build();
        void Wheel_Build();
        void Trans_Build();
        Venchile Get_Car();
    }

    class Car_Builder_1 : Venchile_Builder
    {
        private Venchile car;
        public void Body_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_count = "Седан";
        }
        public void Power_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_Power = 98;
        }
        public void Wheel_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Wheels = 13;
        }
        public void Trans_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Transfer = "5 Руководство";
        }
        public Venchile Get_Car()
        {
            if (car == null)
                return null;
            return car;
        }
    }
    class Car_Builder_2 : Venchile_Builder
    {
        private Venchile car;
        public void Body_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_count = "Купе";
        }
        public void Power_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_Power = 160;
        }
        public void Wheel_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Wheels = 14;
        }
        public void Trans_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Transfer = "4 Авто";
        }
        public Venchile Get_Car()
        {
            if (car == null)
                return null;
            return car;
        }
    }
    class Car_Builder_3 : Venchile_Builder
    {
        private Venchile car;
        public void Body_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_count = "Универсал";
        }
        public void Power_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_Power = 120;
        }
        public void Wheel_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Wheels = 16;
        }
        public void Trans_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Transfer = "4 Руководство";
        }
        public Venchile Get_Car()
        {
            if (car == null)
                return null;
            return car;
        }
    }
    class Car_Builder_4 : Venchile_Builder
    {
        private Venchile car;
        public void Body_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_count = "Хетчбэк";
        }
        public void Power_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Body_Power = 66;
        }
        public void Wheel_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Wheels = 13;
        }
        public void Trans_Build()
        {
            if (car == null)
                car = new Venchile();
            car.Transfer = "4 авто";
        }
        public Venchile Get_Car()
        {
            if (car == null)
                return null;
            return car;
        }
    }

    class Shop_Pokypka
    {
        private Venchile_Builder car;
        public void Car()
        {
            Console.WriteLine("Введите номер производителя автомобилей\n");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
                car = new Car_Builder_1();
            if (choose == 2)
                car = new Car_Builder_2();
            if (choose == 3)
                car = new Car_Builder_3();
            if (choose == 4)
                car = new Car_Builder_4();
            else
                car = null;
        }
        public void BuildCar()
        {
            if (car == null)
                car = new Car_Builder_1();
            car.Body_Build();
            car.Trans_Build();
            car.Power_Build();
            car.Wheel_Build();
        }
        public Venchile_Builder Get_Car()
        {
            return car;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop_Pokypka();
            shop.Car();
            shop.BuildCar();
            var build = shop.Get_Car();
            Venchile car = build.Get_Car();
            Console.WriteLine(car);
        }
    }
}
