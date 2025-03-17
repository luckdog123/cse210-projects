class TimeLord : Person
{
    private string _companions;

    public TimeLord(string companions, string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
        _companions = companions;
    }
    
    public string DisplayDrWhoInfo()
    {
        return $"{DisplayPersonInfo()}\n Current Companions: {_companions}";
    }
}