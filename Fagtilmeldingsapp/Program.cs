using Fagtilmeldingsapp.Codes;
Console.WriteLine("------------------------------------------------------");
Console.WriteLine("Tilmeldings app for lærere");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();

Semester S = new Semester();

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------------------------------------------------");
Console.WriteLine(S.SchoolName + " " + S.SemesterNavn + " " + "Tilmeldings App");
Console.WriteLine("------------------------------------------------------");
Console.WriteLine();
Console.ReadKey();