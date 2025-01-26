class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      // Het eerste argument is de 'schatkaart'.
      string treasureMap = args[0];

      // Aantal stappen voorwaarts en achterwaarts.
      int forward = 0;
      int backward = 0;

      // Loop door de schatkaart en tel het aantal stappen voorwaarts/achterwaarts.
      foreach (char c in treasureMap)
      {
         if (c == '<')
            backward++;
         else if (c == '>')
            forward++;
      }

      // Bereken het totaal aantal stappen.
      int total = forward - backward;
      // Bepaal of het totaal positief of negatief is, en sla het relevante teken op.
      char sign = total >= 0 ? '+' : '-';

      // Print de resultaten.
      Console.WriteLine($"Stappen voorwaarts: {forward}");
      Console.WriteLine($"Stappen achterwaarts: {backward}");
      Console.WriteLine($"Komt uit op: {sign}{Math.Abs(total)} stappen");
   }
}
