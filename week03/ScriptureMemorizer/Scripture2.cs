using System;

public class Scripture
{
    private Reference2 _reference2;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference2 reference2, string text)
    {
        _reference2 = reference2;
        _random = new Random();
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string reference2Text = _reference2.GetDisplayText();
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return $"{reference2Text} {scriptureText.Trim()}";
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
