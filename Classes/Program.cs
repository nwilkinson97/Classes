namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Thing 1";
            person.Introduce("Thing 2");
        }
    }
}
