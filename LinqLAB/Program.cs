using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = AllStudents();
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            Console.WriteLine("ANSWERS TO LINQ LAB");
            Console.WriteLine("For nums:\n");

            //int minVal = nums.Min(x => x);
            int minVal = nums.Min();
            Console.WriteLine($"1. Minimum value is: {minVal}");

            int maxVal = nums.Max();
            Console.WriteLine($"2. Maximum value is: {maxVal}");

            //classic overthinking way
            int[] numsLessThan10000 = nums.Where(n => n < 10000).ToArray();           
            int maxValLessThan10000 = numsLessThan10000.Max();
            Console.WriteLine($"3. Maximum value less than 10000 is: {maxValLessThan10000}");

            //Easier way
            int numsLessThan10000b = nums.Where(x => x < 10000).Max();
            Console.WriteLine($"3. Maximum value less than 10000 is: {numsLessThan10000b}");

            int[] numsInRange = nums.Where(x => x >= 10 && x <= 100).ToArray();
            Console.WriteLine($"4. Values between 10 and 100: ");
            foreach (int num in numsInRange)
            {
                Console.WriteLine($"\t{num}");
            }

            int[] numsInRangeMil = nums.Where(x => x >= 100000 && x <= 999999).ToArray();
            Console.WriteLine($"5. Values between 100000 and 999999: ");
            foreach (int num in numsInRangeMil)
            {
                Console.WriteLine($"\t{num}");
            }

            //classic overthinking way
            int[] evens = nums.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine($"6. Count all the even numbers: ");
            int counting = 0;
            foreach (int even in evens)
            {
                Console.WriteLine($"\t{even}");
                counting++;
            }
            Console.WriteLine($"6. There are {counting} numbers that are even!");

            //Easier way
            int evenNums = nums.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"6. There are {evenNums} even numbers");

            Console.WriteLine("==========Using LINQ with Objects===============");

            List<Student> studentsOver21 = students.Where(s => s.Age >= 21).ToList();
            Console.WriteLine($"1. Students over 21: ");
            foreach (Student s in studentsOver21)
            {
                Console.WriteLine($"\t{s.Name}");
            }

            //reviewed in class to put into all one line           
            string oldestStudent = students.Where(x => x.Age == students.Max(x => x.Age)).First().Name;
            Console.WriteLine($"2. Oldest Student: {oldestStudent}");

            string youngestStudent = students.Where(x => x.Age == students.Min(x => x.Age)).First().Name;
            Console.WriteLine($"3. Youngest Student: {youngestStudent}");

            Student oldStudentUnder25 = students.Where(x => x.Age < 25).OrderBy(x => x.Age).Last();
            Console.WriteLine($"4. Oldest Student Under 25: {oldStudentUnder25.Name}");

            List<Student> studentsOver21AndEven = studentsOver21.Where(x => x.Age % 2 == 0).ToList();
            Console.WriteLine($"5. Students Over 21 AND Even Age: ");
            foreach (Student s in studentsOver21AndEven)
            {
                Console.WriteLine($"\t{s.Name}");
            }

            List<Student> teens = students.Where(x => x.Age >= 13 && x.Age <=19).ToList();
            Console.WriteLine($"6. Teenagers between 13 and 19: ");
            foreach (Student t in teens)
            {
                Console.WriteLine($"\t{t.Name}");
            }

            List<Student> vowelStudents = students.Where(x => x.Name.StartsWith('a') || x.Name.StartsWith('e') || x.Name.StartsWith('i') ||
                x.Name.StartsWith('o') || x.Name.StartsWith('u') || x.Name.StartsWith('A') || x.Name.StartsWith('E') ||
                x.Name.StartsWith('I') || x.Name.StartsWith('O') || x.Name.StartsWith('U')).ToList();
            Console.WriteLine($"7. Student names having first letter with a vowel: ");
            foreach (Student v in vowelStudents)
            {               
                Console.WriteLine($"\t{v.Name}");
            }

        }

        //Reviewed in class for easier printing purposes for nums
        public static void PrintNum(int[] nums)
        {
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        //Reviewed in class for easier printing purposes for students
        public static void PrintNum2(int[] students)
        {
            foreach (int student in students)
            {
                Console.WriteLine(student);
            }
        }

        //changed the list to a method just for practice (no particular reason)
        public static List<Student> AllStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student("Jimmy", 13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Curtis", 10)
            };
            return students;
        }
    }
}
