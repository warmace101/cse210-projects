using System;

public class StringHider
{
    private string _hiddenScripture;

    private List<string> scriptureTextList;

    public StringHider(Scripture _scripture)
    {
        scripture = _scripture;
        scriptureTextList= new List<string>();
        convertTextToList();
    }

    private void convertTextToList()
    {
        scriptureTextList = Scripture.toString().Split(' ').ToList();
    }

    public void removeWordsFromText()
    {
        int numWordsToRemove = new Random().Next(2, 4);
        int wordsRemoved = 0;

        do
        {
            int rndIndex = new Random().Next(0, scriptureTextList.Count());
            scriptureTextList[rndIndex] = new stirng(' ', scriptureTextList[rndIndex].Length);
            wordsRemoved++;
        } while (wordsRemoved != numWordsToRemove);
    }

    public string toString()
    {
        return string.Join(' ', scriptureTextList);
    }

    public bool hasWordsLeft()
    {
        bool retvalue = false;

        foreach (string word in scriptureTextList)
        {
            if (word.Contains('_') == false)
            {
                retvalue = true;
                break;
            }
        }
        return retvalue;
    }
}