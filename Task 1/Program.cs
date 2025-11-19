namespace Task_1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            student std1 = new student();
            student std2= new student();
            std1.id = 1;
            std1.name = "John";
            std1.age = 20;

            std2.id = 2;
            std2.name = "Alice";
            std2.age = 22;
            student.course = "BSC(hons) Computing";

            Console.WriteLine("Student 1:");
            Console.WriteLine($"ID: {std1.id}, Name: {std1.name}, Age: {std1.age}, Course: {student.course}");
            Console.WriteLine("Student 2:");
            Console.WriteLine($"ID: {std2.id}, Name: {std2.name}, Age: {std2.age}, Course: {student.course}");

        }
    }
}
