namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            // cw {TAB} => System.Console.WriteLine(........)
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public Person Parse(string personName)
        {
            var person = new Person();
            person.Name = personName;

            return person;
        }

    }

    class Program
    {
        /*
         * All Programs have a static Main Function that accepts an array of arguments
         * 
         * In our static main we have a new instance of the Person class.  Note the 
         * variable (var) is in Camel Case.  This is not clear because the name person is
         * only one word.  however it could have been personThing1 = new Person()
         * camelCase is used for naming variables.  
         * 
         * Also note the different types of comments.  A single line is indicated by //
         * You can use the Keyboard shortcut CTRL + K + C to manage comments.  Click
         * anywhere in an individual line and use the shortcut to comment out just the one line
         * or highlight a series of lines and use the same shortcut to comment out all of the lines.
         */
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Thing 1";
            person.Introduce("Thing 2");
        }
    }
}
