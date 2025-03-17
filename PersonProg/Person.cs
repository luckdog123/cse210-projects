class Person
{
    private string _Firstname;
    private string _Lastname;
    private int _Age;

    public Person(string firstname, string lastname, int age)
    {
        _Firstname = firstname;
        _Lastname = lastname;
        _Age = age;
    }

    public string DisplayPersonInfo()
    {
        return $"Name: {_Firstname} {_Lastname}\n Age: {_Age}";
    }


}