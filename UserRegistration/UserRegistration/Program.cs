using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Validators validator = new Validators();
            Console.WriteLine(validator.ValidateFirstName("Shireen"));
        }
    }
}
