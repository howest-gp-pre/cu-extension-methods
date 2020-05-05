using System;

namespace ProgrammingExpert.ExtensionMethods.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emailAdresses = { "wrong|email@mistakes.be", "eddy.vedder@pearl.jam.be", "slash@gunsnroses.be", "rock-'n-roll@music.be" };

            foreach (var emailAdress in emailAdresses)
            {
                Console.WriteLine($"{emailAdress} is{(emailAdress.IsValidEmailAddress() ? "" : "n't")} a valid emailadress");
            }

            Console.ReadLine();
        }
    }
}
