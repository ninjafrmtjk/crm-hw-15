string? s = Console.ReadLine();

try{
    bool m = string.IsNullOrEmpty(s);
    Console.WriteLine(m);
}
catch (NinjafrmtjkException)
{
    Console.WriteLine(" Try again...");
}
finally
{
    Console.WriteLine("Finally!");
}

Console.WriteLine("END!");

if (string.IsNullOrEmpty(s)) throw new NinjafrmtjkException("String is empty or has incorrect format!");

public sealed class NinjafrmtjkException : Exception
{
    public NinjafrmtjkException() { }
    public NinjafrmtjkException (string message = "Sad") : base(message) { }
    public NinjafrmtjkException (string message, System.Exception inner) : base(message, inner) { }
}