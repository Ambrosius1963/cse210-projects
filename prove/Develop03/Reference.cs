
// ===============================
//          Reference
// -------------------------------
//     - string _book
//     - int _chapter
//     - int _verse
// -------------------------------
//     + Reference(book, chapter, verse)
//     + override string ToString()
// ===============================


public class ScriptureReference {

  // Private members encapsulate the state of a scripture reference.
  private string book;
  private int chapter;
  private string verse;

  // The actual Scripture text is encapsulated in a separate class.
  // This abstraction separates concerns into different classes.
  private Scripture text;

  // Constructor encapsulates creation of a Scripture instance.
  public ScriptureReference(string book, int chapter, string verse, string text) {
    this.book = book;
    this.chapter = chapter;
    this.verse = verse;
    this.text = new Scripture(text);
  }

  // Method encapsulates logic to hide words in scripture text.
  public void HideWords(int numToHide = 3) {
    this.text.HideWords(numToHide);
  }

  // Abstraction of details into string representation.
  public override string ToString() {
    return $"{this.book} {this.chapter}:{this.verse}\n{this.text}";
  }

  // Encapsulates printing the full scripture reference.
  public void ViewScripture() {
    Console.WriteLine($"{this.ToString()}");
  }

  // Encapsulates printing just the scripture text words.
  public void ViewScriptureParts() {
    this.text.ViewWords();
  }
}
