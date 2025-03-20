using Microsoft.VisualBasic.ApplicationServices;

namespace TeacherHelp.Classes;

public class FeedBackGenerator
{
    public string GenerateFeedBack(Student student)
    {
        string feedback = $"{student.FullName} проявил(а) {student.Behavior} в течение модуля {student.Module}. ";
        return feedback;
    }
}