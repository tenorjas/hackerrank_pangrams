using System;

namespace pangrams
{
    class Program
    {
        static void determineIfIsPangram(string s)
        {
            if (s.ToLower().Contains("a") && s.ToLower().Contains("b") && s.ToLower().Contains("c") && s.ToLower().Contains("d") && s.ToLower().Contains("e") && s.ToLower().Contains("f") && s.ToLower().Contains("g") && s.ToLower().Contains("h") && s.ToLower().Contains("i") && s.ToLower().Contains("j") && s.ToLower().Contains("k") && s.ToLower().Contains("l") && s.ToLower().Contains("m") && s.ToLower().Contains("n") && s.ToLower().Contains("o") && s.ToLower().Contains("p") && s.ToLower().Contains("q") && s.ToLower().Contains("r") && s.ToLower().Contains("s") && s.ToLower().Contains("t") && s.ToLower().Contains("u") && s.ToLower().Contains("v") && s.ToLower().Contains("w") && s.ToLower().Contains("x") && s.ToLower().Contains("y") && s.ToLower().Contains("z"))
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }
        static void Main(string[] args)
        {
            // While loop to read STDIN and get string UNTIL no more input
            // call determineIfIsPangram with that string
            while (true) {
                string input = Console.ReadLine();
                if (input == null) {
                    break;
                }
                determineIfIsPangram(input);
            }
        }
    }
}
