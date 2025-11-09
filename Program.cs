// Program.cs
using System;

public class Program
{
    public static void Main()
    {
        // Створення та ініціалізація компонентів
        StandardProgramBuilder builder = new StandardProgramBuilder();
        ProgramDirector director = new ProgramDirector { Builder = builder };

        // 1. Використання Керівника
        director.BuildBeginnerProgram();
        EducationalProgram beginnerProgram = builder.GetProgram();
        beginnerProgram.ShowDetails();

        // 2. Використання Будівельника без Керівника
        builder.SetTitle("Кастомний Курс з AI");
        // ... (виклики SetDuration, SelectSubject, etc.)
        EducationalProgram customProgram = builder.GetProgram();
        customProgram.ShowDetails();
    }
}