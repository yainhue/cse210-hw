using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // crear dos nuevas instances de la clase "Job"
        // asignandolas a las variables "job1" y "job2"
        Job job1 = new Job();
        Job job2 = new Job();

        // asignar los valores de los atributos de job1
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // asignar los valores de los atributos de job2
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // crear instance de la resume class
        Resume resume = new Resume();

        // asginar valores de resume
        resume._name = "Fernando Perez";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // display objeto job(s) dentro de objeto resume
        resume.Display();
        }
}