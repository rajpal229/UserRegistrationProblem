namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            bool flag = true;
            while(flag = true)
            {
                Console.WriteLine("1. Enter First Name\n2. Enter Last Name\n3. Enter Email Address");
                int commmand = Convert.ToInt32(Console.ReadLine());
                switch (commmand)
                {
                    case 1:
                        FirstName firstname = new FirstName();
                        firstname.First();
                        break;
                    case 2:
                        LastName lastname = new LastName();
                        lastname.Last();
                        break;
                    case 3:
                        EmailAddress emailaddress = new EmailAddress();
                        emailaddress.Email();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}