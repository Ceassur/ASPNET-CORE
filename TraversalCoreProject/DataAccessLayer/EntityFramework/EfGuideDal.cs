using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {
            
            var Values = context.Guides.Find(id);
            Values.Status=false;
            context.Update(Values);
            context.SaveChanges();

        }

        public void ChangeToTrueByGuide(int id)
        {
            var Values=context.Guides.Find(id);
            Values.Status = true;
            context.Update(Values);
            context.SaveChanges();
        }
    }
}
