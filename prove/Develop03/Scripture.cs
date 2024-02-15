
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


//     public string GenerateFlashcard()
//     {
//         // Display scripture without reference
//         return _text;
//     }
// }
public class Scripture {
  
  // Encapsulates words as private member.
  private List<Word> words;

  // Constructor encapsulates splitting text into Word objects.
  public Scripture(string text) {
    this.words = text.Split(' ').Select((w, i) => new Word(w, i)).ToList();
  }

  // Method encapsulates logic to hide random words.
  public void HideWords(int numToHide = 3) {

    Random rnd = new Random();

    int availableWordCount = this.words.Count(w => !w.IsHidden());
    numToHide = Math.Min(numToHide, availableWordCount);

    for (int i = 0; i < numToHide; i++) {

      int index = rnd.Next(0, this.words.Count);
      while (this.words[index].IsHidden()) {
        index = rnd.Next(0, this.words.Count);
      }

      this.words[index].Hide();
    }
  }

  // Abstraction of words into string representation.
  public override string ToString() {
    
    string scriptureText = "";

    foreach (Word word in this.words) {
      scriptureText += word.ToString() + " ";
    }

    return scriptureText.Trim();

    // This whole method could be simplified to: 
    // return String.Join(" ", this.words.Select(w => w.ToString()));
  }

  // Encapsulates logic to print words.
  public void ViewWords() {
    foreach (Word word in this.words) {
      Console.WriteLine($"{word.GetIndex().ToString().PadRight(3)} {word.IsHidden().ToString().PadRight(6)} {word}");
    }
  }
}
