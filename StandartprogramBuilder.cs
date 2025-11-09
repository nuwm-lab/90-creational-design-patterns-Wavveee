// StandardProgramBuilder.cs
using System.Collections.Generic;

public class StandardProgramBuilder : IProgramBuilder
{
    private EducationalProgram _program = new EducationalProgram();

    public StandardProgramBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._program = new EducationalProgram();
    }

    // Реалізація всіх методів SetTitle, SelectSubject, SetDuration, SetDifficulty...
    public void SetTitle(string title) { /* ... */ }
    public void SelectSubject(string subject) { /* ... */ }
    public void SetDuration(int weeks) { /* ... */ }
    public void SetDifficulty(string level) { /* ... */ }

    public EducationalProgram GetProgram()
    {
        EducationalProgram result = this._program;
        this.Reset();
        return result;
    }
}