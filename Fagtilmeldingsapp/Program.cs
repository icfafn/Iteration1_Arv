global using FagTilmeldingApp.Codes;


string AngivSkole;
string AngivForløb;
string AngivLinje;
string AngivBeskrivelse;
ConsoleKeyInfo cki;

ADOHandler adoHandler = new ADOHandler();
List<Teacher> TeacherList = adoHandler.GetTeacher();
List<Student> ElevList = adoHandler.GetStudent();
List<Course> KurseList = adoHandler.GetCourses();
List<Enrollment> Elist = adoHandler.GetEnrollment();
adoHandler.DeleteEnrollment();

Console.Write("Angiv Skole: ");
AngivSkole = Console.ReadLine();
Console.Write("Angiv Hovedforløb: ");
AngivForløb = Console.ReadLine();
Console.Write("Angiv Uddannelseslinje: ");
AngivLinje = Console.ReadLine();

Semester s = new(AngivSkole, AngivForløb);

do
{
    Console.Clear();
    Console.WriteLine("Angiv Skole: " + AngivSkole);
    Console.WriteLine("Angiv Hovedforløb: " + AngivForløb);
    Console.WriteLine("Angiv Uddannelseslinje: " + AngivLinje);
    Console.WriteLine("\nØnsker du at angiv en kort beskrivelse af uddannelseslinje?:  ");
    Console.WriteLine("1) Ja");
    Console.WriteLine("2) Nej");
    Console.Write("\nVælg 1 eller 2: ");
    cki = Console.ReadKey();
}
while (cki.Key != ConsoleKey.D1 && cki.Key != ConsoleKey.D2);

if (cki.Key == ConsoleKey.D1)
{
    Console.WriteLine("\nAngiv beskrivelse: ");
    AngivBeskrivelse = Console.ReadLine();
    s.SetUddannelsesLinje(AngivLinje, AngivBeskrivelse);
}
else
{
    s.SetUddannelsesLinje(AngivLinje);
}

Enrollment E1 = new Enrollment();




int UserElevId = 0;
int UserCourseId = 0;
bool mainflag = true;

while (mainflag)
{

    Console.Clear();

    try
    {
        Elist = adoHandler.GetEnrollment();
        List<Enrollment> list3 = Elist.Where(a => a.CourseId == 2).ToList();
        if (list3.Count() > 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            throw new Exception("Der må max være 3 elever i Database programmering!");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(s.SchoolName + ", " + s.Uddannelseslinje + ", " + s.SemesterNavn + " " + "Fag tilmelding app.");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(s.Uddannelsesbeskrivelse);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("----------------------------------------------------------------");

    List<Enrollment> list = Elist.Where(a => a.CourseId == 1).ToList();
    Console.WriteLine("\nElever i Grundlæggende programmering: " + list.Count());
    list = Elist.Where(a => a.CourseId == 2).ToList();
    Console.WriteLine("Elever i Database programmering: " + list.Count());
    list = Elist.Where(a => a.CourseId == 3).ToList();
    Console.WriteLine("Elever i Studieteknik: " + list.Count());
    Console.WriteLine();

    List<Student> students = ElevList.Where(a => a.ElevId == UserElevId).ToList();
    List<Course> courses = KurseList.Where(a => a.CourseId == UserCourseId).ToList();
    foreach (Student student in students)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(student.ForNavn + " " + student.EfterNavn + " Tilmeldt fag ");
    }
    foreach (Course course in courses)
    {
        Console.Write(course.CourseName);
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\n----------------------------------------------------------------");

    bool flag = true;

    while (flag)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\nElevID: ");
        try
        {
            UserElevId = Convert.ToInt32(Console.ReadLine());

            List<Student> valid = ElevList.Where(a => a.ElevId == UserElevId).ToList();
            if (valid.Count > 0)
            {
                E1.ElevId = Convert.ToInt32(UserElevId);
                flag = false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Elev findes ikke");
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Det er ikke et tal");
        }
    }

    flag = true;

    while (flag)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\nKursus ID: ");
        try
        {
            UserCourseId = Convert.ToInt32(Console.ReadLine());

            List<Course> valid3 = KurseList.Where(a => a.CourseId == UserCourseId).ToList();
            if (valid3.Count > 0)
            {
                E1.CourseId = Convert.ToInt32(UserCourseId);
                flag = false;
            }
            else if (valid3.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Kursus findes ikke");
            }
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Det er ikke et tal");
        }
    }

    List<Enrollment> valid2 = Elist.Where(a => a.ElevId == UserElevId && a.CourseId == UserCourseId).ToList();
    if(valid2.Count == 0)
    {
        adoHandler.InsertEnrollment(UserElevId, UserCourseId);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEleven findes allerede i denne klasse");
        UserElevId = 0;
        UserCourseId = 0;
        Console.ReadKey();
    }
}
