namespace TeacherHelp;

partial class Form1 : Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        LABEL_FOR_NAME = new System.Windows.Forms.Label();
        LABEL_FOR_MODULE = new System.Windows.Forms.Label();
        textBox_MODULE = new System.Windows.Forms.TextBox();
        label_FOR_BEHAVIOUR = new System.Windows.Forms.Label();
        textBox_FOR_BEHAVIOUR = new System.Windows.Forms.TextBox();
        feedback_label = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        textBox_FOR_STUDENT_NAME = new System.Windows.Forms.TextBox();
        button2 = new System.Windows.Forms.Button();
        checkBox1 = new System.Windows.Forms.CheckBox();
        SuspendLayout();
        // 
        // LABEL_FOR_NAME
        // 
        LABEL_FOR_NAME.Location = new System.Drawing.Point(31, 25);
        LABEL_FOR_NAME.Name = "LABEL_FOR_NAME";
        LABEL_FOR_NAME.Size = new System.Drawing.Size(44, 23);
        LABEL_FOR_NAME.TabIndex = 1;
        LABEL_FOR_NAME.Text = "Name: ";
        // 
        // LABEL_FOR_MODULE
        // 
        LABEL_FOR_MODULE.Location = new System.Drawing.Point(27, 53);
        LABEL_FOR_MODULE.Name = "LABEL_FOR_MODULE";
        LABEL_FOR_MODULE.Size = new System.Drawing.Size(63, 23);
        LABEL_FOR_MODULE.TabIndex = 3;
        LABEL_FOR_MODULE.Text = "Module\r\n";
        // 
        // textBox_MODULE
        // 
        textBox_MODULE.Location = new System.Drawing.Point(96, 53);
        textBox_MODULE.Name = "textBox_MODULE";
        textBox_MODULE.Size = new System.Drawing.Size(136, 23);
        textBox_MODULE.TabIndex = 2;
        // 
        // label_FOR_BEHAVIOUR
        // 
        label_FOR_BEHAVIOUR.Location = new System.Drawing.Point(22, 82);
        label_FOR_BEHAVIOUR.Name = "label_FOR_BEHAVIOUR";
        label_FOR_BEHAVIOUR.Size = new System.Drawing.Size(63, 23);
        label_FOR_BEHAVIOUR.TabIndex = 5;
        label_FOR_BEHAVIOUR.Text = "Behaviour";
        // 
        // textBox_FOR_BEHAVIOUR
        // 
        textBox_FOR_BEHAVIOUR.Location = new System.Drawing.Point(96, 82);
        textBox_FOR_BEHAVIOUR.Name = "textBox_FOR_BEHAVIOUR";
        textBox_FOR_BEHAVIOUR.Size = new System.Drawing.Size(136, 23);
        textBox_FOR_BEHAVIOUR.TabIndex = 4;
        // 
        // feedback_label
        // 
        feedback_label.Location = new System.Drawing.Point(31, 137);
        feedback_label.Name = "feedback_label";
        feedback_label.Size = new System.Drawing.Size(578, 214);
        feedback_label.TabIndex = 7;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(127, 111);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(75, 23);
        button1.TabIndex = 8;
        button1.Text = "Generate";
        button1.UseVisualStyleBackColor = true;
        button1.Click += Button1_Click;
        // 
        // textBox_FOR_STUDENT_NAME
        // 
        textBox_FOR_STUDENT_NAME.Location = new System.Drawing.Point(96, 24);
        textBox_FOR_STUDENT_NAME.Name = "textBox_FOR_STUDENT_NAME";
        textBox_FOR_STUDENT_NAME.Size = new System.Drawing.Size(136, 23);
        textBox_FOR_STUDENT_NAME.TabIndex = 9;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(55, 352);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(75, 23);
        button2.TabIndex = 10;
        button2.Text = "Copy";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // checkBox1
        // 
        checkBox1.Location = new System.Drawing.Point(22, 178);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new System.Drawing.Size(104, 24);
        checkBox1.TabIndex = 11;
        checkBox1.Text = "Поведение";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(checkBox1);
        Controls.Add(button2);
        Controls.Add(textBox_FOR_STUDENT_NAME);
        Controls.Add(button1);
        Controls.Add(feedback_label);
        Controls.Add(label_FOR_BEHAVIOUR);
        Controls.Add(textBox_FOR_BEHAVIOUR);
        Controls.Add(LABEL_FOR_MODULE);
        Controls.Add(textBox_MODULE);
        Controls.Add(LABEL_FOR_NAME);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.CheckBox checkBox1;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.TextBox textBox_FOR_STUDENT_NAME;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label feedback_label;

    private System.Windows.Forms.Label LABEL_FOR_MODULE;
    private System.Windows.Forms.Label label_FOR_BEHAVIOUR;
    private System.Windows.Forms.TextBox textBox_FOR_BEHAVIOUR;

    private System.Windows.Forms.Label LABEL_FOR_NAME;

    private System.Windows.Forms.TextBox textBox_MODULE;

    #endregion
}
