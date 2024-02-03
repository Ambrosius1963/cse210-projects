public class Entry {

    public DateTime Date { get; set; }
    public string Thoughts { get; set; }
    public string Prompt { get; set; }


    public void DisplayEntry() {
        Console.WriteLine($"{Date.ToString("MM/dd/yyyy hh:mm")} ~ Prompt: {Prompt} \nThoughts: {Thoughts}");
    }


}