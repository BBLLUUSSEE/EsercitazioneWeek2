using EsercitazioneWeek2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneWeek2.Chain
{
    public interface IHandler
    {
        double HandleRequest(Employee employee);
        IHandler SetNext(IHandler absenceHandler);
    }
}
