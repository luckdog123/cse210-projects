class DungenGen 
{
    // public List<int> 
    private int _dunLength = 10;
    
    public static int RandomizeDunLength()
    {
        int[] myArray = { 8,9,10,10,10,12,13,15,17};
        // Create a Random object
        Random random = new Random();
        // Generate a random index within the bounds of the array
        int randomIndex = random.Next(myArray.Length);
        // Access the element at the random index
        return myArray[randomIndex];
    }

    
}