namespace console;
/// <summary>
/// This is the cusotm exception class that we use for ienum funcuton and we call it in that functuion.
/// </summary>
public class Except: Exception
{
public Except() : base("Invalid operationa has been dectected"){}

public Except(string message): base(message){}

public Except(string message, Exception innerException): base(message,innerException){}
}
