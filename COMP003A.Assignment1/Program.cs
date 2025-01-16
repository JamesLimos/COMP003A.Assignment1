/* 
 * Author: James Limos
 * Course: Comp-003A
 * Faculty: Jonathan Cruz
 * Purpose: 10 Things About Me
 */
// namespace level
namespace COMP003A.Assignment1
{
    internal class Program
    {
        // main level
        static void Main(string[] args)
        {
            //promp user for input
            Console.WriteLine("Enter your name: ");
            string Username = Console.ReadLine(); // gets the user input  
            Console.WriteLine("Hello, " + Username + "! My name is James.");
            Console.WriteLine("Here are 10 things about me:");
            Console.WriteLine("1. I was born in the Phillippines.");
            Console.WriteLine("2. I grew up in Hawaii.");
            Console.WriteLine("3. My favorite hobby is playing video games.");
            Console.WriteLine("4. My favorite game of all time is The Witcher 3: Wild Hunt.");
            Console.WriteLine("5. I am really into Warhammer 40k.");
            Console.WriteLine("6. I like to read mostly science fiction books.");
            Console.WriteLine("7. I am a big fan of action movies like the John Wick series.");
            Console.WriteLine("8. I like to binge tv-shows while I play video games.");
            Console.WriteLine("9. I enjoy listening to Jazz or Hip-Hop music.");
            Console.WriteLine("10.I have a Dog named Malia.");
            Console.ReadKey();

   
        }
    }
}