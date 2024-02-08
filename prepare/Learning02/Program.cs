using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        {
            job1._jobTitle = "Manager";
            job1._company = "Apple";
            job1._startYear = 2001;
            job1._endYear = 2007;
            job1.DisplayJobDetails();
        }
        
        Job job2 = new Job();
        {
            job2._jobTitle = "Software Engineer";
            job2._company = "Microsoft";
            job2._startYear = 2008;
            job2._endYear = 2015;
            job2.DisplayJobDetails();
        }

        Resume resume1 = new Resume();
        {
            resume1._personName = "Delilah Smith";
            resume1._jobs.Add(job1);
            resume1._jobs.Add(job2);
            resume1.DisplayResume();
        }
    
    }
}