using System;

class Resume
{
    private string _name;
    // private string _jobList;
    private List<Job> _jobsList;


    public Resume(string name){
        _name = name;
        _jobsList = new List<Job>();

    }


    public void AddJobs(Job job){
        _jobsList.Add(job);
    }

    public void DisplayResume(){
        Console.WriteLine($"{_name} resume: List of Jobs:");
        foreach (Job job in _jobsList)
        {
            job.DisplayJob(); //it is useing the variable job not the class "Job"
        }
    }
    // public Resume()
}