using Aston.Entities;
using Aston.Entities.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aston.Business
{
    public class AssetComponent
    {
        AstonContext context = new AstonContext();
        public List<Pref> Asset()
        {
            List<Pref> result = new List<Pref>();

            var query = context.Pref;
            result = query.ToList();
            return result;
         

        }
        public Asset AssetbyID(int id)
        {
            return context.Asset.Where(p => p.ID == id).FirstOrDefault();
        }

       
    }
}
