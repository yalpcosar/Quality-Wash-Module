using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class DefectRepository : EfEntityRepositoryBase<Defect, ProjectDbContext>, IDefectRepository
    {
        public DefectRepository(ProjectDbContext context) : base(context)
        {
        }
    }
}