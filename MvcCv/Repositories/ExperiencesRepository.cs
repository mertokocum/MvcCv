using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCv.Models.Entity;

namespace MvcCv.Repositories
{
    public class ExperiencesRepository : GenericRepository<TblExperiences>
    {
        DbCvEntities db = new DbCvEntities();
        public List<TblExperiences> List()
        {
            return db.TblExperiences.ToList();
        }
    }
}