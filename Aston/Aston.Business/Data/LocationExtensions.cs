using Aston.Entities;
using Aston.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aston.Business.Data
{
    public class LocationExtensions
    {
        AstonContext context = new AstonContext();

        public Location GetLocationInfoByCode(string code)
        {
            var obj = context.Location.Where(p => p.Code == code).FirstOrDefault();
            return obj;
        }

    }
}
