namespace GA_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold Person objects, renamed as "schoolDatabase"
            List<Person> schoolDatabase = new List<Person>();

            // Add two instances of each derived class
            schoolDatabase.Add(new Student("John Doe", 12345, 3.8));
            schoolDatabase.Add(new Student("Alice Smith", 67890, 3.5));
            schoolDatabase.Add(new Professor("Dr. Smith", 101, "Computer Science"));
            schoolDatabase.Add(new Professor("Dr. Johnson", 102, "Mathematics"));
            schoolDatabase.Add(new Faculty("Jane Brown", 201, "Librarian"));
            schoolDatabase.Add(new Faculty("Mike Davis", 202, "Admissions"));

            // Loop through the list and display information for each person
            foreach (var person in schoolDatabase)
            {
                Console.WriteLine(person.GetDetails());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
