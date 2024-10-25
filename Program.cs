using System.Reflection.Metadata.Ecma335;

namespace Topic_8_loops_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "trinity", "Neo", "morphius", "smith" };
            Console.WriteLine(names[1] + " is 'the one'.");
            Console.WriteLine(names[2] + " is 'The bad guy'.");
            Console.WriteLine("There are " + names.Count + " names on my list.");
            names[3] = "Mr aldworth";
            Console.WriteLine(names[3] + " is a coding teacher");
            

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + ". " + names[i]);

            }

        }
    }
}
