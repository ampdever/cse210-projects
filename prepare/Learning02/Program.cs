using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        //Console.WriteLine(job1._jobTitle);
        //job1.Display();
    
        Job job2 = new();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        //Console.WriteLine(job2._jobTitle);
        //job2.Display();

        Resume myResume = new();
        myResume._name = "Aaron Magallanes";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

    }
}