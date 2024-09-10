using System.Text.RegularExpressions;

namespace _80sKids7_SheIsASmallWonder;

public class Robot
{
    private List<string> _learntWords = new();

    public Robot()
    {
        LearnSentence("Thank you for teaching me");
        LearnSentence("I already know the word");
        LearnSentence("I do not understand the input");
    }

    public string LearnWord(string word)
    {
        if (!Regex.IsMatch(word, @"^[a-zA-Z]+$"))
            return "I do not understand the input";

        var loweredWord = word.ToLower();

        if (_learntWords.Contains(loweredWord))
            return $"I already know the word {word}";

        _learntWords.Add(loweredWord);

        return $"Thank you for teaching me {word}";
    }

    private void LearnSentence(string sentence)
    {
        var words = sentence.Split(' ');

        foreach (var word in words)
            LearnWord(word);
    }
}