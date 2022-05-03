using EsercitazioneWeek2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2.Chain
{
    public class ProductivityHandler : AbstractHandler
    {
        public int Y { get; }
        public int W { get; }


        public ProductivityHandler(int y, int w)
        {
            Y = y;
            W = w;
        }

        public override double HandleRequest(Employee employee)
        {
            if (employee.Age < Y && employee.ProductivityRate > W)
                return 300.0;
            else
                return base.HandleRequest(employee);
        }


    }
}
