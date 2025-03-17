class Scripture
{
    private string name;
    private int chapter;
    private int verse;
    private string _text;
    private int _amountOfWordsInVerse;
    private int startVerse;
    private int endVerse;
    
    public Scripture(string name, int chapter, int verse, string _text)
    {
        this.name = name;
        this.chapter = chapter;
        this.verse = verse;
        this._text = _text;
    }  
    public void setList(string _text)
    {
        this._text = _text;
    }
    
    public void Display()
        {
            Console.WriteLine($"{name} {chapter}:{verse} - {_text}");
        }
    public int GetNumberOfWords()
    {
        string[] words = _text.Split(" ");
        return words.Count();
    }

    public string[] dumbFunction()
    {
        ScriptureReferenceProcesseing scriptureReference = new ScriptureReferenceProcesseing(_text);
        return scriptureReference.parsedVerse(_text);
    }
    
    // string stuffandthings;
    public string HideSomeWords(int HowMany)
    {
        // logic to hide every nth word
        // int nukeIt = 0;
        int amount = GetNumberOfWords();
        Random rnd = new Random();
        int nukeIt1 = rnd.Next(1, amount);
        int nukeIt2 = rnd.Next(1, amount);
        int nukeIt3 = rnd.Next(1, amount);

        string[] parsedVerse = dumbFunction();
       
        int loopCounter = 0;
        int hiddenChecker = 0;
        int wordlength = 0;
        string rehiddenVerse = "";

        foreach (string i in parsedVerse)
        {
            wordlength = i.Length;
            // double checking that the word isnt hidden
            foreach (char letters in i)
            {
                if (letters == '_')
                {
                    hiddenChecker = 1;
                    // rehiddenVerse = rehiddenVerse + " " + i + " ";
                
                    break;
                }
                else
                {
                hiddenChecker = 0; //rehiddenVerse = rehiddenVerse + " " + i + " ";}
                }
                break;
            }

            // int amountofhidden = 0;
            loopCounter++;
            if (hiddenChecker == 0 && (nukeIt1 == loopCounter || nukeIt2 == loopCounter || nukeIt3 == loopCounter))
            {
                
                for(int j = 0; j < wordlength; j++)
                {
                    rehiddenVerse = rehiddenVerse + "_" ;
                }
                rehiddenVerse = rehiddenVerse + " ";
            }
            else
            {
                rehiddenVerse = rehiddenVerse + " " + i;
            }    
        }
        return rehiddenVerse;
        
    }
    // parsedVerse = rehiddenVerse.Split(" ");
    // if (wordlength >= amountofhidden)
                // {
                //     amountofhidden = amountofhidden + 1;
                //     rehiddenVerse = rehiddenVerse + "_";
                // }
                // else{rehiddenVerse = rehiddenVerse + " ";}
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
}