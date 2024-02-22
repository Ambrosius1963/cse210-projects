public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // The "base" constructor is the "Assignment" class constructor.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // set the MathAssignment variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}