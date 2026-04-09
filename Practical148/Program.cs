using System;
using System.Reflection;

class Student
{
    public int Id;
    public string Name;

    public void Show()
    {
        Console.WriteLine("Student Method");
    }
}

class ReflectionDemo
{
    static void Main()
    {
        Type type = typeof(Student);

        Console.WriteLine("Class Name: " + type.Name);

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields())
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.ReadKey();
    }
}