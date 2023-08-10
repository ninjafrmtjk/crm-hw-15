string s = Console.ReadLine();

// try
// {
//     int a = 0;
//     int b = 2;
//     Console.WriteLine(b / a);
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("DO NOT DIVIDE BY ZERO!");
// }

try{

}
catch (NinjafrmtjkException ex)
{
    Console.WriteLine(ex.Message + " Try again...");
}
finally
{
    Console.WriteLine("Finally!");
}

Console.WriteLine("END!");

if (string.IsNullOrEmpty(s)) throw new NinjafrmtjkException("");

public sealed class NinjafrmtjkException : Exception
{
    public NinjafrmtjkException() {}
    public NinjafrmtjkException (string message = "Sad") : base(message) { }
    public NinjafrmtjkException (string message, System.Exception inner) : base(message, inner) { }
}