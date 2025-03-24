class TimeLord : Person
{
    private string _companions;

    public TimeLord(string companions, string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
        _companions = companions;
    }
    
    public override String GetName()
    {
        return $"{base.GetName()}\n Current Companions: {_companions}";
    }
    public override string GetHobbies()
    {
        return "Time Traveling";
    }
}