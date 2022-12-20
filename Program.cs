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
                Console.WriteLine("1. Enter First Name\n2. Enter Last Name");
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
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}