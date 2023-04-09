using System;

public class StringHider
{
    private string _hiddenScripture; 
    private List<string> scriptureTextList;
    private List<int> _wordList;

    public StringHider(string verse)
    {
        _hiddenScripture = verse;
        scriptureTextList = new List<string>();
        _wordList = new List<int>();
        convertTextToList();
    }
    public string getString()
    {
        return _hiddenScripture;
    }

    private void convertTextToList()
    {
        int i = 0;
        scriptureTextList = _hiddenScripture.Split(' ').ToList();
        foreach(string word in scriptureTextList)
        {
            _wordList.Add(i);
            i++;
        }
    }

    public void hideThemWords()
    {
        string trash = "";
        string strNewWord = "";
        Random r = new Random();
        int rInt = r.Next(0, _wordList.Count());//need to randomly find a word to hide

        while (_wordList[rInt] == -1)
        {
            rInt = r.Next(0, _wordList.Count());//If we have already used that number get a new one
        }
      
        
        trash = scriptureTextList[rInt];
        foreach (char i in trash)
        {
            strNewWord = strNewWord + "*";//build a word of * the same length you replaced
        }
        scriptureTextList[rInt] = strNewWord;//replace the word with the * version
        _wordList[rInt] = -1; //marks this word has been hidden

    }

    public void listOutWords()
    {
        string strRebuiltString = "";

        for (int i = 0; i < scriptureTextList.Count; i++)
        {
            strRebuiltString = strRebuiltString + scriptureTextList[i].ToString() + " ";    
        }
        Console.WriteLine(strRebuiltString);
    }

    public bool AllDoneCheck()  //Since i set the value in _wordList to -1 every time i replace text I can use this as my chedck to see if all words are hidden
    {
        int intSum = 0;
        for (int i = 0; i < _wordList.Count; i++)
        {
            intSum = intSum + _wordList[i];
        }
        //if the sum of the _wordList and the count of words equal 0 i have replaced all the words.
        if(intSum + _wordList.Count == 0)
        {
            return true;//all words are hidden
        }
        else
        {
            return false;//I still have words to show
        }
    }
}





