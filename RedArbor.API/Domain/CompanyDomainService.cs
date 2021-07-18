using RedArbor.API.DataAccess.Contracts;
using RedArbor.API.Domain.Contracts;
using RedArbor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.Domain
{
    public class CompanyDomainService : ICompanyDomainService
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyDomainService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public ActionResult GetAll()
        {
            return this.companyRepository.GetAll();
        }

        public ActionResult GetById(int? id)
        {
            return this.companyRepository.GetById(id.Value);
        }

        public ActionResult Add(Company company)
        {
            return this.companyRepository.Add(company);
        }

        public ActionResult Update(Company company)
        {
            return this.companyRepository.Update(company);
        }

        public ActionResult Delete(int id)
        {
            return this.companyRepository.Delete(id);
        }
    }
}
