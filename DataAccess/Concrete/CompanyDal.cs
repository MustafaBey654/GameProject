using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CompanyDal : ICompanyDal
    {
        private readonly InMemory _inMemory;

        public CompanyDal(InMemory inMemory)
        {
            _inMemory = inMemory;
        }

        public void Add(Company entity)
        {
            _inMemory.GetCompanies.Add(entity);
        }

        public void Delete(Company entity)
        {
            _inMemory.GetCompanies.Remove(entity);
        }

        public List<Company> GetAll()
        {
            return _inMemory.GetCompanies;
        }

        public void Update(Company entity)
        {
           var company = _inMemory.GetCompanies.SingleOrDefault(c=>c.CompanyId == entity.CompanyId);
            if (company != null)
            {
                _inMemory.GetCompanies.Remove(company);
                _inMemory.GetCompanies.Add(entity);
            }
        }
    }
}
