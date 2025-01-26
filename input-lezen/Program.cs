class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      // Als er geen argumenten zijn meegegeven, print een foutmelding.
      if (args.Length != 1)
      {
         Console.WriteLine("error: geef een bestand mee!");
         return;
      }

      // Lees het eerste argument (het bestandspad) en zet deze in een string. 
      string path = args[0];

      // Check of het bestand bestaat.
      if (!File.Exists(path))
      {
         Console.WriteLine("error: bestand bestaat niet!");
         return;
      }

      // Lees de inhoud van het bestand en zet deze in een array van strings.
      string[] lines = File.ReadAllLines(path);

      // Loop door de array en print elke regel naar de console.
      foreach (string line in lines)
      {
         Console.WriteLine(line);
      }
   }
}
