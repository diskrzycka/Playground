namespace EmoticonParser;

public class Parser
{
    public string ParseText(string message)
    {
        var emoticons = new Dictionary<string, string>
        {
            { ":)", "😺" },
            { ":-)", "😺" },
            { ";)", "😺" },
            { ";-)", "😺" },
            { ":(", "😿" },
            { ":-(", "😿" },
            { ";(", "😿" },
            { ";-(", "😿" },
            { ":D", "😸" },
            { ":-D", "😸" },
            { ":o", "🙀" },
            { ":O", "🙀" },
            { ":-o", "🙀" },
            { ":-O", "🙀" },
            { ":*", "😽" },
            { ":-*", "😽" },
            { ";*", "😽" },
            { ";-*", "😽" },
        };
        foreach (var emoticon in emoticons)
        {
            message = message.Replace(emoticon.Key, emoticon.Value);
        }

        return message;
    }
}
