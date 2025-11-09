namespace EducationalPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    // Продукт: Освітня програма
    public class EducationalProgram
    {
        // Приватне поле для зберігання предметів
        private readonly List<string> _subjects = new List<string>();

        public string Title { get; internal set; } = "Нова Програма";
        public int DurationWeeks { get; internal set; } = 0;
        public string DifficultyLevel { get; internal set; } = "Базовий";
        
        // Повертаємо копію списку предметів, щоб уникнути зовнішньої модифікації
        public ReadOnlyCollection<string> Subjects => _subjects.AsReadOnly(); 

        // Внутрішній метод для додавання предметів, доступний лише Будівельнику
        internal void AddSubject(string subject)
        {
            _subjects.Add(subject);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"\n--- Деталі Програми: {Title} ---");
            Console.WriteLine($"Рівень складності: {DifficultyLevel}");
            Console.WriteLine($"Тривалість: {DurationWeeks} тижнів");

            if (_subjects.Any())
            {
                Console.WriteLine($"Предмети: {string.Join(", ", Subjects)}");
            }
            else
            {
                Console.WriteLine("Предмети: Ще не визначено.");
            }
            Console.WriteLine("---------------------------------\n");
        }
    }
}