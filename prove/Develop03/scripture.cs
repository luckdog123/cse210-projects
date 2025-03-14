class Scripture
{
    private string name;
    private int chapter;
    private int verse;
    private string _text;
    private int startVerse;
    private int endVerse;
    public Scripture(string name, int chapter, int verse, string _text)
    {
        this.name = name;
        this.chapter = chapter;
        this.verse = verse;
        this._text = _text;
    }  
    // public Scripture(string name, int startVerse, int endVerse, string _text)
    // {
    //     this.name = name;
    //     this.endVerse = endVerse;
    //     this.verse = startVerse;
    //     this._text = _text;
    // }
    // public Scripture(ScriptureReference scriptureReference, string _text)
    // {

    //     this.name = ScriptureReference.name;
    //     this.chapter = ScriptureReference.chapter;
    //     this.verse = ScriptureReference.verse;
    //     this._text = _text;

    // }
    public void Display()
        {
            Console.WriteLine($"{name} {chapter}:{verse} - {_text}");
        }
    public string HideSomeWords(int HowMany)
    {
        int nukeIt = 0;
        ScriptureReference scriptureReference = new ScriptureReference(_text);
        string[] parsedVerse = scriptureReference.parsedVerse(_text);
        // string[] words = parsedVerse(_text);
        // string[] parsedVerse = new int[words.Length];
        int loopCounter = 0;
        int hiddenChecker = 0;
        int wordlength = 0;
        string rehiddenVerse = "";
        foreach (string i in parsedVerse)
        {
            wordlength = i.Length;
            
            foreach (char letters in i)
            {
                if (letters == '_')
                {
                    hiddenChecker = 1;
                    break;
                }
                else{hiddenChecker = 0; rehiddenVerse = rehiddenVerse + i + " ";}
                break;
            }

            int amountofhidden = 0;
            loopCounter++;
            if (hiddenChecker == 0 & nukeIt == loopCounter)
            {
                if (wordlength >= amountofhidden){
                    amountofhidden = amountofhidden + 1;
                    rehiddenVerse = rehiddenVerse + "_";
                }
                else{rehiddenVerse = rehiddenVerse + " ";}
                
            }
            
            
        }
        
        return rehiddenVerse;
        
    }
}