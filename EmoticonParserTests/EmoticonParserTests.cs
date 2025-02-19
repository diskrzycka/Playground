using EmoticonParser;

namespace EmoticonParserTests;

public class EmoticonParserTests
{
    private Parser _parser;

    [SetUp]
    public void Setup()
    {
        _parser = new Parser();
    }

    [Test]
    public void Parse_ShouldConvertTextToEmojis()
    {
        var input = "How are you? ;-)";
        var expected = "How are you? 😺";
        var result = _parser.ParseText(input);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Parse_ShouldHandleNoEmoticons()
    {
        var input = "Just regular text!";
        var result = _parser.ParseText(input);

        Assert.That(input, Is.EqualTo(result));
    }

    [Test]
    public void Parse_ShouldHandleMultipleEmoticons()
    {
        var input = ":-) :-(";
        var expected = "😺 😿";
        var result = _parser.ParseText(input);

        Assert.That(expected, Is.EqualTo(result));
    }
}
