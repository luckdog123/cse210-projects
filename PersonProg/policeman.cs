class PoliceMan : Person
{
    private string _wepons;

    public PoliceMan(string wepons, string firstname, string lastname, int age) : base(firstname, lastname, age)
    {
        _wepons = wepons;
        _Height = 88;
    }
    
    public string DisplayPoliceManInfo()
    {
        return $"{DisplayPersonInfo()}\n Wepons: {_wepons}";
    }
}
        