using RedArbor.API.DataAccess.Contracts;
using RedArbor.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RedArbor.API.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly Demo.DataAccess.SqlServer sqlInstance;

        public CompanyRepository(Demo.DataAccess.SqlServer sqlInstance)
        {
            this.sqlInstance = sqlInstance;
        }

        public CompanyRepository(Models.DbSettings settings)
        {
            this.sqlInstance = new Demo.DataAccess.SqlServer(settings.ConnectionString);
        }

        public ActionResult GetAll()
        {
            try
            {
                var data = sqlInstance.GetFromStoreProcedureAsObjects<Company>("USP_Company_Get", null);
                return new ActionResult(data);
            }
            catch (Exception ex)
            {
                return new ActionResult(ex.Message);
            }
            
        }

        public ActionResult GetById(int id)
        {
            try
            {
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@CompanyId", id);
                var data = sqlInstance.GetFromStoreProcedureAsObjects<Company>("USP_Company_Get", parameters).FirstOrDefault();
                return new ActionResult(data);
            }
            catch (Exception ex)
            {
                return new ActionResult(ex.Message);
            }
            
        }

        public ActionResult Add(Company company)
        {
            try
            {
                var parameters = GetParametersEntity(company);
                var data = sqlInstance.GetFromStoreProcedureAsObjects<Company>("USP_Company_Add", parameters).FirstOrDefault();
                return new ActionResult(data);
            }
            catch (Exception ex)
            {
                return new ActionResult(ex.Message);
            }            
        }

        public ActionResult Update(Company company)
        {
            try
            {
                var parameters = GetParametersEntity(company);
                var data = sqlInstance.GetFromStoreProcedureAsObjects<Company>("USP_Company_Upd", parameters).FirstOrDefault();
                return new ActionResult(data);
            }
            catch (Exception ex)
            {
                return new ActionResult(ex.Message);
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                var result = sqlInstance.ExecuteQuery($"USP_Company_Del {id}");                                    
                return new ActionResult(result > 0);
            }
            catch (Exception ex)
            {
                return new ActionResult(ex.Message);
            }
        }

        private Dictionary<string, object> GetParametersEntity(Company company)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@CompanyId", company.CompanyId);
            parameters.Add("@CreatedOn", company.CreatedOn);
            parameters.Add("@DeletedOn", company.DeletedOn);
            parameters.Add("@Email", company.Email);
            parameters.Add("@Fax", company.Fax);
            parameters.Add("@Name", company.Name);
            parameters.Add("@Lastlogin", company.Lastlogin);
            parameters.Add("@password", company.password);
            parameters.Add("@PortalId", company.PortalId);
            parameters.Add("@RoleId", company.RoleId);
            parameters.Add("@Status", company.Status);
            parameters.Add("@Telephone", company.Telephone);
            parameters.Add("@UpdatedOn", company.UpdatedOn);
            parameters.Add("@Username", company.Username);
            return parameters;
        }
    }
}
