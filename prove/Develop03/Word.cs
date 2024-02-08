
// ===============================
//             Word
// -------------------------------
//     - string _word
//     - bool _isHidden
// -------------------------------
//     + Word(word, isHidden)
//     + SetIsHidden(isHidden)
//     + GetWord()
//     + IsHidden()
// ===============================

public class Word
{
    private string _word;
    private bool _isHidden;

    // Constructor
    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    // Method to set the hidden status of the word
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    // Method to get the word
    public string GetWord()
    {
        return _word;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
}
