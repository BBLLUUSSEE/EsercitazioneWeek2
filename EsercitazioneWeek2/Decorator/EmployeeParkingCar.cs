using EsercitazioneWeek2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2.Decorator
{
    public class EmployeeParkingCar : EmployeeDecorator
    {
        public string ParkingCode { get; set; }

        public EmployeeParkingCar(Employee employee, string code) : base(employee)
        {

            ParkingCode = code;
        }

        public override string ViewBenefit()
        {
            return StartedEmployee.ViewBenefit() + $"{ParkingCode}";
        }
    }
}
