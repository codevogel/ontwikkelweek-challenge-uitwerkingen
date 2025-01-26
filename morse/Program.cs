class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      string morse = args[0];

      // We maken een map van stukjes morse naar de bijbehorende karakters
      Dictionary<string, char> morseToCharMap = new Dictionary<string, char>
      {
         {"-", 'T'},
         {"--", 'M'},
         {".-", 'A'},
         {"-.", 'N'},
         {"---", 'O'},
         {".", 'E'}
      };

      // We splitsen de morse string op in woorden
      string[] words = morse.Split('/');

      // Voor elk woord...
      foreach (string word in words)
      {
         // ... splitsen we het woord op in de stukjes morse
         string[] parts = word.Split(' ');
         // Voor elk stukje morse...
         foreach (string part in parts)
         {
            // ... printen we het bijbehorende karakter
            Console.Write(morseToCharMap[part]);
         }
         // Na elk woord printen we een spatie
         Console.Write(" ");
      }
      // We eindigen met een nieuwe regel
      Console.WriteLine();
   }
}
