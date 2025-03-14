using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrt1 = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        double loopCounter = 0;
        loopCounter = (scrt1.GetNumberOfWords())/3;
        scrt1.Display();
        while (loopCounter > 0)
        {
            string scriptList = scrt1.HideSomeWords(3);
            Console.WriteLine(scriptList);
            // Console.WriteLine(scrt1.HideSomeWords(3));
            Console.ReadLine();
            Console.Clear();
            scrt1.setList(scriptList);
            loopCounter = loopCounter - 1;
        }
       
    }
    
}