class Program
{
   static void Main(string[] args)
   {
      // We kijken of er minstens 1 argument is meegegeven
      if (args.Length == 0)
      {
         Console.WriteLine("error: Voer minstens 1 cijfer in.");
         return;
      }

      // We maken een lijst aan om de decimale waarden van de romeinse cijfers in op te slaan
      List<int> decimalValues = new List<int>();
      foreach (string arg in args)
      {
         // We proberen de romeinse cijfers om te zetten naar decimale waarden
         try
         {
            decimalValues.Add(ParseRomanNumeral(arg));
         }
         catch (ArgumentException)
         {
            Console.WriteLine($"error: Een van de getallen is geen ondersteund romeins cijfer.");
            return;
         }
      }

      // We tonen de resultaten
      string addition = string.Join(" + ", decimalValues);
      int sum = 0;
      foreach (int value in decimalValues)
      {
         sum += value;
      }

      Console.WriteLine($"Dat is gelijk aan {addition}");
      Console.WriteLine($"En dat is {sum}");
   }

   // Een functie die een romeins cijfer omzet naar een decimaal cijfer
   // De functie throwt een ArgumentException als het romeinse cijfer niet ondersteund wordt
   static int ParseRomanNumeral(string roman)
   {
      // We maken een map aan die de romeinse cijfers koppelt aan hun decimale waarde
      Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100}
        };

      // We maken een variabele aan om de totale waarde van het romeinse cijfer in op te slaan
      int total = 0;
      int prevValue = 0;

      // We gaan door elk karakter van het romeinse cijfer heen
      foreach (char c in roman)
      {
         // Als het karakter niet in de map zit, dan is het geen ondersteund romeins cijfer
         if (!romanMap.ContainsKey(c))
            throw new ArgumentException();

         // We halen de decimale waarde van het karakter op
         int currentValue = romanMap[c];

         // Als de huidige waarde groter is dan de vorige waarde, 
         if (currentValue > prevValue)
         {
            // dan moeten we de vorige waarde aftrekken van de huidige waarde
            total += currentValue - 2 * prevValue;
         }
         else
         {
            // anders tellen we de huidige waarde op bij de totale waarde
            total += currentValue;
         }
         // We slaan de huidige waarde op als vorige waarde voor de volgende iteratie
         prevValue = currentValue;
      }
      return total;
   }
}

