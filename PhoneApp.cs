using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneApp : IPersonService
    {
        List<Person> Person = new List<Person>();

        public PhoneApp()
        {
            Person.Add(new Person("Ali", "Kaya", "123"));
            Person.Add(new Person("Ahmet", "Kaya", "123"));
            Person.Add(new Person("Ayşe", "Kaya", "123"));



            foreach (var person in Person)
            {
                Console.WriteLine("Name: "+person.Name+ 
                 " Surname: " + person.Surname+ 
                 " Phone Number: " + person.PhoneNumber);
            }
        }

        public void AddPhoneNumber()
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            Person.Add(new Person(firstName, lastName, phoneNumber));
            Console.WriteLine("Person is succesfully added!");
        }

        public void RemovePhoneNumber()
        {
            Console.WriteLine("Enter the first name of the person to remove:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name of the person to remove:");
            string lastName = Console.ReadLine();

            Person personToRemove = Person.Find(p => p.Name == firstName && p.Surname == lastName);

            if (personToRemove != null)
            {
                Person.Remove(personToRemove);
                Console.WriteLine("Person removed.");
            }
            else
            {
                Console.WriteLine("Person not found.");

                while (true)
                {
                    Console.WriteLine("1. Silmeyi Sonlandır");
                    Console.WriteLine("2. Yeniden dene");

                    int choice=int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            return;
                            break;
                        case 2:
                            RemovePhoneNumber();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                }
            }
        }
        public void UpdatePhoneNumber()
        {
            Console.WriteLine("Enter the index of the person to update:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index < Person.Count)
            {
                Console.WriteLine("Enter new phone number:");
                string newPhoneNumber = Console.ReadLine();

                Person[index].PhoneNumber = newPhoneNumber;
                Console.WriteLine("Phone number updated.");
            }
            else
            {
                Console.WriteLine("Person not found.");

                while (true)
                {
                    Console.WriteLine("1. Güncellemeyi Sonlandır");
                    Console.WriteLine("2. Yeniden dene");

                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            return;
                            break;
                        case 2:
                            UpdatePhoneNumber();
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                }
            }
        }
        public void ListPhoneNumbers()
        {
            Console.WriteLine("Phone numbers in the contacts:");

            for (int i = 0; i < Person.Count; i++)
            {
                Console.WriteLine($"Index: {i}");
                Console.WriteLine($"First Name: {Person[i].Name}");
                Console.WriteLine($"Last Name: {Person[i].Surname}");
                Console.WriteLine($"Phone Number: {Person[i].PhoneNumber}");
                Console.WriteLine();
            }
        }

        public void SearchPerson()
        {
            Console.WriteLine("Enter the first name or surname of the person ");
            string nameToSearch = Console.ReadLine();
            List<Person> searchResults=  Person.FindAll(p=>p.Name.ToLower().Contains(nameToSearch.ToLower()) || 
            p.Surname.ToLower().Contains(nameToSearch.ToLower()));

            if(searchResults.Count > 0)
            {
                foreach (var person in searchResults)
                {
                    Console.WriteLine($"First Name: {person.Name}");
                    Console.WriteLine($"Last Name: {person.Surname}");
                    Console.WriteLine($"Phone Number: {person.PhoneNumber}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }
    }
}
