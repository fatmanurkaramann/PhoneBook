using PhoneBook;

internal class Program
{
    public static void Main(string[] args)
    {
        PhoneApp phoneApp = new PhoneApp();
        
        while (true)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Add phone number");
            Console.WriteLine("2. Remove phone number");
            Console.WriteLine("3. Update phone number");
            Console.WriteLine("4. List Phone");
            Console.WriteLine("5. Search Phone");
            Console.WriteLine("6. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    phoneApp.AddPhoneNumber();
                    break;
                case 2:
                    phoneApp.RemovePhoneNumber();
                    break;
                case 3:
                    phoneApp.UpdatePhoneNumber();
                    break;
                case 4:
                    phoneApp.ListPhoneNumbers();
                    break;
                case 5:
                    phoneApp.SearchPerson();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

    }
}