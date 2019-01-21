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

        public static Person Parse(string personName)
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

            //  Note:  The Parse Method cannot be called until an instance of the Perosn Class can 
            //  be used.  This defeats the person of parsing a Person Object directly from a string.
            //  The reason we cannot see the Parse method is that it is not a static function.  Static
            //  Methods and Functions can be seen before an instance has been created.  

            //  If you remove the keyword "static" from the Method Introduce you will see an error 
            //  on the line where we create an instance of the Person Class by using the Parse Function.
            var personKing = Person.Parse("King Thing");
            personKing.Introduce("Chocolate Thunda");

            //  NOTE:  The difference between a Function and a Method can be simplified down to the fact
            //  that a Method will have no return value and a Function will always return some type of value.
        }
    }
}
