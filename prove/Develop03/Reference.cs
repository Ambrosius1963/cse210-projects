
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


public class Reference {

  private Scripture text;

  // Constructor encapsulates creation of a Scripture instance.
  public Reference(string text) { //string book, int chapter, string verse,

    this.text = new Scripture(text);
  }

  // Method to print the scripture reference from the scripture text
  public void PrintReference(string scripture)
  {
      // Split the scripture by '~' to separate the reference and text
      string[] parts = scripture.Split('~');
      
      if (parts.Length >= 2)
      {
          // Print the reference
          Console.WriteLine("\n\nReference:");
          Console.WriteLine(parts[0].Trim()); // Trim any extra whitespace
      }
      else
      {
          // If the format is incorrect, print a message
          Console.WriteLine("\n\nInvalid scripture format.");
      }
  }
  public void PrintVerse(string scripture)
  {
      // Split the scripture by '~' to separate the reference and text
      string[] parts = scripture.Split('~');
      
      if (parts.Length >= 2)
      {
          // Print the reference
          Console.WriteLine("\n\nVerse:");
          Console.WriteLine(parts[1].Trim()); // Trim any extra whitespace
      }
      else
      {
          // If the format is incorrect, print a message
          Console.WriteLine("\n\nInvalid scripture format.");
      }
  }

}
