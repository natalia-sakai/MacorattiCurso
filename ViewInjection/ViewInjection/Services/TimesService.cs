using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewInjection.Services
{
    public class TimesService
    {
        public List<string> GetTimes()
        {
            return new List<string>() { "Brasil", "Argentina", "Japão" };
        }
    }
}
