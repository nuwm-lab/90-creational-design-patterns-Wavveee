// IProgramBuilder.cs
public interface IProgramBuilder
{
    void Reset(); // Додано Reset до інтерфейсу для чистоти
    void SetTitle(string title);
    void SelectSubject(string subject);
    void SetDuration(int weeks);
    void SetDifficulty(string level);
    EducationalProgram GetProgram();
}