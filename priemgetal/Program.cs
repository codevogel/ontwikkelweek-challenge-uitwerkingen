class Program
{
   static void Main(string[] args)
   {
      // We zetten eerst de input om naar een integer
      // Zonder try-catch, maar nu met TryParse
      if (int.TryParse(args[0], out int number))
      {
         // Als het een priemgetal is, schrijven we dat naar de console
         if (IsPrime(number))
         {
            Console.WriteLine("Ja, dit is een priemgetal");
         }
         else
         {
            Console.WriteLine("Nee, dit is geen priemgetal");
         }
      }
   }

   // Functie om te controleren of een getal een priemgetal is
   static bool IsPrime(int number)
   {
      // NB: negatieve getallen zijn per definitie geen priemgetallen
      if (number <= 1)
      {
         return false;
      }

      // We controleren of het getal deelbaar is door een getal tussen 2 en de wortel van het getal
      for (int i = 2; i <= Math.Sqrt(number); i++)
      {
         if (number % i == 0)
         {
            return false;
         }
      }

      return true;
   }
}
