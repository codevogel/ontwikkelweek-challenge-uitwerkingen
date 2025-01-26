class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      // Hoe hoog moet de piramide worden?
      int height = Int32.Parse(args[0]);

      // De piramide moet minimaal 3 hoog zijn en maximaal 20.
      const int MIN_HEIGHT = 3;
      const int MAX_HEIGHT = 20;

      // Als de hoogte niet tussen de min en max valt, geef een foutmelding.
      if (height < MIN_HEIGHT || height > MAX_HEIGHT)
      {
         Console.WriteLine("error: vul een getal tussen 3 t/m 20 in.");
         return;
      }

      // We starten altijd met 2 blokken.
      // We kunnen dan het aantal plekken lucht berekenen.
      int numBlock = 2;
      int numAir = height - numBlock + 1;

      // Voor elke laag van de piramide.
      for (int level = 0; level < height; level++)
      {
         // Print de lucht en de blokken.
         for (int air = 0; air < numAir; air++)
         {
            Console.Write(".");
         }
         for (int block = 0; block < numBlock; block++)
         {
            Console.Write("#");
         }
         // Ga naar de volgende lijn.
         Console.WriteLine();

         // We voegen 1 blok toe en halen 1 plek lucht weg
         numBlock++;
         numAir--;
      }
   }
}
