
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

public class Word{


    private string _word;
    private bool _isHidden;

    // Constructor
    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    // Method to set the hidden status of the word
    public void SetHidden(bool hidden)
    {
        _isHidden = hidden;
    }

    // Method to get the word
    public string GetWord()
    {
        return _word;
    }

    // Method to check if the word is hidden
    public bool IsHidden(bool isHidden)
    {
        _isHidden = true;
    }
    public override string ToString()
    {
        if (!this.IsHidden){
            return this.text;
        }
        // Code to hide the word
        int len = Word.Length;
        string output = "";
        while (len > 0){
            output += "_";
            len -= 1;
        }
        return output;

    }
}
