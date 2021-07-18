using RedArbor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedArbor.API.Domain.Contracts
{
    public interface ICompanyDomainService
    {
        public ActionResult GetAll();

        public ActionResult GetById(int? id);

        public ActionResult Add(Company company);

        public ActionResult Update(Company company);

        public ActionResult Delete(int id);
    }
}
