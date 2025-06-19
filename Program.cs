using System;

class Student
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public int[] Marks { get; set; }

    // Constructor
    public Student(int id, string name, int[] marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    // Method to calculate average
    public double GetAverage()
    {
        int total = 0;
        foreach (int mark in Marks)
        {
            total += mark;
        }
        return (double)total / Marks.Length;
    }

    // Method to get grade
    public string GetGrade()
    {
        double avg = GetAverage();
        if (avg >= 80) return "A";
        else if (avg >= 60) return "B";
        else if (avg >= 40) return "C";
        else return "F";
    }

    // Display method
    public void DisplayInfo()
    {
        Console.WriteLine($"\nID: {Id}, Name: {Name}");
        Console.WriteLine("Average: " + GetAverage());
        Console.WriteLine("Grade: " + GetGrade());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int count = int.Parse(Console.ReadLine());

        Student[] students = new Student[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\n--- Enter data for Student {i + 1} ---");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter number of subjects: ");
            int subjects = int.Parse(Console.ReadLine());

            int[] marks = new int[subjects];

            for (int j = 0; j < subjects; j++)
            {
                Console.Write($"Marks for Subject {j + 1}: ");
                marks[j] = int.Parse(Console.ReadLine());
            }

            students[i] = new Student(id, name, marks);
        }

        Console.WriteLine("\n Student Report: 2025 June 19 ");
        foreach (Student s in students)
        {
            s.DisplayInfo();
        }
    }
}
