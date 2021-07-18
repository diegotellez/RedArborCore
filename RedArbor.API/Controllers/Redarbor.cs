using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedArbor.API.Domain.Contracts;
using RedArbor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.Controllers
{
    public class Redarbor// : Controller
    {
        private readonly ICompanyDomainService companyDomainService;

        public Redarbor(ICompanyDomainService companyDomainService)
        {
            this.companyDomainService = companyDomainService;
        }

        // GET: Redarbor
        public Models.ActionResult Index()
        {
            return this.companyDomainService.GetAll();
        }

        // GET: Redarbor/Details/5
        public Models.ActionResult Details(int id)
        {
            return this.companyDomainService.GetById(id);
        }

        [HttpPost]        
        public Models.ActionResult Add([FromBody] Models.Company company)
        {
            return this.companyDomainService.Add(company);
        }

        [HttpPut]
        public Models.ActionResult Update(Models.Company company)
        {
            return this.companyDomainService.Update(company);
        }

        [HttpDelete]
        public Models.ActionResult Delete(int id)
        {
            return this.companyDomainService.Delete(id);
        }
    }
}
