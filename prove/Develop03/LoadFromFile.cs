using System;
public class LoadFromFile
{

    private string[] parsedBom;

    public LoadFromFile()
    {
        parsedBom = System.IO.File.ReadAllText(@"C:\temp\BOM.txt").Split("\r\n\r\n");//load in the book of mormon text
    }
    public string[] getParsedBom()
    {
        return parsedBom;
    }

}