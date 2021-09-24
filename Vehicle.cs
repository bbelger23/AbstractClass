namespace AbstractClass
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public abstract void Drive();
        public abstract void Brake();
        public virtual void Start()
        {
            System.Console.WriteLine("The vehicle has started");
        }
        public virtual void Accelerate()
        {
            System.Console.WriteLine("The vehicle is accelerating");
        }
        public void Stop()
        {
            System.Console.WriteLine("The vehicle is stopped");
        }

    }
}