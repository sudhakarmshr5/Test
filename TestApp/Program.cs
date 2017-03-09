using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Program
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Course { get; set; }

        public Decimal Marks { get; set; }


        public Program(long id, string name, string course, Decimal marks)
        {
            this.Id = id;
            this.Name = name;
            this.Course = course;
            this.Marks = marks;
        }

        public void GetStudentMarksByName(Program obj, string name)
        {
            if (obj != null)
            {
                Console.WriteLine("Enter a name");
                name = Console.ReadLine();
                if (name == "abc")
                    Console.WriteLine("Marks" + obj.Marks);
                else
                    Console.WriteLine("Student Name Not Exist");
            }
        }

        public static void Main(string[] args)
        {
            Program obj = new Program(1, "abc", "cs", 90);

            dynamic dbObj = new { Id = "1", Name = "as" };

            obj.GetStudentMarksByName()
        }
    }
}
