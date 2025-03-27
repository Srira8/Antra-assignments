using System;

public class UrlParser
{
    public static void ParseUrl(string url)
    {
        string protocol = "";
        string server = "";
        string resource = "";

        // Check if the URL contains "://"
        if (url.Contains("://"))
        {
            // Split protocol and the rest of the URL
            int protocolEnd = url.IndexOf("://");
            protocol = url.Substring(0, protocolEnd);

            url = url.Substring(protocolEnd + 3); // Remove protocol part
        }

        // Split the server and resource based on the first '/'
        int resourceIndex = url.IndexOf('/');
        if (resourceIndex >= 0)
        {
            server = url.Substring(0, resourceIndex);
            resource = url.Substring(resourceIndex + 1); // Resource is the part after the '/'
        }
        else
        {
            server = url; // If no '/' is found, the entire URL is the server
        }

        // Print the results
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}

