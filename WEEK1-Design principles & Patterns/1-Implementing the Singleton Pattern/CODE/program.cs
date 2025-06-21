using System;

public class Logger
{
    private static Logger _loggerInstance;
    private Logger()
    {
        Console.WriteLine("instance created"); 
    }
    public static Logger GetLogger()
    {
        if (_loggerInstance == null)
        {
            _loggerInstance = new Logger();
        }
        return _loggerInstance;
    }
    public void Log(string msg)
    {
        Console.WriteLine("Log message: " + msg);
    }
}
class Program
{
    static void Main(string[] args)
    {
        var loggerOne = Logger.GetLogger();
        var loggerTwo = Logger.GetLogger();
        loggerOne.Log("first");
        loggerTwo.Log("second");

        if (loggerOne == loggerTwo)
        {
            Console.WriteLine("both are the same");
        }
        else
        {
            Console.WriteLine("different instances");
        }

    }
}
