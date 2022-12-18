namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;

            do
            {
                Console.WriteLine("Pick a number from 1- 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low.");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($" {userInput} is too high.");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                }

            } while (userInput != favNumber);
        
        
        }
        public void main(string[] args)
        {
            // Switch-Case

            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch(subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I hate math");
                    break;
                case "science":
                    Console.WriteLine("I love science.");
                    break;
                case "PE":
                    Console.WriteLine("PE is the best");
                    break;
                case "history":
                    Console.WriteLine("I love history.");
                    break;
                case "spanish":
                    Console.WriteLine("Spanish is no bueno!");
                    break;
                default:
                    Console.WriteLine("I dont know that Subject");
                    break;


            }

        }
    }
}
