using DataLayer;
using Entity;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class CompanyBusiness
    {
        public CompanyData objCompanyData;
        public CompanyBusiness()
        {
            objCompanyData = new CompanyData();

        }
        public List<Company> GetAll()
        {
            return objCompanyData.GetAll();
        }

        public bool Save(Company objCompany)
        {
            if (objCompany.Id == 0)
                return objCompanyData.Insert(objCompany);
            else
                return objCompanyData.Update(objCompany);
        }
    }
}
