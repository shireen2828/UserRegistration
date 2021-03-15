using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validators validator = new Validators();
            Console.WriteLine(validator.ValidateFirstName("Shireen"));
            Console.WriteLine(validator.ValidateLastName("Mariyam"));
            Console.WriteLine(validator.ValidateEmailId("abc.xyz6@bl.co.in"));
            Console.ReadKey();
        }
    }
}
