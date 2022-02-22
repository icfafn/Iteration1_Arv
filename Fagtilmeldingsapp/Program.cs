using Fagtilmeldingsapp.Codes;
using Fagtilmeldingsapp.Codes.Models;
//Iteration3
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Tilmeldings app for lærere");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();

Semester S = new Semester();

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------------------------------------------------");
Console.WriteLine(S.SchoolName + " " + S.Uddannelselinje + " " +  S.SemesterNavn + " " + "Fag Tilmeldings App");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Elever i Grundlæggende Programmering");
Console.WriteLine("Elever i Database Programmering");
Console.WriteLine("Elever i Studieteknik");


List<Teacher> lstTeachers = new()
{
    new Teacher()
    { Id = 1, FirstName = "Niels", LastName = "Olesen" },
    new Teacher()
    { Id = 2, FirstName = "Henrik", LastName = "Poulsen" },
    new Teacher()
    { Id = 3, FirstName = "Tanja", LastName = "Olesen" },
    
};




//List<Teacher> teachers = lstTeachers.Where(a => a.LastName == "Olesen").ToList();
//foreach (Teacher teacher in teachers) 
//{ Console.WriteLine($"Id aflærermed efternavnOlesen: {teachers.Id}"); }
//// Tæl hvor mange rækker der er i listen:
//int rækker = teachers.Count();

//Teacher teacher = lstTeachers.FirstOrDefault(a => a.LastName == "Olesen");
//// Hvis ingen match er, vil rowvære null, derfor tjek for null.
//if(teacher!= null){Console.WriteLine($"Id aflærermed efternavnOlesen: {teacher.Id}");}


List<Student> lstStudent = new()
{
    new Student()
    { Id = 1, FirstName = "Martin", LastName = "Jensen" },
    new Student()
    { Id = 2, FirstName = "Patrick", LastName = "Nielsen" },
    new Student()
    { Id = 3, FirstName = "Susanne", LastName = "Hansen" },
    new Student()
    { Id = 4, FirstName = "Thomas", LastName = "Olsen" }
};

List<Course> lstCourse = new()
{
    new Course()
    { Id = 1, Coursename = "Grundlæggende Programmering", Teacherid = 1 },
    new Course()
    { Id = 2, Coursename = "Database Programmering", Teacherid = 1 },
    new Course()
    { Id = 6, Coursename = "Studieteknik", Teacherid = 1 },
    new Course()
    { Id = 7, Coursename = "Clientside Programmering", Teacherid = 2 }
};

List<Enrollment> en = new()
{

};

Console.ReadKey();
