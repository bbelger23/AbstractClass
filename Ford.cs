namespace AbstractClass
{
    public class Ford : Vehicle
    {
        public string Color { get; set; }

        public override void Drive()
        {
            System.Console.WriteLine("The Ford is driving");
        }

        public override void Start()
        {
            System.Console.WriteLine("The Ford has started");
        }

        public override void Brake()
        {
            System.Console.WriteLine("The Ford is braking");
        }
    }
}