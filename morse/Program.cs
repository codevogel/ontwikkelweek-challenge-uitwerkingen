class Program {
	public static void Main(string[] args)
	{
		int numArguments = args.Length;
      Console.WriteLine(numArguments);
		foreach (string arg in args) {
			Console.WriteLine(arg);
		}
	}
}
