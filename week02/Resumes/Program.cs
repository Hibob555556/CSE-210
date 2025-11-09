using System;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._company = "Campbell Scientific";
        job._jobTitle = "Product Test Engineer";
        job._startYear = 2024;
        job._endYear = 2030;

        Job job1 = new Job();
        job1._company = "Space Dynamics Laboratory";
        job1._jobTitle = "Student Engineering Assistant";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Cayden Lunt";
        resume._jobs = [job, job1];

        resume.Display();
    }
}