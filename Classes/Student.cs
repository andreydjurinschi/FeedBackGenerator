namespace TeacherHelp.Classes;

public class Student
{
    private string _fullName;
    private string _module;
    private string _behavior;

    public Student(string fullName, string module, string behavior)
    {
        _fullName = fullName;
        _module = module;
        _behavior = behavior;
    }

    public string FullName
    {
        get => _fullName;
        set => _fullName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Module
    {
        get => _module;
        set => _module = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Behavior
    {
        get => _behavior;
        set => _behavior = value ?? throw new ArgumentNullException(nameof(value));
    }
}