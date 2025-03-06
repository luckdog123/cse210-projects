using System;

class Entry
{
    public string DateStuffs
    {
        get
        {
            DateTime theCurrentTime = DateTime.Now;
            return theCurrentTime.ToShortDateString();
        }
    }
}
    