using System.IO;

public static class EnvLoader
{
    public static string GetEnvValue(string key)
    {
        foreach (var line in File.ReadAllLines(".env"))
        {
            if (line.StartsWith(key + "="))
                return line.Split('=')[1];
        }
        return null;
    }
}