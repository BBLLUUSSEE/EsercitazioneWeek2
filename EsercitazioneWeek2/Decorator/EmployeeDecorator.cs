using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsercitazioneWeek2.Entities;

namespace EsercitazioneWeek2.Decorator
{
    public class EmployeeDecorator : Employee
    {
        public Employee StartedEmployee { get; set; }

        public EmployeeDecorator(Employee emp)
        {
            StartedEmployee = emp;
        }

        public override string ViewBenefit()
        {
            return base.ViewBenefit();
        }
    }
}
