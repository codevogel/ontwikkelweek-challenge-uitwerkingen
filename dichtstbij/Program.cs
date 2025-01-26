class Program
{
   static void Main(string[] args)
   {
      // Zet alle argumenten om naar integers 
      int[] numbers;
      numbers = args.Select(int.Parse).ToArray();

      // Sorteer de array
      Array.Sort(numbers);

      // Zoek de twee getallen die het dichtst bij elkaar liggen
      int minDifference = int.MaxValue;
      int num1 = 0, num2 = 0;

      for (int i = 0; i < numbers.Length - 1; i++)
      {
         // Bereken het verschil tussen de twee getallen
         int diff = Math.Abs(numbers[i + 1] - numbers[i]);
         // Als het verschil kleiner is dan het vorige verschil, sla de getallen op
         if (diff < minDifference)
         {
            // Update ook het minimale verschil
            minDifference = diff;
            num1 = numbers[i];
            num2 = numbers[i + 1];
         }
      }

      // Print het resultaat
      Console.WriteLine($"{num1} en {num2} liggen het dichtst bij elkaar");
   }
}
