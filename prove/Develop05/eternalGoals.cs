class Eternalgoal : Goal
{
    public override string makeAgoal()
    {
        string fristhalf = base.makeAgoal();
        return $"1#{fristhalf}"; // a 0 at the end shows that it hasnt been completed the number at the start shows what kind of goal it is 0 is a basic, 1 is a eternal goal, 2 is a checklist goal
    }
}