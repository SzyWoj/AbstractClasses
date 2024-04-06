namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] garage = { new Car("Mustang", 4, 500), new Car("Subaru", 4, 350), new Car("Ford", 4, 200) };

            foreach(Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Console.ReadKey();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }

    class Car : Vehicle
    {
        public string model;
        public int wheels;
        public int maxSpeed;


        public Car(string model, int wheels, int maxSpeed)
        {
            this.model = model;
            this.wheels = wheels;
            this.maxSpeed = maxSpeed;
        }
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        public int maxSpeed = 50;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        public int maxSpeed = 100;
    }
}
