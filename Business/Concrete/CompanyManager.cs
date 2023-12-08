using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company entity)
        {
            _companyDal.Add(entity);
        }

        public void Delete(Company entity)
        {
            _companyDal.Delete(entity);
        }

        public List<Company> GetAll()
        {
          return  _companyDal.GetAll();
        }

        public void Update(Company entity)
        {
           _companyDal.Update(entity);
        }
    }
}
