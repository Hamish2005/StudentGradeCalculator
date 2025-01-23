namespace SE2250_Lab2;

class Program
{
    static void Main()
    {
        // Step 1: Ask the user to input the number of subjects
        Console.Write("Enter the number of subjects: ");
        int num_Subject = int.Parse(Console.ReadLine());
        
        // Step 2: Accept the grades for each subject using a for loop
        double[] grades = new double[num_Subject];
        double total = 0;
        for (int i = 0; i < num_Subject; i++)
        {
            Console.Write($"Enter grade for subject {i + 1}: ");
            grades[i] = double.Parse(Console.ReadLine());
            total += grades[i];
        }
        
        // Step 3: Calculate the total and average grades
        double average = total / num_Subject;

        // Step 4: Determine the final grade category
        string gradeCategory;

        if (average >= 90)
        {
            gradeCategory = "A";
        }
        else if (average >= 75)
        {
            gradeCategory = "B";
        }
        else if (average >= 60)
        {
            gradeCategory = "C";
        }
        else
        {
            gradeCategory = "Fail";
        }
        
        // Step 5: Display the total marks, average, and grade category
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Grade: {gradeCategory}");


        
    }
}