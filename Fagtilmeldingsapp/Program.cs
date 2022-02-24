using FagTilmeldingApp.Codes;


List<Course> KurseList = new()
{   
    new Course() { CourseId = 9, CourseName = "Grundlæggende Programmering", TeacherId = 1 },
    new Course() { CourseId = 7, CourseName = "Database Programmering", TeacherId = 1 },
    new Course() { CourseId = 1, CourseName = "Studieteknik", TeacherId = 1 },
    new Course() { CourseId = 5, CourseName = "Clientside Programmering", TeacherId = 2 }
};

Console.WriteLine("Usorteret list: ");
Console.WriteLine("-----------------------------------------------------------------");

foreach (Course c in KurseList)
{
    Console.WriteLine(c.CourseId + ". " + c.CourseName);
}

Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Sorteret list: ");
Console.WriteLine("-----------------------------------------------------------------");

KurseList.Sort();

foreach (Course b in KurseList)
{
    Console.WriteLine(b.CourseId + ". " + b.CourseName);
}

Console.WriteLine("-----------------------------------------------------------------");

Console.WriteLine("Bagvendt Sorteret list: ");
Console.WriteLine("-----------------------------------------------------------------");

KurseList.Reverse();

foreach (Course b in KurseList)
{
    Console.WriteLine(b.CourseId + ". " + b.CourseName);
}

Console.ReadKey();
