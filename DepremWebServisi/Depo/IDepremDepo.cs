using DepremWebServisi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepremWebServisi.Depo
{
      public interface IDepremDepo
    {
        public IEnumerable<Deprem> GetAll();
        public Deprem GetWithEventID(long eventID);
        public void Add(Deprem deprem);
        public bool SaveChanges();
       
    }
}
