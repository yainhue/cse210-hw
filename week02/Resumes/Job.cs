/* 
Job Class

    Responsibilities:
        Keeps track of the company, job title, start year, and end year.
    Behaviors:
        Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
*/

public class Job
{

    // Definir los atributos (variables)
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // definir metodo (member function)
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}