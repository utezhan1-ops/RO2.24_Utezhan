public class Student
{
    public string Name { get; set; }
    public int studentID { get; private set; }
    public double GPA { get; set; }
    public string Faculty { get; set; }
    private static int counter = 0;

    public Student(string name, double gpa, string faculty)
    {
        counter++;
        this.studentID = counter;
        this.Name = name;
        this.GPA = gpa;
        this.Faculty = faculty;
    }
}

public class Registry
{
    private Student[] students = new Student[100];
    private int currentCount = 0;

    public void Add(Student s)
    {
        if (currentCount < 100)
        {
            students[currentCount] = s;
            currentCount++;
            Console.WriteLine("Success: Student added.");
        }
        else
        {
            Console.WriteLine("Error: Registry is full.");
        }
    }

    public void FindByID(int id)
    {
        for (int i = 0; i < currentCount; i++)
        {
            if (students[i].studentID == id)
            {
                Console.WriteLine("Found: " + students[i].Name + " | Faculty: " + students[i].Faculty + " | GPA: " + students[i].GPA);
                return;
            }
        }
        Console.WriteLine("Student with ID " + id + " not found.");
    }

    public void FindByName(string name)
    {
        bool found = false;
        for (int i = 0; i < currentCount; i++)
        {
            if (students[i].Name.ToLower() == name.ToLower())
            {
                Console.WriteLine("Found: ID " + students[i].studentID + " | GPA: " + students[i].GPA);
                found = true;
            }
        }
        if (!found) Console.WriteLine("No students found with name: " + name);
    }

    public void GetTopStudents(int n)
    {
        if (currentCount == 0) return;

        for (int i = 0; i < currentCount - 1; i++)
        {
            for (int j = 0; j < currentCount - i - 1; j++)
            {
                if (students[j].GPA < students[j + 1].GPA)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nTop " + n + " Students:");
        for (int i = 0; i < n && i < currentCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + students[i].Name + " - GPA: " + students[i].GPA);
        }
    }

    public void PrintAll()
    {
        if (currentCount == 0) { Console.WriteLine("Registry is empty."); return; }
        for (int i = 0; i < currentCount; i++)
        {
            Console.WriteLine("ID: " + students[i].studentID + " | Name: " + students[i].Name + " | GPA: " + students[i].GPA);
        }
    }
}

class Program
{
    static void Main()
    {
        Registry myRegistry = new Registry();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- COMMANDS: 1:Add, 2:ID, 3:Name, 4:Top, 5:All, 6:Exit ---");
            Console.Write("Action: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("GPA: ");
                double gpa = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                Console.Write("Faculty: ");
                string faculty = Console.ReadLine();
                myRegistry.Add(new Student(name, gpa, faculty));
            }
            else if (choice == "2")
            {
                Console.Write("ID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                myRegistry.FindByID(id);
            }
            else if (choice == "3")
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                myRegistry.FindByName(name);
            }
            else if (choice == "4")
            {
                Console.Write("Count (N): ");
                int n = Convert.ToInt32(Console.ReadLine());
                myRegistry.GetTopStudents(n);
            }
            else if (choice == "5")
            {
                myRegistry.PrintAll();
            }
            else if (choice == "6")
            {
                running = false;
            }
        }
    }
}