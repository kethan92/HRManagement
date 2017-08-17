using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student("Than", "Ke", "1"),
                new Student("Thanh", "Nguyen", "2"),
                new Student("An", "Le", "2"),
                new Student("Hau", "Vo", "1"),
                new Student("Da", "Thai", "2"),
                new Student("Nguyen", "Nguyen", "3"),
                new Student("Quyen", "Nguyen", "3"),
                new Student("Quynh", "Tran", "2"),
                new Student("Tin", "Le", "1"),
                new Student("Son", "Ha", "2"),
                new Student("Thoa", "Cai", "1")
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Than", "Ke", 22, 26),
                new Worker("Thanh", "Nguyen", 73, 26),
                new Worker("Tan", "Le", 233, 25),
                new Worker("Au", "Vo", 97, 45),
                new Worker("Phuoc", "Thai", 261, 44),
                new Worker("Phong", "Nguyen", 173, 52),
                new Worker("Quyen", "Nguyen", 172, 36),
                new Worker("Le", "Tran", 172, 35),
                new Worker("Tin", "Le", 57, 43),
                new Worker("My", "Nguyen", 108, 51),
                new Worker("Nga", "Nguyen", 107, 35)
            };

            var sortedStudentByFacultyNumber = students.OrderBy(s => s.Grade);
            Console.WriteLine("-----------------  SORT BY GRADE  -------------------");
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudentByFacultyNumber.Select(s => s.ToString())));

            // Salarry
            Console.WriteLine("-----------------  SORT BY MoneyPerHour  -------------------");
            var sortedWorkerByPaymentPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine(string.Join(Environment.NewLine, sortedWorkerByPaymentPerHour.Select(w => w.ToString())));
           

            // add
            var humans = new List<Human>();

            humans.AddRange(students);
            humans.AddRange(workers);

            var sortHumansByNames = humans
           .OrderBy(h => h.FirstName)
           .ThenBy(h => h.LastName)
           .Select(h => h.FirstName + " " + h.LastName + " - " + h.GetType());

           
            Console.WriteLine("------------------All people sorted by names:-------------------");
            

            Console.WriteLine(string.Join(Environment.NewLine, sortHumansByNames));
            Console.ReadLine();
        }
    }
}
