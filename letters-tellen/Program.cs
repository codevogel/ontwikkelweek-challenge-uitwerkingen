// Hoofd class voor het programma.
class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   // Main is het startpunt van het programma.
   // Wanneer het programma wordt gestart middels de command line,
   // dan worden de argumenten meegegeven aan het programma.
   // Bijvoorbeeld: dotnet run "Dit is een zin"
   // Voor meer informatie, zie: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args/
   public static void Main(string[] args)
   {
      // Als er een verkeerd aantal argumenten is meegegeven, geef
      // een foutmelding en stop het programma.
      if (args.Length != 1)
      {
         Console.WriteLine("error: Voer hoogstens 1 zin in");
         return;
      }

      // Maak twee variabelen aan die het aantal letters en hoofdletters
      // bijhouden.
      int countLetters = 0;
      int countCapital = 0;

      // args[0] is de eerste string die is meegegeven aan het programma.
      string sentence = args[0];

      // Loop door elke letter in de string en kijk...
      foreach (char c in args[0])
      {
         // ... of het een letter is, en zo ja, verhoog countLetters.
         if (char.IsAsciiLetter(c))
            countLetters++;
         // ... of het een hoofdletter is, en zo ja, verhoog countCapital.
         if (char.IsUpper(c))
            countCapital++;
      }

      // Print het aantal letters en hoofdletters.
      Console.WriteLine("Aantal letters: " + countLetters);
      Console.WriteLine("Aantal hoofdletters: " + countCapital);
   }
}
