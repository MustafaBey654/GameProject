using Business.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SaleManager : ISaleGameService
    {
        public void GameSale(Gamer gamer, Company company)
        {
            if(gamer.IdentityNumber>= 11&& company.ValidityDate == DateTime.Today)
            {
                Console.WriteLine($"{gamer.FirstName} kullnıcısına {company.CompanyName} şu tarihe kadar {company.ValidityDate} e kadar satıld.");
            }
        }
    }
}
