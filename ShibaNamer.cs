

namespace ShibaNamer
{
    using System;
    using System.Collections;
    using System.Data;

    class NewShiba
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string ?accept = "";   //Accepts Y/N input.
            bool valid = false;   //Used to determine whether or not a Yes/No answer is valid.
            bool nameCheck = false;

            string ?shibaName = "";
            int ?shibaAge = 0;

            Typewriter("There's a new shiba on the block!\n");
            Typewriter("What is the name of the new shoober?\n");
            
            while (valid == false)
            {
                if (nameCheck == false)
                    {
                        shibaName = Console.ReadLine();
                        Console.WriteLine("");
                        Typewriter($"So this new goofball is named {shibaName}? Are you positive? Y/N\n");
                        nameCheck = true;
                    }
                accept = Console.ReadLine(); 
                switch (accept.ToLower())
                    {
                    case "y":
                        Typewriter($"Perfect! The new shiba's name is {shibaName}! \n");
                        valid = true;
                        Continue();
                        break;
                    case "n":
                        Typewriter($"That's fine, perhaps {shibaName} just isn't the right fit. Choose a new name.\n");
                        nameCheck = false;
                        break;
                    default:
                        Typewriter("That isn't a valid response. Try again.\n");
                        break;
                    }
            }
            Typewriter($"How old is {shibaName}?\n");
            try
                {
                    shibaAge = Int32.Parse(Console.ReadLine());
                }
            catch
                {
                    Random chooseAge = new Random();
                    shibaAge = chooseAge.Next(1,8);
                    Typewriter($"Invalid input. Automatically assigning age.\n");
                }
            Typewriter($"{shibaName}'s age is {shibaAge}.");

        }
            static void Continue()                     //Asks for an input before continuing; deletes the Continue prompt and any inputs.
        {
            System.Threading.Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press Any Key to Continue →");
            Console.ReadKey(true);

            int length = "Press Any Key to Continue →".Length;

            for (int i = 0; i < length; i++)
                Console.Write("\b \b");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
        }  
            static void Typewriter(String message)      //An effect for displaying text gradually rather than all at once.
        {
            for (int text = 0; text < message.Length; text++)
            {
                Console.Write(message[text]);
                System.Threading.Thread.Sleep(1);
            }
        }
    }

    
}