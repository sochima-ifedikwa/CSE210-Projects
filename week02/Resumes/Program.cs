using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // Create a new instance of the Job class
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();

        Resume resume = new Resume();

        //add jobs to resume
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        Console.WriteLine(resume._jobs[0]._jobTitle);
        Console.WriteLine(resume._jobs[1]._jobTitle);
    }
}