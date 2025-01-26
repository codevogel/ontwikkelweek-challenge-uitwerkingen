class Program
{
		// string[] args is een array aan argumenten die meegegeven worden
		// aan het programma.
		public static void Main(string[] args)
		{
				if (args.Length != 2)
				{
						Console.WriteLine("error: voer twee getallen in");
				}
				try
				{
						int a = Int32.Parse(args[0]);
						int b = Int32.Parse(args[1]);
						int result = a + b;
						Console.WriteLine(result);
				}
				catch (FormatException e)
				{
						Console.WriteLine("error: voer twee getallen in");
				}

		}
}
