using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var logPath = "logs.txt";

        File.AppendAllText(logPath, $"[{DateTime.Now}] Exception: {exception.Message}{Environment.NewLine}");

        context.Result = new ObjectResult("An unexpected error occurred.")
        {
            StatusCode = 500
        };
    }
}
