class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      if (args.Length != 1)
      {
         Console.WriteLine("error: Voer hoogstens 1 zin in");
         return;
      }

      int countLetters = 0;
      int countCapital = 0;
      string sentence = args[0];

      foreach (char c in args[0])
      {
         if (char.IsAsciiLetter(c))
         {
            countLetters++;
         }
         if (char.IsUpper(c))
         {
            countCapital++;
         }
      }

      Console.WriteLine("Aantal letters: " + countLetters);
      Console.WriteLine("Aantal hoofdletters: " + countCapital);
   }
}
