using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "         Hello World!          ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            string sayHello = "Hello World!";
            Console.WriteLine($"{sayHello}");

            sayHello = sayHello.Replace("Hello", "Greeting");
            Console.WriteLine($"{sayHello}");

            //Convertir a mayúsculas
            sayHello = sayHello.ToUpper();
            Console.WriteLine($"{sayHello}");

            //Convertir texto a minúsculas
            sayHello = sayHello.ToLower();
            Console.WriteLine($"{sayHello}");

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

        }
    }
}
