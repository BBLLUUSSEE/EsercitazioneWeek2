using EsercitazioneWeek2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2.Decorator
{
    public class EmployeeHealthyPolicy : EmployeeDecorator
    {

        public string Code { get; set; }

        public EmployeeHealthyPolicy(Employee employee, string code) : base(employee)
        {

            Code = code;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{Code}";
        }
    }
}
