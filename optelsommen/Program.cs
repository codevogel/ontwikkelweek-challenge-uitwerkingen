class Program
{
   // string[] args is een array aan argumenten die meegegeven worden
   // aan het programma.
   public static void Main(string[] args)
   {
      // Als er geen twee argumenten zijn meegegeven, geef een error.
      if (args.Length != 2)
      {
         Console.WriteLine("error: voer twee getallen in");
         return;
      }

      // Dit is een try-catch block. Hiermee kan je errors opvangen.
      // Een FormatException vindt plaats als de string niet omgezet kan worden
      // naar een integer.
      // Als deze exception optreedt in het try block, 
      // wordt de code in het catch block uitgevoerd.
      // Voor meer informatie over try-catch, zie:
      // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/try-catch
      try
      {
         string numStringA = args[0];
         string numStringB = args[1];
         int numA = Int32.Parse(args[0]);
         int numB = Int32.Parse(args[1]);
         int result = numA + numB;
         Console.WriteLine(result);
      }
      catch (FormatException)
      {
         Console.WriteLine("error: voer twee getallen in");
      }
   }
}
