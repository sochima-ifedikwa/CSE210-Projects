using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";

        Job job2 = new Job();
        job2._company = "Apple";

        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
}