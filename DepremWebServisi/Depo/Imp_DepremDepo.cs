using DepremWebServisi.DepremDb_Context;
using DepremWebServisi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepremWebServisi.Depo
{
    public class Imp_DepremDepo : IDepremDepo
    {

        private readonly Db_Context _context;
        public Imp_DepremDepo( Db_Context context)
        {
            _context = context;
        }

        
        public void Add(Deprem deprem)
        {
            _context.Depremler.Add(deprem);

        }

        public IEnumerable<Deprem> GetAll()
        {
            return _context.Depremler;
        }

     

        public Deprem GetWithEventID(long eventID)
        {
            return _context.Depremler.FirstOrDefault(Deprem => Deprem.eventID == eventID);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
