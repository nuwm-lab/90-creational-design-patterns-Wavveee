// ProgramDirector.cs
using System;

public class ProgramDirector
{
    private IProgramBuilder _builder;

    public IProgramBuilder Builder
    {
        set { _builder = value; }
    }

    // Метод для створення типової програми для початківців
    public void BuildBeginnerProgram()
    {
        // ... (повна логіка конструювання програми)
        _builder.SetTitle("Вступ до IT");
        _builder.SetDuration(8);
        // ...
    }

    // Метод для створення типової програми для професіоналів
    public void BuildAdvancedProgram()
    {
        // ... (повна логіка конструювання програми)
    }
}