using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement
{
    class Student : Human
    {
        private string grade;
        public Student(string firstname, string lastname, string grade) : base(firstname, lastname)
        {
            this.grade = grade;
        }


        public string Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "," + this.grade;
        }
    }
}
