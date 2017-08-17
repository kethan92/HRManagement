using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public Worker(string firstname, string lastname, decimal weekSalary,
        decimal workHourPerDay) : base(firstname, lastname)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHourPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }

            set
            {
                weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return workHoursPerDay;
            }

            set
            {
                workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 6);
        }
        public override string ToString()
        {
            return base.ToString() + "Week salary:" + this.WeekSalary + " Work hours per day" + this.WorkHoursPerDay
            + "Money per hour: " + this.MoneyPerHour().ToString();
        }
    }
}
