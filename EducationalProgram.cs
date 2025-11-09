// EducationalProgram.cs
using System;
using System.Collections.Generic;

public class EducationalProgram
{
    public string Title { get; set; } = "Нова Освітня Програма";
    public List<string> Subjects { get; set; } = new List<string>();
    public int DurationWeeks { get; set; } = 0;
    public string DifficultyLevel { get; set; } = "Базовий";

    public void ShowDetails()
    {
        Console.WriteLine($"\n--- Деталі Програми: {Title} ---");
        // ... (повна реалізація методу ShowDetails)
    }
}