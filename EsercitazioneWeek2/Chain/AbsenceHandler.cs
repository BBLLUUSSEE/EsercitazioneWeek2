using EsercitazioneWeek2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2.Chain
{
    public class AbsenceHandler : AbstractHandler
    {
        public int Y { get; }
        public int Z { get; }


        public AbsenceHandler(int y, int z)
        {
            Y = y;
            Z = z;
        }

        public override double HandleRequest(Employee employee)
        {
            if (employee.Age < Y && employee.AbsenceRate < Z)
                return 180;
            return base.HandleRequest(employee);
        }


    }
}
