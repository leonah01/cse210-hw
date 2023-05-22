using System;

class scripture
{
    private List<Word> words;

    private Reference scriptureReference;

    public scripture (Reference _scriptureReference, string _scriptureText)
    {
        scriptureReference = _scriptureReference;
        words = new List<Word>();
        CreateWords(_scriptureText);
    }
    private void CreateWords(string _scriptureText)
    {
        List<string> alloword = _scriptureText.Split(' ').ToList();
        foreach (string item in alloword)
        {
            Word word = new Word(item);
            words.Add(word);
        }

    }
    public string GetScripture()
    {
        string scriptureText = "";
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetWord() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetWord().Length) + "";
            }
        }
        return ($"{scriptureReference.GetReference()} {scriptureText}");
    }
    public bool HasWordsLeft()
    {
        bool retValue = false;

        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                retValue = true;
            }
        }

        return retValue;
    }
    public void RemoveWords()
    {
        int numbWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;
        do
        {
            int rndIndex = new Random().Next(0, words.Count());
            //Replace the words that are not replaced yet
            if (words[rndIndex].GetIsHidden() ==false)
            {
                words[rndIndex].SetIsHidden(true);
                wordsRemoved++;
            }
        }while (wordsRemoved != numbWordsToRemove && this.HasWordsLeft());
    }
    
}