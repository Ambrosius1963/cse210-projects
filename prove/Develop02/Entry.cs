public class Entry {

    public DateTime Date { get; set; }
    public string Thoughts { get; set; }
    public string Prompt { get; set; }


    public void DateAndTime(){
        // Get the current date and time
        DateTime currentDateTime = DateTime.Now;
        // Display the date and time
        // Console.WriteLine($"Current Date and Time: {currentDateTime.ToString("MM/dd/yyyy hh:mm")}"); //dddd, MMMM d, yyyy h:mm tt
    }
    public List<PromptGen> prompts = new List<PromptGen>();

    public void PromptGen(){
        Console.WriteLine(prompts);
    }
    public void DisplayEntry() {
        Console.WriteLine($"{Date.ToString("MM/dd/yyyy hh:mm")} ~ Prompt: {Prompt} \nThoughts: {Thoughts}");
    }


}