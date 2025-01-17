using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Care";
        job1._pay = 90000;
        

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Walmart";
        job2._pay = 50000;
        

        Resume myResume = new Resume();
        myResume._name = "Edward Wilson";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}