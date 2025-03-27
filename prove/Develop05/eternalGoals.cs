class Eternalgoal : Goal
{
    private int _points = 0;
    private string _goaltitle = "";
    private string _goalDesription = "";
    public override string makeAgoal()
    {
        string fristhalf = base.makeAgoal();
        return $"1#{fristhalf}"; // a 0 at the end shows that it hasnt been completed the number at the start shows what kind of goal it is 0 is a basic, 1 is a eternal goal, 2 is a checklist goal
    }

    private Eternalgoal(int points, string goaltitle, string goalDescription) : base(points, goaltitle, goalDescription) 
    {

    }
    public Eternalgoal(){} // empty constuctor

    public override Eternalgoal foodProcessing(string food)
    {
        string[] halfcooked = food.Split("#");
        string Goaltitle = halfcooked[1];
        string Desrciption = halfcooked[2];
        int Points = int.Parse(halfcooked[3]);
        return new Eternalgoal(Points , Goaltitle, Desrciption);
    }
}