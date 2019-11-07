using System;

public static class Task
{
    public static string Execute()
    {
        try
        {
            return Environment.UserDomainName + "\\" + Environment.UserName;
        }
        catch (Exception e) { return e.GetType().FullName + ": " + e.Message + Environment.NewLine + e.StackTrace; }
    }
}