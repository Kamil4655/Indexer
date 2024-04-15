using TeacherWriteBySabir.Models;
namespace TeacherWriteBySabir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("zehmet olmasa ad daxil edin:");
                string name = Console.ReadLine();
                try
                {
                    Person person = new Person(name);
                    Console.WriteLine(person.Name);
                    break;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

            } while (true);
        }
        public static Person CreatePerson()
        {
            Console.WriteLine("zehmet olmasa ad daxil edin:");
            string name = Console.ReadLine();
            try
            {
                Person person = new Person(name);
                return person;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return CreatePerson();
            }
        }
    }
}