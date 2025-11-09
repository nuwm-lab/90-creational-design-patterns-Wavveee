using EducationalPrograms;
using System;

public class Program
{
    public static void Main()
    {
        StandardProgramBuilder builder = new StandardProgramBuilder();
        ProgramDirector director = new ProgramDirector();

        // Встановлення будівельника у керівника
        director.SetBuilder(builder);

        // 1. Створення типової програми за допомогою Керівника
        Console.WriteLine("--- 1. Створення типової програми (Початковий) ---");
        director.BuildBeginnerProgram();
        EducationalProgram beginnerProgram = builder.GetProgram();
        beginnerProgram.ShowDetails();


        // 2. Створення типової програми за допомогою Керівника (Експертний)
        Console.WriteLine("--- 2. Створення типової програми (Експертний) ---");
        director.BuildAdvancedProgram();
        EducationalProgram advancedProgram = builder.GetProgram();
        advancedProgram.ShowDetails();


        // 3. Створення кастомної програми за допомогою покрокового виклику
        Console.WriteLine("--- 3. Створення кастомної програми (Покроково) ---");
        
        builder.SetTitle("Машинне Навчання та AI");
        builder.SetDuration(12);
        builder.SetDifficulty("Середній");
        builder.SelectSubject("Лінійна Алгебра");
        builder.SelectSubject("Нейронні Мережі");
        builder.SelectSubject("Обробка Великих Даних");
        
        EducationalProgram customProgram = builder.GetProgram();
        customProgram.ShowDetails();
    }
}