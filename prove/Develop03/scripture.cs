class Scripture
{
    private string name;
    private int chapter;
    private int verse;
    private string text;
    private int startVerse;
    private int endVerse;
    public Scripture(string name, int chapter, int verse, string text)
    {
        this.name = name;
        this.chapter = chapter;
        this.verse = verse;
        this.text = text;
    }
    public Scripture (string name, int startVerse, int endVerse, string text)
    {
        this.name = name;
        this.endVerse = endVerse;
        this.verse = startVerse;
        this.text = text;
    }
    // public Scripture(ScriptureReference scriptureReference, string text)
    // {

    //     this.name = ScriptureReference.name;
    //     this.chapter = ScriptureReference.chapter;
    //     this.verse = ScriptureReference.verse;
    //     this.text = text;

    // }
    public void HideSomeWords()
    {
        string[] words = parsedVerse(text);
        string[] parsedVerse = new string[words.Length];
        foreach (int i in parsedVerse)
        {
           
        }
    }