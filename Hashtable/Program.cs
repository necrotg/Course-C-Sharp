using System;
using System.Collections;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(1, "Felipe", 3);
            students[1] = new Student(2, "Mariana", 2);
            students[2] = new Student(3, "Anare", 3);
            students[3] = new Student(4, "Rhayssa", 1);
            students[4] = new Student(5, "Gino", 1);

            Hashtable keys = new Hashtable();

            foreach(Student i in students)
            {
                if (!keys.Contains(i.id))
                {
                    keys.Add(i.id, i);
                }
                
            }
            foreach(DictionaryEntry entry in keys)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine(temp.id);
                Console.WriteLine(temp.name);
                Console.WriteLine(temp.year);
            }
        }


    }
    class Student
    {
        public int id { get; set; }
        public String name { get; set; }
        public int year { get; set; }

        public Student(int id, string name, int year)
        {
            this.id = id;
            this.name = name;
            this.year = year;
        }
    }
}
