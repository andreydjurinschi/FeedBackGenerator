using TeacherHelp.Classes;

namespace TeacherHelp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

    }

    private void Button1_Click(object sender, EventArgs e)
    {
        //string studentName = textBox_STUDENT_NAME.Text;
        string name = textBox_FOR_STUDENT_NAME.Text;
        string module = textBox_MODULE.Text;
        string behaviour = textBox_FOR_BEHAVIOUR.Text;
        Student student = new Student(name, module, behaviour);
        FeedBackGenerator feedBackGenerator = new FeedBackGenerator();
        string feedback = feedBackGenerator.GenerateFeedBack(student);
        feedback_label.Text = feedback;
    }
    
    private void button2_Click(object sender, EventArgs e)
    {
        string text = feedback_label.Text;
        Clipboard.SetText(text);
    }
}