class PoliceMan : Person
{
    private string _wepons;

    public PoliceMan(string wepons, string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
        _wepons = wepons;
        _Height = 88;
    }
    
    public string GetPoliceManInfo()
    {
        return $"{GetPersonInfo()}\n Wepons: {_wepons}";
    }
    public override string GetName()
    {
        return $"Captain {base.GetName()}";
    }
    public override string GetHobbies()
    {
        return "diggging holes";
    }
}
        