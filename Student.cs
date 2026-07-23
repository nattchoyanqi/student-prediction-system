using System;

public class Student
{
    private double attendance;
    private double assignment;
    private double quiz;
    private double studyHours;

    public double Attendance
    {
        get { return attendance; }
        set { attendance = value; }
    }
    public double Assignment
    {
        get { return assignment; }
        set { assignment = value; }
    }
    public double Quiz
    {
        get { return quiz; }
        set { quiz = value; }
    }
    public double StudyHours
    {
        get { return studyHours; }
        set { studyHours = value; }
    }

    public Student(double attendance, double assignment, double quiz, double studyHours)
    {
        Attendance = attendance;
        Assignment = assignment;
        Quiz = quiz;
        StudyHours = studyHours;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("---Student Information---");
        Console.WriteLine($"Attendance: {Attendance}");
        Console.WriteLine($"Assignment: {Assignment}");
        Console.WriteLine($"Quiz: {Quiz}");
        Console.WriteLine($"Study Hours: {StudyHours}");
    }
}