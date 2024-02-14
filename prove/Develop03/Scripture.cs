
// ===============================
//          Scripture
// -------------------------------
//     - string _reference
//     - string _text
//     - List<Word> _words
// -------------------------------
//     + HideWord(word)
//     + RenderText()
// ===============================

using System.Collections.Generic;

public class Scripture{

    private string _reference;
    private string _text;
    private List<Word> _words;

    // Constructor
    
    public Scripture(string scripture)
    {

    }
    public Scripture(string scripture, string reference, string text, List<Word> words)
    {
        // Split scripture using "~"
        var parts = scripture.Split('~');
        _reference = parts[0].Trim();
        _text = parts[1].Trim();
        // split every at every word
        _words = _text.Split(" ").Select((w, i) => new Word(w, i)).ToList();
    }

    // Method to hide a word
    public void HideWords(Random rand, int count)
    {

        // Console.WriteLine(word);

        // var availableWords = _words.Where(w => !w.IsHidden).ToList();

        // for(int i = 0; i < count && i < availableWords.Count; i++);{
        //     var int = rand.Next(0, availableWords.Count);
        //     var word = availableWords[index];
        //     word.Hide();

        //     availableWords.RemoveAt(index);
        // }
    }

        public string GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return _text;
    }

    public string GenerateFlashcard()
    {
        // Display scripture without reference
        return _text;
    }
}
