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
    /// <summary>
    /// Este servicio permite la administración de compañías,una entidad de prueba de SQL
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RedarborController : ControllerBase
    {
        private readonly ICompanyDomainService companyDomainService;

        public RedarborController(ICompanyDomainService companyDomainService)
        {
            this.companyDomainService = companyDomainService;
        }


        /// <summary>
        /// Consulta TODAS las compañías registradas en el sistema
        /// </summary>
        /// <returns></returns>
        // GET: api/<RedarborController>
        [HttpGet]
        public Models.ActionResult Get()
        {
            return this.companyDomainService.GetAll();
        }

        /// <summary>
        /// Consulta una compañía específica del sistema, filtrando por el Id especificado
        /// </summary>
        /// <param name="id">Id de compañía a buscar</param>
        /// <returns></returns>
        // GET api/<RedarborController>/5
        [HttpGet("{id}")]
        public Models.ActionResult Get(int id)
        {
            return this.companyDomainService.GetById(id);
        }

        /// <summary>
        /// Agregar una compañía al sistema. El servicio no valida que id exista
        /// </summary>
        /// <param name="company">Entidad a agregar</param>
        /// <returns></returns>
        // POST api/<RedarborController>
        [HttpPost]
        public Models.ActionResult Post([FromBody] Company company)
        {
            return this.companyDomainService.Add(company);
        }

        /// <summary>
        /// Actualiza los datos de una compañía existente.  El servicio valida que el Id exista.
        /// </summary>
        /// <param name="company">Entidad a actualizar</param>
        /// <returns></returns>
        // PUT api/<RedarborController>/5
        [HttpPut]
        public Models.ActionResult Put([FromBody] Company company)
        {
            return this.companyDomainService.Update(company);
        }

        /// <summary>
        /// Elimina una compañía existente, filtrando por Id
        /// </summary>
        /// <param name="id">Id de la compañía a borrar</param>
        /// <returns></returns>
        // DELETE api/<RedarborController>/5
        [HttpDelete("{id}")]
        public Models.ActionResult Delete(int id)
        {
            return this.companyDomainService.Delete(id);
        }
    }
}
