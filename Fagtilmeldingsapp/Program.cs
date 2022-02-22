using Fagtilmeldingsapp.Codes;
using Fagtilmeldingsapp.Codes.Models;
//Iteration4
string SkoleInput, HovedforlobInput, Uddannelseslinje;
string? UddannelseslinjeBeskrivelse;
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Tilmeldings app for lærere");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();
Console.Write(" Angiv Skole: ");
SkoleInput = Console.ReadLine();
Console.Write("Angiv Hovedforløb: ");
HovedforlobInput = Console.ReadLine();
Console.Write("Angiv Uddannelselinje: ");
Uddannelseslinje = Console.ReadLine();
Console.WriteLine("Ønsker du at angive en kort beskrivelse af uddannelseslinje?");
Console.WriteLine("1) Ja");
Console.WriteLine("2) Nej");
start:
Console.Write("Vælg 1 eller 2: ");

//Convert.ToInt32(Console.ReadLine());
int UddannelseslinjeBeskrivelsetest = Convert.ToInt32(Console.ReadLine());

if (UddannelseslinjeBeskrivelsetest == 1)


{
    Console.Write("Angiv kort beskrivelse af uddannelseslinje: ");
    UddannelseslinjeBeskrivelse = (Console.ReadLine());
}

else if (UddannelseslinjeBeskrivelsetest == 2)
    Console.WriteLine("Der bliver ikke tilføjet en beskrivelse.");
else
    goto start;
            
        

Semester S = new Semester(SkoleInput, HovedforlobInput);


Console.Clear();
Console.WriteLine("------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(S.SchoolName + " " + Uddannelseslinje + " " +  S.SemesterNavn + " " + "Fag Tilmeldings App");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(UddannelseslinjeBeskrivelse);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Elever i Grundlæggende Programmering");
Console.WriteLine("Elever i Database Programmering");
Console.WriteLine("Elever i Studieteknik");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();
Console.Write("Indtast Fag id: ");
Console.ReadLine();
Console.Write("Indtast Elev id: ");
Console.ReadLine();


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
