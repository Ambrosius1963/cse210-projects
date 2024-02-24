
// -------------------------------------------
// |         ReflectionActivity              |
// -------------------------------------------
// | - prompts: string[]                    |
// | - questions: string[]                  |
// -------------------------------------------
// | + Execute(): override void             |
// -------------------------------------------


public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.\n") { }

    public override void Execute()
    {
        Start();
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        bool continueReflection = true;
        while(continueReflection){
            Console.WriteLine(prompt);

            DateTime startTime = DateTime.Now;
            bool questionPrinted = false;

            while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
            {    
                if (!questionPrinted)
                {
                DotAnimationIn();
                DotAnimationOut();
                Random random = new Random();
                string question = questions[random.Next(questions.Length)];
                Console.WriteLine(question);
                questionPrinted = true;
                }            
            }
            Console.Write("\nContinue Reflecting? (y/n) ");
            ConsoleKeyInfo choice = Console.ReadKey();
            if (choice.KeyChar == 'y'){
                Console.Clear();
                continue;
            }
            else if (choice.KeyChar == 'n'){
                End();
                continueReflection = false;
            }
            else{
                Console.WriteLine("\nInvalid choice. Please enter y or n.");
            }
        }
        
    }
    
}