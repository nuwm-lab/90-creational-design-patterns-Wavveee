namespace EducationalPrograms
{
    // Конкретний Будівельник
    public class StandardProgramBuilder : IProgramBuilder
    {
        private EducationalProgram _program;

        public StandardProgramBuilder()
        {
            // Ініціалізація нового продукту при створенні будівельника
            this.Reset();
        }

        public void Reset()
        {
            this._program = new EducationalProgram();
        }

        // Змінює внутрішній екземпляр
        public void SetTitle(string title)
        {
            this._program.Title = title;
        }

        // Додає предмет до списку внутрішнього екземпляра
        public void SelectSubject(string subject)
        {
            this._program.AddSubject(subject);
        }

        // Змінює внутрішній екземпляр
        public void SetDuration(int weeks)
        {
            if (weeks > 0)
            {
                this._program.DurationWeeks = weeks;
            }
        }

        // Змінює внутрішній екземпляр
        public void SetDifficulty(string level)
        {
            this._program.DifficultyLevel = level;
        }

        // Повертає готовий об'єкт і скидає стан для наступної побудови
        public EducationalProgram GetProgram()
        {
            // Зберігаємо посилання на готовий об'єкт
            EducationalProgram result = this._program;
            
            // Скидаємо стан будівельника, щоб наступний виклик GetProgram()
            // не повернув той самий (попередній) об'єкт.
            this.Reset(); 
            
            // Якщо використовується повернення клону, логіка Reset має бути іншою, 
            // але для простоти ми використовуємо скидання стану.
            return result;
        }
    }
}