class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      string path = args[0];
      string[] lines = File.ReadAllLines(path);

      // Hou de rekeningen bij
      List<float> balances = new List<float>();

      // Hou de huidige rekening bij
      float currentBalance = 0;

      // Voor elke lijn in het bestand
      foreach (string line in lines)
      {
         // Als de lijn leeg is, voeg de huidige rekening toe aan de lijst
         if (string.IsNullOrWhiteSpace(line))
         {
            balances.Add(currentBalance);
            // Reset ook de huidige rekening
            currentBalance = 0;
         }
         else
         {
            // Voeg het bedrag toe aan de huidige rekening
            currentBalance += float.Parse(line);
         }
      }
      // Voeg de laatste rekening toe aan de lijst
      balances.Add(currentBalance);

      // Print aantal rekeningen
      Console.WriteLine($"Aantal rekeningen: {balances.Count}");
      // Print totaalbedrag van de hoogste rekening
      Console.WriteLine($"Hoogste rekening: {balances.Max()}");
      // Kijk welke klant de hoogste rekening heeft
      Console.WriteLine($"Klant {balances.IndexOf(balances.Max()) + 1} heeft de hoogste rekening.");
   }
}
