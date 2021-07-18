using Microsoft.AspNetCore.Mvc;
using RedArbor.API.Domain.Contracts;
using RedArbor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedArbor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedarborController : ControllerBase
    {
        private readonly ICompanyDomainService companyDomainService;

        public RedarborController(ICompanyDomainService companyDomainService)
        {
            this.companyDomainService = companyDomainService;
        }

        // GET: api/<RedarborController>
        [HttpGet]
        public Models.ActionResult Get()
        {
            return this.companyDomainService.GetAll();
        }

        // GET api/<RedarborController>/5
        [HttpGet("{id}")]
        public Models.ActionResult Get(int id)
        {
            return this.companyDomainService.GetById(id);
        }

        // POST api/<RedarborController>
        [HttpPost]
        public Models.ActionResult Post([FromBody] Company company)
        {
            return this.companyDomainService.Add(company);
        }

        // PUT api/<RedarborController>/5
        [HttpPut]
        public Models.ActionResult Put([FromBody] Company company)
        {
            return this.companyDomainService.Update(company);
        }

        // DELETE api/<RedarborController>/5
        [HttpDelete("{id}")]
        public Models.ActionResult Delete(int id)
        {
            return this.companyDomainService.Delete(id);
        }
    }
}
