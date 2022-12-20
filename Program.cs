namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration\n1. To Enter First Name");
            int commmand = Convert.ToInt32(Console.ReadLine());
            switch (commmand)
            {
                case 1:
                    FirstName firstname = new FirstName();
                    firstname.First();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            
        }
    }
}