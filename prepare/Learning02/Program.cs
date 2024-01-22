using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.company = "Tel Daco";
        job1.jobTitle = "Cheese Melter";
        job1.startYear = 2045;
        job1.endYear = 2099;

        Job job2 = new Job();
        job2.company = "Google";
        job2.jobTitle = "Software Tech Director";
        job2.startYear = 2099;
        job2.endYear = 3010;
        
        
        Resume resume1 = new Resume();
        resume1._name = "Merlin Ambrosius";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();

    }
}