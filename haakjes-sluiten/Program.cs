class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      string input = args[0];

      // Hou een stack bij van de haakjes die nog niet gesloten zijn.
      Stack<char> open_parentheses = new();

      // Loop over alle karakters in de input.
      foreach (char c in input)
      {
         // Als het karakter een openend haakje is, voeg het toe aan de stack.
         if (c == '(')
         {
            open_parentheses.Push(c);
         }
         // Als het karakter een sluitend haakje is,
         else if (c == ')')
         {
            // Als er geen geopende haakjes zijn, sluit dit haakje te vroeg.
            if (open_parentheses.Count == 0)
            {
               Console.WriteLine("Een haakje sluit te vroeg.");
               return;
            }
            // Als die er wel zijn, sluit het vorige geopende haakje
            // door het van de stack te halen.
            else
            {
               open_parentheses.Pop();
            }
         }
      }

      // Als er geen open haakjes meer zijn, is alles in orde.
      if (open_parentheses.Count == 0)
      {
         Console.WriteLine("Geen problemen gevonden.");
      }
      // Als er wel nog open haakjes zijn, is er een haakje te veel.
      else
      {
         Console.WriteLine("Er mist een sluitend haakje.");
      }
   }

}
