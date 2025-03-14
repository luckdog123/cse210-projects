class ScriptureReference
{
    private string words;
    public ScriptureReference(string words)
    {
        this.words = words;
    }
    public string[] parsedVerse(string words)
    {

        string[] parsedWords = words.Split(" ");
        return parsedWords;

    } 
}