class ScriptureReferenceProcesseing
{
    private string words;
    public ScriptureReferenceProcesseing(string words)
    {
        this.words = words;
    }
    public string[] parsedVerse(string words)
    {

        string[] parsedWords = words.Split(" ");
        return parsedWords;
  
    } 
}