using System;


class Program
{
    static void Main(string[] args)
    {
        Job myFirstJob = new Job("Taco Time", "CEO",2020,2023);
        // myFirstJob.DisplayJob();
        Job job2 =  new Job("Taco Bell", "CEO",2023,2025);


        Resume myres = new Resume("Steve Jobs");
        myres.AddJobs(myFirstJob);
        myres.AddJobs(job2);
        myres.DisplayResume();







        // Job job1 = new Job();
        // job1.SetJobTitle("Software Eng");
        // job1.Setcompany("BYUI");
        // job1.SetStartYear(2023);
        // job1.SetEndYear(2025);
        // Console.WriteLine("why does my brain not compute this??");

    }
}