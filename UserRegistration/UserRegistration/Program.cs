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
            Console.WriteLine(validator.ValidateMobileNumber("91 7349312654"));
            Console.WriteLine(validator.ValidatePassword("Ka12#@aska"));
            Console.WriteLine("Enter the email to check");
            string EmailIds = Console.ReadLine();
            Console.WriteLine(validator.ValidateEmailIds(EmailIds));
            Console.ReadKey();
        }
    }
}
