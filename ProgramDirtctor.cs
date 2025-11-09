namespace EducationalPrograms
{
    using System;

    // Керівник (Director) - для створення типових конфігурацій
    public class ProgramDirector
    {
        private IProgramBuilder? _builder; // Використовуємо nullable type

        // Використовуємо метод SetBuilder замість публічної властивості без геттера
        public void SetBuilder(IProgramBuilder builder)
        {
            _builder = builder;
        }

        // Метод створення типової програми для початківців
        public void BuildBeginnerProgram()
        {
            // Перевірка на null
            if (_builder == null) throw new InvalidOperationException("Будівельник не встановлено.");
            
            _builder.Reset();
            _builder.SetTitle("Вступ до Програмування");
            _builder.SetDuration(8);
            _builder.SetDifficulty("Початковий");
            _builder.SelectSubject("Основи C#");
            _builder.SelectSubject("Введення в GIT");
            _builder.SelectSubject("Алгоритми для початківців");
        }

        // Метод створення типової програми для професіоналів
        public void BuildAdvancedProgram()
        {
            // Перевірка на null
            if (_builder == null) throw new InvalidOperationException("Будівельник не встановлено.");

            _builder.Reset();
            _builder.SetTitle("Просунута Хмарна Архітектура");
            _builder.SetDuration(20);
            _builder.SetDifficulty("Експертний");
            _builder.SelectSubject("Розподілені Транзакції");
            _builder.SelectSubject("Паттерни Мікросервісів");
            _builder.SelectSubject("CI/CD та DevOps");
        }
    }
}