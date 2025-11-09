namespace EducationalPrograms
{
    // Інтерфейс Будівельника
    public interface IProgramBuilder
    {
        void Reset();
        void SetTitle(string title);
        void SelectSubject(string subject);
        void SetDuration(int weeks);
        void SetDifficulty(string level);
        
        // Повертає готовий продукт
        EducationalProgram GetProgram();
    }
}