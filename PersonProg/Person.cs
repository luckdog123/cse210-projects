class Person
{
    private string _Firstname;
    private string _Lastname;
    private int _Age;

    protected int _Height;

    public Person(string firstname, string lastname, int age)
    {
        _Firstname = firstname;
        _Lastname = lastname;
        _Age = age;
        _Height = 0;
    }

    public string DisplayPersonInfo()
    {
        return $"Name: {_Firstname} {_Lastname}\n Age: {_Age}\n Height: {_Height}";
    }

    public int GetHeight()
    {
        return _Height;
    }

    public void SetHeight(int height)
    {
        _Height = height;
    }

}