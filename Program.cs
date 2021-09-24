using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Ford ford = new Ford();
            ford.Start();
            ford.Drive();
            ford.Brake();
            ford.Accelerate();

            Dodge dodge = new Dodge();
            dodge.Start();
            dodge.Drive();
            dodge.Brake();
            dodge.Accelerate();

            Toyota toyota = new Toyota();
            toyota.Start();
            toyota.Drive();
            toyota.Brake();
            toyota.Accelerate();

        }
    }
}
