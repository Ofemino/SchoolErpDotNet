using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public class AcademicSessionRepository:BaseRepository<AcademicSession>
    {
        public IQueryable<AcademicSession> GetAllSession()
        {
            return GetAll();
        }



    }
}
