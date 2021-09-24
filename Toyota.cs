namespace AbstractClass
{
    public class Toyota : Vehicle
    {
        public override void Drive()
        {
            System.Console.WriteLine("The Toyota is driving");
        }
        
        public override void Brake()
        {
            System.Console.WriteLine("The Toyota is braking");
        }

        public override void Accelerate()
        {
            System.Console.WriteLine("The Toyota is accelerating");
        }
    }
}